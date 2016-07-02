using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OneMoreTime.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string ProNome { get; set; }
        public string ProPercLucro { get; set; }
        public string ProQtdEstoque { get; set; }
        public string ProDescricao { get; set; }
    }
    public class ProdutoDBContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}