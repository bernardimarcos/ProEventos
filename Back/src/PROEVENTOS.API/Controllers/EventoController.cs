using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PROEVENTOS.API.Models;

namespace PROEVENTOS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public EventoController()
        {

        }
        public IEnumerable<Evento> _evento = new Evento[]
            {
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular 11 e .NET 5",
                    Local = "Apiúna/SC",
                    Lote = "1° Lote",
                    QntPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemUrl = "Foto.PNG"
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Angular 11 e suas novidades",
                    Local = "Apiúna/SC",
                    Lote = "2° Lote",
                    QntPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/mm/yyyy"),
                    ImagemUrl = "Foto1.PNG"
                }
            };


        [HttpGet]

        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{Id}")]

        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(Evento => Evento.EventoId == id);
        }
    }
}
