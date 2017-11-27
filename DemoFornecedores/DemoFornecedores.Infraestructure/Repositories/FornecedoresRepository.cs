using DemoFornecedores.Domain.Contracts.Repositories;
using DemoFornecedores.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFornecedores.Infraestructure.Repositories
{
    public class FornecedoresRepository : IRepository
    {
        private DemoFornecedoresContext Context;

        public FornecedoresRepository()
        {
            this.Context = new DemoFornecedoresContext();
        }

        public IEnumerable<object> RetornaTodos()
        {
            try
            {
                return this.Context.Fornecedores
                    .Include(f => f.Setor)
                    .ToList() as IEnumerable<Fornecedor>;
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
                return this.Context.Fornecedores
                    .Include(f => f.Setor)
                    .Where(p => p.Id == id)
                    .FirstOrDefault() as Fornecedor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Inseri(object fornecedor)
        {
            try
            {
                var _fornecedor = fornecedor as Fornecedor;

                this.Context.Fornecedores.Add(_fornecedor);
                this.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Atualiza(object fornecedor)
        {
            try
            {
                var _fornecedor = fornecedor as Fornecedor;

                var fornecedorOld = this.Context.Fornecedores
                .Where(p => p.Id == _fornecedor.Id).FirstOrDefault();

                fornecedorOld.Nome = _fornecedor.Nome;
                fornecedorOld.Documento = _fornecedor.Documento;
                fornecedorOld.SetorId = _fornecedor.SetorId;

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
                var fornecedor = this.Context.Fornecedores.Where(p => p.Id == id).FirstOrDefault();
                this.Context.Fornecedores.Remove(fornecedor);

                this.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}