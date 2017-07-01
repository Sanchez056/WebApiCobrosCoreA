using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCobrosCore.Models
{
    public class Cobros
    {
        [Key]
        public int IdCobro { get; set; }
        public DateTime Fecha { get; set; }
        public string Referencia { get; set; }
        public int IdRemoto { get; set; }
        public int IdRuta { get; set; }
        public decimal Mora { get; set; }
        public decimal Monto { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string EsNulo { get; set; }
    }
}
