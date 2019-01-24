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

  constructor(public miOrderService: OrderService) { }

  ngOnInit() {
    this.miOrder = this.miOrderService.getOrder();
  }

}
