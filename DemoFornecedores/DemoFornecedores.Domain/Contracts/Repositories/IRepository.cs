using System;
using System.Collections.Generic;
using System.Text;

namespace DemoFornecedores.Domain.Contracts.Repositories
{
    public interface IRepository
    {
        IEnumerable<object> RetornaTodos();
        object RetornaPorId(int id);
        void Inseri(object entity);
        void Atualiza(object entity);
        void Exclui(int id);
    }
}