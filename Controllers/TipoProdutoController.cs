using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estoque.Models;
using Microsoft.AspNetCore.Mvc;


namespace Estoque.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoProdutoController : ControllerBase
    {
        private static List<TipoProduto> tipoProdutos = new List<TipoProduto>();
        private static int Id = 1;

        [HttpPost]
        public IActionResult Adicionar([FromBody] TipoProduto tipoproduto)
        {
            tipoproduto.id = Id++;
            tipoProdutos.Add(tipoproduto);
            return CreatedAtAction(nameof(recuperarPorId), new {id = tipoproduto.id },tipoproduto);

        }

        [HttpGet]
        public IActionResult recuperar()
        {
            return Ok(tipoProdutos);
        }

        [HttpGet("{id}")]
        public IActionResult recuperarPorId(int Id)
        {

            TipoProduto tipoProduto =  tipoProdutos.FirstOrDefault(tipoproduto => tipoproduto.id == Id);
            if(tipoProduto != null)
            {
                return Ok(tipoProduto);
            }
            return NotFound();

        }

        public TipoProduto listar()
        {
            Console.wri
        }
            Filme filme = new Filme()
            {
                console.log(filme.nome);
            }
        
        
    }
}