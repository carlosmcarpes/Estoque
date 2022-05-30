using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Estoque.Models
{
    public class TipoProduto
    {
        public int id {get; set;}

        [Required (ErrorMessage ="descri��o obrigat�rio")]
        public string descricao {get; set;}

        
    }
}