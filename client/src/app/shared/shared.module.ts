import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PaginationModule} from 'ngx-bootstrap/pagination';
import { CarouselModule } from 'ngx-bootstrap/Carousel';
import { PagingHeaderComponent } from './components/paging-header/paging-header.component';
import { PagerComponent } from './components/pager/pager.component';
import { OrderTotalsComponent } from './components/order-totals/order-totals.component';
import { ReactiveFormsModule } from '@angular/forms';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { TextInputComponent } from './text-input/text-input.component';



@NgModule({
  declarations: [PagingHeaderComponent, PagerComponent, OrderTotalsComponent, TextInputComponent, TextInputComponent],
  imports: [
    CommonModule,
    PaginationModule.forRoot(),
    CarouselModule.forRoot(),
    BsDropdownModule.forRoot(),
    ReactiveFormsModule
  ],
  exports: [
    PaginationModule,
    PagingHeaderComponent,
    PagerComponent,
    CarouselModule,
    OrderTotalsComponent,
    ReactiveFormsModule,
    BsDropdownModule,
    TextInputComponent
  ]
})
export class SharedModule { }
