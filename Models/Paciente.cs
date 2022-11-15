using PowerfulMind.Models.Base;

namespace PowerfulMind.Models;

public class Paciente: Model
{
        public string? Name {get; set; }

        public string? LastName {get; set; }

        public int? Tel {get; set;}

        public string? Correo {get; set;}

        public int? Edad {get; set;}
    

}
