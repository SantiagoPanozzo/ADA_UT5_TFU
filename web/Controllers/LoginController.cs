using System.Security.Authentication;
using Microsoft.AspNetCore.Mvc;
using web.DTO;
using web.Services;

namespace web.Controllers;

[ApiController]
[Route("[controller]")]
public class LoginController : ControllerBase
{
    UserService _userService = UserService.GetInstance();

    [HttpPost]
    public ActionResult<int> Login(UserLoginDTO userLoginDto)
    {
        try
        {
            _userService.AuthenticateUser(userLoginDto.Cedula, userLoginDto.Password);
            return Ok(userLoginDto.Cedula); // acá iria el token
        }
        catch (ArgumentException e)
        {
            return Unauthorized(e.Message);
        }
    }
}