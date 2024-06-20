using Microsoft.AspNetCore.Mvc;
using web.Models;
using web.Repositories;
using web.Services;

namespace web.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly UserManager _userManager = UserManager.GetInstance();

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BaseUser>>> Get()
    {
        return Ok(_userManager.GetAllUsers());
    }

    [HttpGet(template: "{id}")]
    public async Task<ActionResult<BaseUser>> GetById(int cedula)
    {
        try
        {
            return _userManager.GetUserById(cedula);   
        } catch (ArgumentException e)
        {
            return NotFound(e.Message);
        }
    }
    
    [HttpPut]
    public async Task<ActionResult<BaseUser>> Put(BaseUser baseUser)
    {
        try
        {
            _userManager.AuthenticateUser(baseUser.Cedula, baseUser.Password);
        }
        catch (ArgumentException e)
        {
            return Unauthorized();
        }
        
        try
        {
            _userManager.UpdateUser(baseUser);
            return Ok(_userManager.GetUserById(baseUser.Cedula));
        } catch (ArgumentException e)
        {
            return NotFound(e.Message);
        }
    }

}