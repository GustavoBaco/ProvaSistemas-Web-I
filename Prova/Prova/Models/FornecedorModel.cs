using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prova.Models
{
    public class FornecedorModel
    {
        [Key]
        public long FornecedorId { get; set; }
        [Required(ErrorMessage ="Informe o Nome")]
        public string Nome { get; set; }
        [EmailAddress(ErrorMessage ="E-mail Inválido")]
        public string Email { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }

        public ProdutoModel Produto { get; set; }
    }
}