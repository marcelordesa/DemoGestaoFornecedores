using DemoFornecedores.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoFornecedores.Domain.Contracts.Services
{
    public interface IFornecedoresService
    {
        IEnumerable<Fornecedor> RetornaTodosFornecedores();
        Fornecedor RertornaFornecedorPorId(int id);
        void InseriFornecedor(Fornecedor fornecedor);
        void AtualizaFornecedor(Fornecedor fornecedor);
        void ExcluiFornecedor(int id);
    }
}