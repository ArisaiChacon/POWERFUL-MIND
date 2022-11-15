using Microsoft.AspNetCore.Mvc;
using PowerfulMind.Controllers.Base;
using PowerfulMind.Data;
using PowerfulMind.Models;

namespace PowerfulMind.Controllers;

[ApiController, Route ("api/[controller]")]
public class TestController : ApiControllerBase<Test>
{
    public TestController(DataContext context, ILogger<Test> logger) : base(context, logger)
    {
            
    }
}