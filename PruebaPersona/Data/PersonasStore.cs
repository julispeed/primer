using Microsoft.AspNetCore.Mvc;
using PruebaPersona.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace PruebaPersona.Data
{

    public  class PersonasStore 
    {
        private List<Persona> personas;
        

        //construct
        public PersonasStore(List<Persona> personas)
        {
            this.personas = personas;
        }
        public List<Persona> Datos()
        {
            return personas;
        }

    }
}
