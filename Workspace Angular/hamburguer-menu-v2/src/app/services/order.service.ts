import { Injectable } from '@angular/core';
import { Order } from '../models/order';
import { HttpClient } from '@angular/common/http';
import { IOrder } from '../IOrder';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class OrderService {

//http://northwind.servicestack.net/query/orders?id=10248

  private apiURL = 'http://northwind.servicestack.net/query/orders?id=10248';
  private apiURLv2 = "/assets/orders.json";
  private apiURLv3 = "/assets/order.json";

  miOrderServicio : Order = {
    id: 1,
    idCliente: 1,
    nombreVendedor: 'rafalito',
    fechaPedido: '12/12/2012',
    fechaEntrega: '20/12/2018',
    totalPedido: 123,
    listaProductos : [
      { id:1,
        nombre:'patata', 
        precioVenta:10, 
        descripcion:'buena y barata',
        stock:25
      }
    ]
  };

  constructor(private http: HttpClient) { }

  public getOrder(){
    return this.miOrderServicio;
  }

  public getOrderAPI() : Observable<IOrder>{
    return this.http.get<IOrder>(this.apiURLv3);
  }
  
}
