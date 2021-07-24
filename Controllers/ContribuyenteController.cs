using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRnc.Models;
using Microsoft.EntityFrameworkCore;
using ApiRnc.Response;
using ApiRnc.Services;
using ApiRnc.Dtos;
using System;

namespace ApiRnc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class ContribuyenteController : ControllerBase
    {
        private readonly IServices _contribuyenteServices;

        public ContribuyenteController(IServices services)
        {
            this._contribuyenteServices = services;
        }

        [HttpGet("{rnc}")]
        public async Task<ActionResult<Response<DtoContribuyente>>> GetContribuyenteById(string rnc)
        {
            var response = new Response<DtoContribuyente>();
            try
            {
                var contribuyente = await _contribuyenteServices.GetContribuyente(rnc);

                if(contribuyente != null)
                {
                    response.Data = new DtoContribuyente
                    {
                        Rnc = contribuyente.Rnc,
                        RazonSocial =  contribuyente.RazonSocial,
                        NombreComercial = contribuyente.RazonSocial,
                        ActividadEconomica = contribuyente.ActividadEconomica,
                        Fecha = contribuyente.Fecha,
                        Estatus = contribuyente.Estatus,
                        RegimenDePagos = contribuyente.RegimenDePagos
                    };
                }

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                return BadRequest(response);
            }         
            return Ok(response);
        }
    }
}
