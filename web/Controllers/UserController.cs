using Microsoft.AspNetCore.Mvc;
using web.Models;
using web.Repositories;

namespace web.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly UserRepository _userRepository = UserRepository.GetInstance();
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<BaseUser>>> Get()
    {
        return Ok(_userRepository.GetAll());
    }
    
}