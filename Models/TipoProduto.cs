using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Estoque.Models
{
    public class TipoProduto
    {
        [Key]
        [Required]
        public int id {get; set;}

        [Required (ErrorMessage ="descrição obrigatório")]
        public string descricao {get; set;}

        //teste subida para git

        
    }
}