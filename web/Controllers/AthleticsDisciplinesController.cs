using Microsoft.AspNetCore.Mvc;
using web.Interfaces;
using web.Models;

namespace web.Controllers;

[ApiController]
[Route("[controller]")]
public class AthleticsDisciplinesController : ControllerBase
{
    private readonly AthleticsManager _athleticsManager = AthleticsManager.GetInstance();
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<IDiscipline>>> Get()
    {
        return Ok(_athleticsManager.GetAll());
    }
}