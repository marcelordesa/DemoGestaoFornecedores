using DemoFornecedores.Domain.Contracts.Repositories;
using DemoFornecedores.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFornecedores.Infraestructure.Repositories
{
    public class SetoresRepository : IRepository
    {
        private DemoFornecedoresContext Context;

        public SetoresRepository()
        {
            this.Context = new DemoFornecedoresContext();
        }

        public IEnumerable<object> RetornaTodos()
        {
            try
            {
                return this.Context.Setores
                    .ToList() as IEnumerable<Setor>;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object RetornaPorId(int id)
        {
            try
            {
                return this.Context.Setores
                    .Where(p => p.Id == id)
                    .FirstOrDefault() as Setor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Inseri(object setor)
        {
            try
            {
                var _setor = setor as Setor;

                this.Context.Setores.Add(_setor);
                this.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Atualiza(object setor)
        {
            try
            {
                var _setor = setor as Setor;

                var setorOld = this.Context.Setores
                .Where(p => p.Id == _setor.Id).FirstOrDefault();

                setorOld.Nome = _setor.Nome;

                this.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Exclui(int id)
        {
            try
            {
                var setor = this.Context.Setores.Where(p => p.Id == id).FirstOrDefault();
                this.Context.Setores.Remove(setor);

                this.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}