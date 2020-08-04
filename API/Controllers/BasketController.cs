using System.Threading.Tasks;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using negotium.API.Controllers;
using negotium.API.Dtos;

namespace API.Controllers
{
    public class BasketController : BaseApiController
    {
        private readonly IMapper _mapper;

        private readonly IBasketRepository _basketRepository;
        public BasketController(IBasketRepository basketRepository, IMapper mapper)
        {
            _mapper = mapper;
            _basketRepository = basketRepository;

        }
        [HttpGet]
        public async Task<ActionResult<CustomerBasketDto>> GetBasketById(string id)
        {
            var basket = await _basketRepository.GetBasketAsync(id);
            return Ok(basket ?? new CustomerBasket(id));


        }
        [HttpPost]
        public async Task<ActionResult<CustomerBasket>> UpdateBasket(CustomerBasketDto basket)
        {
            var customerBasket = _mapper.Map<CustomerBasketDto,CustomerBasket>(basket);
            var UpdateBasket = await _basketRepository.UpdateBasketAsync(customerBasket);
            return Ok(UpdateBasket);
        }
        [HttpDelete]
        public async Task DeleteBasketAsync(string id)
        {
            await _basketRepository.DeleteBasketAsync(id);
        }


    }

}