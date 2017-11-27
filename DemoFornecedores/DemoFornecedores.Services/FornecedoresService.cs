using DemoFornecedores.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;
using DemoFornecedores.Domain.Entities;
using DemoFornecedores.Domain.Contracts.Repositories;

namespace DemoFornecedores.Services
{
    public class FornecedoresService : IFornecedoresService
    {
        private IRepository Repository;

        public FornecedoresService(IRepository repository)
        {
            this.Repository = repository;
        }

        public void AtualizaFornecedor(Fornecedor fornecedor)
        {
            this.Repository.Atualiza(fornecedor);
        }

        public void ExcluiFornecedor(int id)
        {
            this.Repository.Exclui(id);
        }

        public void InseriFornecedor(Fornecedor fornecedor)
        {
            this.Repository.Inseri(fornecedor);
        }

        public Fornecedor RertornaFornecedorPorId(int id)
        {
            return this.Repository.RetornaPorId(id) as Fornecedor;
        }

        public IEnumerable<Fornecedor> RetornaTodosFornecedores()
        {
            return this.Repository.RetornaTodos() as IEnumerable<Fornecedor>;
        }
    }
}