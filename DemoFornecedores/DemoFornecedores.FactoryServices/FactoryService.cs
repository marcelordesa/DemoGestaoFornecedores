using DemoFornecedores.Domain.Contracts.Repositories;
using DemoFornecedores.Domain.Contracts.Services;
using DemoFornecedores.FactoryRepositories;
using DemoFornecedores.FactoryServices.Enums;
using DemoFornecedores.Infraestructure.Repositories;
using DemoFornecedores.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoFornecedores.FactoryServices
{
    public class FactoryService
    {
        public FactoryService()
        {

        }

        public static object GetServiceInstance(EnumServices opcao)
        {
            if (opcao == EnumServices.Fornecedor)
                return InstanceServiceFornecedor();
            if (opcao == EnumServices.Setor)
                return InstanceServiceSetor();

            return null;
        }

        private static object InstanceServiceFornecedor()
        {
            IRepository repository = FactoryRepository.GetRepositoryInstance<FornecedoresRepository>();
            IFornecedoresService service = new FornecedoresService(repository);

            return service;
        }

        private static object InstanceServiceSetor()
        {
            IRepository repository = FactoryRepository.GetRepositoryInstance<SetoresRepository>();
            ISetoresService service = new SetoresService(repository);

            return service;
        }
    }
}