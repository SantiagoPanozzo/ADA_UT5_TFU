using Microsoft.AspNetCore.Mvc;
using web.Models;
using web.Services;
using web.Utils;
using web.DTO;

namespace web.Controllers;

[ApiController]
[Route("[controller]")]
public class RegisterController : ControllerBase
{
    private readonly UserService _userService = UserService.GetInstance();
    
    [HttpPost]
    public ActionResult<BaseUser> Post(UserRegistrationDTO user)
    {
        switch (user.Type)
        {
            case UserType.Administrator:
                _userService.AddAdministrator(user.Name, user.LastName, user.Email, user.Cedula, user.Password);
                break;
            case UserType.Athlete:
                _userService.AddAthlete(user.Name, user.LastName, user.Email, user.Cedula, user.Password);
                break;
            case UserType.Referee:
                _userService.AddReferee(user.Name, user.LastName, user.Email, user.Cedula, user.Password);
                break;
            default:
                throw new Exception("Invalid user type");
        }
        return Ok(_userService.GetUserById(user.Cedula));
    }
    
}