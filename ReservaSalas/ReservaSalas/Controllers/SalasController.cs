using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ReservaSalas.DTO;
using ReservaSalas.Models;
using ReservaSalas.Repository.Interface;
using ReservaSalas.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReservaSalas.Controllers
{
    [Route("api/salas")]
    public class SalasController : ControllerBase
    {
        private readonly ISalasRepository _iSalasRepository;
        private readonly IMapper _iMapper;
        private readonly ISalaService _salaService;

        public SalasController(ISalasRepository salasRepository,
                               IMapper iMapper,
                               ISalaService salaService)
        {
            _iSalasRepository = salasRepository;
            _iMapper = iMapper;
            _salaService = salaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalaDTO>>> ObterTodos()
        {
            var sala = _iMapper.Map<IEnumerable<SalaDTO>>(await _iSalasRepository.ObterTodos());
            return Ok(sala);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<SalaDTO>> ObterPorID(Guid id)
        {
            var sala = _iMapper.Map<SalaDTO>(await _iSalasRepository.ObterPorId(id));
            if (sala == null) return NotFound();

            return sala;
        }

        [HttpPost]
        public async Task<ActionResult<SalaDTO>> Adicionar([FromBody] SalaDTO salaDTO)
        {

            if (!ModelState.IsValid) return BadRequest();

            var sala = _iMapper.Map<Sala>(salaDTO);

            await _salaService.Adicionar(sala);
            return Ok(sala);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<SalaDTO>> Atualizar([FromBody] SalaDTO salaDTO)
        {

            if (!ModelState.IsValid) return BadRequest();

            var sala = _iMapper.Map<Sala>(salaDTO);

            await _salaService.Adicionar(sala);
            return Ok(sala);
        }
    }
}
