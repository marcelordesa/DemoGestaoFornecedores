import { Setor } from "./setor";

export class Fornecedor {
    id: number;
    nome: string;
    documento: string;
    setorId: number;
    setor: Setor;
}