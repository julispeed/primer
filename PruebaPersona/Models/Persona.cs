namespace PruebaPersona.Models
{
    public  class Persona
    {
         // Atributos
           // public int Id = 0;

            public string Nombre { get; set; }

            public string Apellido { get; set; }

            public char Sexo { get; set; }

            public int Edad {get; set; }

            //Constructor
        
            public Persona(string nombre, string apellido , int edad, char sexo ) 
            {
                //Id =Id+1;
                Nombre = nombre;
                Apellido = apellido;
                Sexo = sexo;
                Edad=edad;
            }
        
          
            
            // Metodos

        public  List<string> Pdatos ()
        {
            List<string> datos= new List<string>();
            datos.Add($"Nombre: {Nombre}");
            datos.Add($"Apellido: {Apellido}");
            datos.Add($"Edad: {Edad}");
            datos.Add($"Sexo: {Sexo}");

            return datos;

        }

        public string nombre ()
        {
            return Nombre;
        }
    }
}
