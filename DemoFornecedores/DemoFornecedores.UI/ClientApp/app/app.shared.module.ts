import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { ListaFornecedoresComponent } from './components/fornecedores/listafornecedores.component';
import { EditarFornecedorComponent } from './components/fornecedores/editarfornecedor.component';
import { CadastrarFornecedorComponent } from './components/fornecedores/cadastrarfornecedor.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        ListaFornecedoresComponent,
        EditarFornecedorComponent,
        CadastrarFornecedorComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'lista-fornecedores', component: ListaFornecedoresComponent },
            { path: 'editar-fornecedor/:id', component: EditarFornecedorComponent },
            { path: 'cadastrar-fornecedor', component: CadastrarFornecedorComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModuleShared {
}
