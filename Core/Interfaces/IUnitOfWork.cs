using System;
using System.Threading.Tasks;
using Core.Entities;
using negotium.Core.Interfaces;

namespace Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> Repositroy<TEntity>() where TEntity: BaseEntity;

        Task<int> Complete();
    }
}