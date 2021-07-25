using ApiRnc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApiRnc.Services
{
    public class ContribuyenteServices : IContribuyenteServices
    {
        private readonly ContrubuyenteContext _contrubuyenteContext;

        public ContribuyenteServices(ContrubuyenteContext contrubuyenteContext)
        {
            this._contrubuyenteContext = contrubuyenteContext;
        }

        public async Task<IEnumerable<Contribuyente>> GetContribuyentes()
        {
            return await _contrubuyenteContext.Contribuyentes.ToListAsync();
        }

        public async Task<Contribuyente> GetContribuyente(string rnc)
        {
            var contribuyente = await _contrubuyenteContext.Contribuyentes
                                .FirstOrDefaultAsync(x => x.Rnc == rnc);                          
            return contribuyente;
        }

        public async Task<Contribuyente> GetContribuyenteByRazonSocial(string razonSocial)
        {
            var contribuyente = await _contrubuyenteContext.Contribuyentes
                                .FirstOrDefaultAsync(x => x.RazonSocial.Contains(razonSocial));
            return contribuyente;
        }
    }
}
