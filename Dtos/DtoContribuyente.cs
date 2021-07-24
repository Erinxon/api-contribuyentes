using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRnc.Dtos
{
    public class DtoContribuyente
    {
        public string Rnc { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string ActividadEconomica { get; set; }
        public string Fecha { get; set; }
        public string Estatus { get; set; }
        public string RegimenDePagos { get; set; }
    }
}
