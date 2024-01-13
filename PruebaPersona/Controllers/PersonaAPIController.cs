using PruebaPersona.Models;
using Microsoft.AspNetCore.Mvc;
using PruebaPersona.Data;
using System.Security.Cryptography.X509Certificates;
namespace PruebaPersona.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PersonaAPIController : ControllerBase
    {
        PersonasStore personasStore = new PersonasStore(new List<Persona> { new Persona("julian", "Acuna", 20, 'M'), new Persona("julian", "Acuna", 20, 'M') });
        
        [HttpGet]
        public IEnumerable<Persona> GetNombres()
        {
            return personasStore.Datos();
        }
        [HttpGet("hola")]
        public string porno()
        {
            return "sexo";
        }


        [HttpGet("Nombre:string")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        public ActionResult <Persona> GetAtributos(string nombre)
        {
            if (nombre==null)
            {
                return NotFound();
            }
            var apodo = personasStore.Datos().FirstOrDefault(n => n.Nombre == nombre) ;
            if (apodo.nombre() == "Julian")
            {
                return Ok(apodo);
            }
            return Ok(apodo);
        }

    }
}
