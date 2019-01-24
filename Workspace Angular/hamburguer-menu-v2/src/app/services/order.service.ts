import { Injectable } from '@angular/core';
import { Order } from '../models/order';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

//http://northwind.servicestack.net/query/orders?id=10248

  private apiURL = 'http://northwind.servicestack.net/query/orders?id=10248';

  miOrderServicio : Order = {
    id: 1,
    idCliente: 1,
    nombreVendedor: 'rafalito',
    fechaPedido: '12/12/2012',
    fechaEntrega: '20/12/2018',
    totalPedido: 123
  };

  constructor(private http: HttpClient) { }

  public getOrder(){
    return this.miOrderServicio;
  }

  public getOrderAPI(){
    return this.http.get(this.apiURL);
  }
  
}
