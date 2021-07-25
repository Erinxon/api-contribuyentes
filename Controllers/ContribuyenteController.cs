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
using AutoMapper;

namespace ApiRnc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class ContribuyenteController : ControllerBase
    {
        private readonly IContribuyenteServices _contribuyenteServices;
        private readonly IMapper _mapper;

        public ContribuyenteController(IContribuyenteServices services, IMapper mapper)
        {
            this._contribuyenteServices = services;
            this._mapper = mapper;
        }

        [HttpGet("{rnc}")]
        [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 5)]
        public async Task<ActionResult<Response<DtoContribuyente>>> GetByRnc(string rnc)
        {
            var response = new Response<DtoContribuyente>();
            try
            {
                var contribuyente = await _contribuyenteServices.GetContribuyente(rnc);
                if(contribuyente != null)
                {
                    response.Data = _mapper.Map<DtoContribuyente>(contribuyente);
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

        [HttpGet("razonSocial/{razonSocial}")]
        [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 5)]
        public async Task<ActionResult<Response<DtoContribuyente>>> GetByRazonSocial(string razonSocial)
        {
            var response = new Response<DtoContribuyente>();
            try
            {
                var contribuyente = await _contribuyenteServices
                    .GetContribuyenteByRazonSocial(razonSocial);
                if (contribuyente != null)
                {
                    response.Data = _mapper.Map<DtoContribuyente>(contribuyente);
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
