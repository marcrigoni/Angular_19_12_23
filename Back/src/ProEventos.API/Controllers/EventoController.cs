using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : Controller
    {        
        private readonly DataContext _dataContext;

        public EventoController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _dataContext.Eventos;
        }

        [HttpGet("{id}")]
        public Evento Get(int id)
        {
            return _dataContext.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }
    }
}