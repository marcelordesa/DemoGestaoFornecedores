using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DemoFornecedores.Domain.Entities;
using DemoFornecedores.Domain.Contracts.Services;
using DemoFornecedores.FactoryServices.Enums;
using DemoFornecedores.FactoryServices;

namespace DemoFornecedores.UI.Controllers
{
    [Produces("application/json")]
    public class SetorController : Controller
    {
        ISetoresService setoresService = FactoryServices.FactoryService.GetServiceInstance(EnumServices.Setor) as ISetoresService;

        [Route("api/Setor/ListarSetores")]
        [HttpGet]
        public IEnumerable<Setor> ListarSetores()
        {
            var setores = setoresService.RetornaTodosSetores();

            return setores;
        }
    }
}