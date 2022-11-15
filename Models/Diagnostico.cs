using PowerfulMind.Models.Base;

namespace PowerfulMind.Models;

public class Diagnostico: Model
{
    public string? Name {get; set; }
    public int? IdPaciente {get; set;}
    public int? IdTest {get; set;}
    public virtual Paciente? Paciente { get; set; } = default!;
    public virtual Test? Test { get; set; } = default!;
}
