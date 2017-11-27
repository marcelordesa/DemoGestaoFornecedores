using DemoFornecedores.Domain.Contracts.Repositories;
using DemoFornecedores.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;
using DemoFornecedores.Domain.Entities;

namespace DemoFornecedores.Services
{
    public class SetoresService : ISetoresService
    {
        private IRepository Repository;

        public SetoresService(IRepository repository)
        {
            this.Repository = repository;
        }

        public IEnumerable<Setor> RetornaTodosSetores()
        {
            return this.Repository.RetornaTodos() as IEnumerable<Setor>;
        }
    }
}