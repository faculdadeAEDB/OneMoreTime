using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OneMoreTime.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string CliNome { get; set; }
        public string CliEndereco { get; set; }
        public string CliTelefone { get; set; }
        public string CliBairro { get; set; }
        public string CliCidade { get; set; }
    }

    public class ClienteDBContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set;}
    }
}