using System;
using Microsoft.EntityFrameworkCore;
using P1_API1_Ismarlin_20180846.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_API1_Ismarlin_20180846.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Aportes> Aportes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\AportesControl.db");
        }
    }
}
