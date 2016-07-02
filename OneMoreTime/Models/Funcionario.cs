using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OneMoreTime.Models
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string FunNome { get; set; }
        public string FunEndereco{ get; set; }
        public string FunTelefone { get; set; }
        public string FunCargo { get; set; }
        public string FunCPF { get; set; }
    }

    public class FuncionarioDBContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}