using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_API1_Ismarlin_20180846.Entidades
{
    class Aporte
    {
        [Key]
        public int AporteIid { get; set; }
        public DateTime Fecha { get; set; }
        public String Persona { get; set; }
        public String Concepto { get; set; }
        public double Monto { get; set; }

        public Aporte()
        {
            AporteIid = 0;
            Fecha = DateTime.Now;
            Persona = string.Empty;
            Concepto = string.Empty;
            Monto = 0;
        }
    }
}
