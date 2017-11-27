using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DemoFornecedores.Domain.Entities;
using DemoFornecedores.Domain.Contracts.Services;
using DemoFornecedores.FactoryServices.Enums;

namespace DemoFornecedores.UI.Controllers
{
    [Produces("application/json")]
    public class FornecedorController : Controller
    {
        IFornecedoresService fornecedoresService = FactoryServices.FactoryService.GetServiceInstance(EnumServices.Fornecedor) as IFornecedoresService;

        [Route("api/Fornecedor/ListarFornecedores")]
        [HttpGet]
        public IEnumerable<Fornecedor> ListarFornecedores()
        {
            var fornecedores = fornecedoresService.RetornaTodosFornecedores();
            return fornecedores;
        }

        [Route("api/Fornecedor/FornecedorePorId/{id}")]
        [HttpGet("{id}")]
        public Fornecedor FornecedorePorId(int id)
        {
            var fornecedor = fornecedoresService.RertornaFornecedorPorId(id);
            return fornecedor;
        }

        [Route("api/Fornecedor/InseriFornecedor")]
        [HttpPost]
        public void InseriFornecedor([FromBody]Fornecedor fornecedor)
        {
            fornecedoresService.InseriFornecedor(fornecedor);
        }

        [Route("api/Fornecedor/AtualizaFornecedor/{id}")]
        [HttpPut("{id}")]
        public void AtualizaFornecedor(int id, [FromBody]Fornecedor fornecedor)
        {
            fornecedor.Id = id;
            fornecedoresService.AtualizaFornecedor(fornecedor);
        }

        [Route("api/Fornecedor/ExcluiFornecedor/{id}")]
        [HttpDelete("{id}")]
        public void ExcluiFornecedor(int id)
        {
            fornecedoresService.ExcluiFornecedor(id);
        }
    }
}