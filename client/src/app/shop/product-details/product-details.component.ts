import { Component, OnInit } from '@angular/core';
import { IProduct } from 'src/app/shared/models/product';
import { ShopService } from '../shop.service';
import { ActivatedRoute } from '@angular/router';
import { BreadcrumbService } from 'xng-breadcrumb';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.scss']
})
export class ProductDetailsComponent implements OnInit {
  product: IProduct;

  constructor(private ShopService: ShopService, private activatedRoute: ActivatedRoute, private bcService: BreadcrumbService) {
  this.bcService.set('@productDetails', '');
  }

  ngOnInit() {
    this.loadProduct();
  }

  loadProduct(){
    this.ShopService.getProduct(+this.activatedRoute.snapshot.paramMap.get('id')).subscribe(product => {
       this.product = product;
       this.bcService.set('@productDetails', product.name);
    }, error =>{
       console.log(error);
    });
  }

}
