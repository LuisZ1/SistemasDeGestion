import { Product } from './models/product';

export interface IOrder{
    id: number;
    idCliente: number;
    nombreVendedor: string;
    fechaPedido: string;
    fechaEntrega: string;
    totalPedido: number;
    listaProductos : Product[];
}