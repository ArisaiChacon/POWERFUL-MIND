using Microsoft.AspNetCore.Mvc;
using PowerfulMind.Controllers.Base;
using PowerfulMind.Data;
using PowerfulMind.Models;

namespace PowerfulMind.Controllers;

[ApiController, Route ("api/[controller]")]
public class DiagnosticoController : ApiControllerBase<Diagnostico>
{
    public DiagnosticoController(DataContext context, ILogger<Diagnostico> logger) : base(context, logger)
    {
            
    }
}
