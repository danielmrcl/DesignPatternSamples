using AutoMapper;
using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using DesignPatternSamples.WebAPI.Models;
using DesignPatternSamples.WebAPI.Models.Detran;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.WebAPI.Controllers.Detran
{
    [Route("api/Detran/[controller]")]
    [ApiController]
    public class PontosController : ControllerBase
    {
        private readonly IMapper _Mapper;
        private readonly IDetranCarteiraPontosService _DetranCarteiraPontosService;

        public PontosController(IMapper mapper, IDetranCarteiraPontosService detranCarteiraPontosService)
        {
            _Mapper = mapper;
            _DetranCarteiraPontosService = detranCarteiraPontosService;
        }

        [HttpGet()]
        [ProducesResponseType(typeof(SuccessResultModel<IEnumerable<CarteiraPontosModel>>), StatusCodes.Status200OK)]
        public async Task<ActionResult> Get([FromQuery]CarteiraModel model)
        {
            var pontos = await _DetranCarteiraPontosService.ConsultarPontos(_Mapper.Map<Carteira>(model));

            var result = new SuccessResultModel<IEnumerable<CarteiraPontosModel>>(_Mapper.Map<IEnumerable<CarteiraPontosModel>>(pontos));

            return Ok(result);
        }
    }
} 