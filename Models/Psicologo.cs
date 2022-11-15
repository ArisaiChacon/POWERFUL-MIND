using PowerfulMind.Models.Base;

namespace PowerfulMind.Models;

public class Psicologo: Model
{
    public string? Name {get; set; }

    public string? LastName {get; set; }
    public int? Tel {get; set;}    
    public string? Email {get; set;}
    public string? ExperienciaLaboral {get; set;}
    public int? CedulaProfesional {get; set;}
    public int? Edad {get; set;}


}
