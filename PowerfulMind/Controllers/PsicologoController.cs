using Microsoft.AspNetCore.Mvc;
using PowerfulMind.Controllers.Base;
using PowerfulMind.Data;
using PowerfulMind.Models;

namespace PowerfulMind.Controllers;

[ApiController, Route ("api/[controller]")]
public class PsicologoController : ApiControllerBase<Psicologo>
{
    public PsicologoController(DataContext context, ILogger<Psicologo> logger) : base(context, logger)
    {
            
    }
}
