using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaEventos.API.Models;

namespace SistemaEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
       public IEnumerable<Evento> _eventos = new Evento[] {
                new Evento(){
                EventoId = 1,
                Tema = "Campeonato de Tennis",
                Local = "São Paulo - Morumbi - Amorim Tennis",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                Lote = "1° Lote",
                ImagemURL = "https://amorim-tennis.herokuapp.com/#/inicio"
                },
                
                new Evento(){
                EventoId = 2,
                Tema = "Campeonato de Tennis",
                Local = "São Paulo - Morumbi - Play Tennis",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                Lote = "2° Lote",
                ImagemURL = "http://www.playtennis.com.br/produtos/eventos"
                }
            };    

        public EventoController()
        {            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {    
            return _eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {    
            return _eventos.Where(eventos => eventos.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {    
            return  "Metodo Post";
        }

        [HttpPut]
        public string Put()
        {    
            return  "Metodo Put";
        }

        [HttpDelete]
        public string Delete()
        {    
            return  "Metodo Delete";
        }
    }
}
