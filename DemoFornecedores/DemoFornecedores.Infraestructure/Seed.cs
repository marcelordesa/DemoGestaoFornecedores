using DemoFornecedores.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFornecedores.Infraestructure
{
    public class Seed
    {
        private DemoFornecedoresContext Context;

        public Seed(DemoFornecedoresContext context)
        {
            this.Context = context;
        }

        public async Task SeedSetores()
        {
            if (!this.Context.Setores.Any())
            {
                this.Context.AddRange(RetornaSetores());
                await this.Context.SaveChangesAsync();
            }
        }

        private IEnumerable<Setor> RetornaSetores()
        {
            var setores = new List<Setor>();
            setores.Add(new Setor {
                Nome = "Alimentício"
            });

            setores.Add(new Setor
            {
                Nome = "Administrativo"
            });

            return setores;
        }
    }
}