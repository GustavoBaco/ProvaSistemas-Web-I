using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prova.Models
{
    public class ProdutoModel
    {
        [Key]
        public long ProdutoId { get; set; }
        [Required(ErrorMessage ="Informe o nome do produto:")]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<FornecedorModel> Fornecedor { get; set; }
    }
}