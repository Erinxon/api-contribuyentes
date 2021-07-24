using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRnc.Models
{
    public class Contribuyente
    {
        [Key]
        public string Rnc { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string ActividadEconomica { get; set; }
        public string Fecha { get; set; }
        public string Estatus { get; set; }
        public string RegimenDePagos { get; set; }
    }
}
