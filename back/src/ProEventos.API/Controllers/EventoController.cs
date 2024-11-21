using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public EventoController()
    {
       
    }
    
    public IEnumerable<Evento> _eventos=new Evento[]
    {
        new Evento()
        {
            EventoId = 1,
            Tema = "Angular 17 e .Net 8",
            Local = "Urubici",
            Lote = "1º Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy"),
            ImagemUrl = "foto.png"
        },
        new Evento()
        {
            EventoId = 2,
            Tema = "Angular e suas novidades",
            Local = "São Paulo",
            Lote = "2º Lote",
            QtdPessoas = 350,
            DataEvento = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy"),
            ImagemUrl = "foto.png"
        }
    };
    

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _eventos;
    }

    [HttpGet("{id}")]
    public Evento GetById(int id)
    {
        return _eventos.Where((x) => x.EventoId == id).FirstOrDefault();
    }
    
    [HttpPost]
    public string Post()
    {
        return "Hello World, Post!";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Hello World, Put com id = {id}!";
    }
    
    
    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Hello World, Delete com id = {id}!";
    }
}