import { Component, OnInit } from '@angular/core';
import { OrderService } from '../../services/order.service'
import { Order } from 'src/app/models/order';

@Component({
  selector: 'app-order-details',
  templateUrl: './order-details.component.html',
  styleUrls: ['./order-details.component.css']
})
export class OrderDetailsComponent implements OnInit {

  miOrder : Order ;
  public milistaProductos = [];

  constructor(public miOrderService: OrderService) { }

  ngOnInit() {
    this.miOrderService.getOrderAPI()
      .subscribe(data => this.miOrder = data);

     // this.milistaProductos = this.miOrder.listaProductos;

  }

}
