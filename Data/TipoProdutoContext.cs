using Estoque.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estoque.Data
{
    public class TipoProdutoContext : DbContext
    {
        public TipoProdutoContext(DbContextOptions<TipoProdutoContext> opts) : base(opts)
        {

        }
        public DbSet<TipoProduto> TipoProduto { get; set; }
    }
}
