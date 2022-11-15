using Microsoft.AspNetCore.Mvc;
using PowerfulMind.Controllers.Base;
using PowerfulMind.Data;
using PowerfulMind.Models;

namespace PowerfulMind.Controllers;

[ApiController, Route ("api/[controller]")]
public class PacienteController : ApiControllerBase<Paciente>
{
    public PacienteController(DataContext context, ILogger<Paciente> logger) : base(context, logger)
    {
            
    }
}