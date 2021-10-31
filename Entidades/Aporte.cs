using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_API1_Ismarlin_20180846.Entidades
{
   public class Aporte
    {
        [Key]
        public int AporteId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Persona { get; set; }
        public string Concepto { get; set; }
        public int Monto { get; set; }
    }
}
