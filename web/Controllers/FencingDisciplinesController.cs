using Microsoft.AspNetCore.Mvc;
using web.Interfaces;
using web.Repositories;

namespace web.Controllers;

[ApiController]
[Route("[controller]")]
public class FencingDisciplinesController : ControllerBase
{
    private readonly FencingRepository _fencingRepository = FencingRepository.GetInstance();
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<IDiscipline>>> Get()
    {
        return Ok(_fencingRepository.GetAll());
    }
    
}