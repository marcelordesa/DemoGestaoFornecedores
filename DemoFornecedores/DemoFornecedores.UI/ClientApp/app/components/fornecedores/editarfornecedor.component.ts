import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Fornecedor } from '../../../models/fornecedor'; 
import { Setor } from "../../../models/setor";
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { OnInit } from '@angular/core';

@Component({
    selector: 'editarfornecedor',
    templateUrl: './editarfornecedor.component.html'
})
export class EditarFornecedorComponent implements OnInit {
    public fornecedor: Fornecedor;
    public setores: Setor[];
    private id: number;
    public nomeFornecedor: string;
    public documentoFornecedor: string;
    public setorId: number;
    private _baseUrl: string;
    private _http: Http;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string, private route: ActivatedRoute,
        private router: Router) {

        this._baseUrl = baseUrl;
        this._http = http;
    }

    ngOnInit() {

        this.id = +this.route.snapshot.params['id'];

        this._http.get(this._baseUrl + 'api/Fornecedor/FornecedorePorId/' + this.id).subscribe(result => {
            this.fornecedor = result.json() as Fornecedor;
            this.nomeFornecedor = this.fornecedor.nome;
            this.documentoFornecedor = this.fornecedor.documento;
            this.setorId = this.fornecedor.setorId;

            this.loadSetores();

        }, error => console.error(error));

    }

    loadSetores() {
        this._http.get(this._baseUrl + 'api/Setor/ListarSetores').subscribe(result => {
            this.setores = result.json() as Setor[];

        }, error => console.error(error));
    }

    salvar() {
        let mensagem = "";

        if (this.nomeFornecedor == "" || this.nomeFornecedor == null) {
            mensagem = mensagem + "\nInforme o nome do fornecedor";
        }

        if (this.documentoFornecedor == "" || this.documentoFornecedor == null) {
            mensagem = mensagem + "\nInforme o documento do fornecedor";
        }

        if (this.setorId == 0 || this.setorId == null) {
            mensagem = mensagem + "\nEscolha o setor do fornecedor";
        }

        if (mensagem != "") {
            alert(mensagem);
            return;
        }

        let fornecedor = {
            "Nome": this.nomeFornecedor,
            "Documento": this.documentoFornecedor,
            "SetorId": this.setorId
        };

        this._http.put(this._baseUrl + 'api/Fornecedor/AtualizaFornecedor/' + this.fornecedor.id, fornecedor).subscribe(result => {
            this.router.navigate(['/lista-fornecedores']);

        }, error => console.error(error));
    }
}