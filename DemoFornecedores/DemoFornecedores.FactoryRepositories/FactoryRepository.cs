using System;
using System.Collections.Generic;
using System.Text;
using DemoFornecedores.Domain.Contracts.Repositories;

namespace DemoFornecedores.FactoryRepositories
{
    public class FactoryRepository
    {
        public FactoryRepository()
        {

        }

        public static IRepository GetRepositoryInstance<T>() where T : IRepository, new()
        {
            return new T();
        }
    }
}