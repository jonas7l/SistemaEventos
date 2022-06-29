using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaEventos.API.Data;
using SistemaEventos.API.Models;

namespace SistemaEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {        
        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(eventos => eventos.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Metodo Post";
        }

        [HttpPut]
        public string Put()
        {
            return "Metodo Put";
        }

        [HttpDelete]
        public string Delete()
        {
            return "Metodo Delete";
        }
    }
}
