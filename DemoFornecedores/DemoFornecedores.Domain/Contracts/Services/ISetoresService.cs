using DemoFornecedores.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoFornecedores.Domain.Contracts.Services
{
    public interface ISetoresService
    {
        IEnumerable<Setor> RetornaTodosSetores();
    }
}