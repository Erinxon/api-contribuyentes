using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRnc.Models;

namespace ApiRnc.Services
{
    public interface IContribuyenteServices
    {
        Task<IEnumerable<Contribuyente>> GetContribuyentes();
        Task<Contribuyente> GetContribuyente(string rnc);
        Task<Contribuyente> GetContribuyenteByRazonSocial(string razonSocial);
    }
}
