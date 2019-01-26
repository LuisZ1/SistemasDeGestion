import { Product } from './product';

export class Order {

    id: number;
    idCliente: number;
    nombreVendedor: string;
    fechaPedido: string;
    fechaEntrega: string;
    totalPedido: number;
    listaProductos : Product[];
}
