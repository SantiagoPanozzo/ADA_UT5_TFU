using Microsoft.AspNetCore.Mvc;
using web.Interfaces;
using web.Interfaces.Disciplines;
using web.Models;
using web.Repositories;

namespace web.Controllers;

[ApiController]
[Route("[controller]")]
public class FencingDisciplinesController : ControllerBase
{
    private readonly FencingManager _fencingManager = FencingManager.GetInstance();
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<IFencing>>> Get()
    {
        return Ok(_fencingManager.GetAll());
    }
    
}