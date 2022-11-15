using PowerfulMind.Models.Base;

namespace PowerfulMind.Models;

public class Test: Model
{

    public string? Name {get; set; }
    public int? Paginacion {get; set;}    

    public virtual Paciente? Paciente { get; set; } = default!;
}

