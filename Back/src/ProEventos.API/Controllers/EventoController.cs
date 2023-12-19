using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : Controller
    {
        public Evento[] _evento = new Evento[] {
                new Evento() { EventoId = 1, Local = "São Paulo", DataEvento = DateTime.Today.ToShortDateString(), Tema = "Ayrton Senna",     QtdePessoas = 2000, Lote = "Primeiro", ImagemURL = "senna.png" },
                  new Evento() { EventoId = 2, Local = "Rio de Janeiro", DataEvento = DateTime.Today.ToShortDateString(), Tema = "Nelson Piquet",  QtdePessoas = 500, Lote = "Segundo", ImagemURL = "piquet.png" }
            };


        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return this._evento;

        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
            return this._evento.Where(evento => evento.EventoId == id);
        }
    }
}