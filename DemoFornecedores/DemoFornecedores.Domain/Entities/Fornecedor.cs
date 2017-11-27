using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DemoFornecedores.Domain.Entities
{
    public class Fornecedor
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public int SetorId { get; set; }

        public virtual Setor Setor { get; set; }
    }
}