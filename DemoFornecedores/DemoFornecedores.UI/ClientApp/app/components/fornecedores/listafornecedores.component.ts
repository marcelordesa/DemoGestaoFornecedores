import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Fornecedor } from '../../../models/fornecedor';
import { OnInit } from '@angular/core';

@Component({
    selector: 'listafornecedores',
    templateUrl: './listafornecedores.component.html'
})
export class ListaFornecedoresComponent implements OnInit {
    public fornecedores: Fornecedor[];
    private _baseUrl: string;
    private _http: Http;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {

        this._baseUrl = baseUrl;
        this._http = http;

    }

    carregaListaFornecedores() {
        this._http.get(this._baseUrl + 'api/Fornecedor/ListarFornecedores').subscribe(result => {
            this.fornecedores = result.json() as Fornecedor[];
        }, error => console.error(error));
    }

    ngOnInit(){
        this.carregaListaFornecedores();
    }

    excluir(fornecedor: Fornecedor) {

        if (confirm('Deseja realmente excluir o fornecedor ' + fornecedor.nome + '?')) {
            this._http.delete(this._baseUrl + 'api/Fornecedor/ExcluiFornecedor/' + fornecedor.id).subscribe(result => {

                this.carregaListaFornecedores();

            }, error => console.error(error));
        }
    }
}