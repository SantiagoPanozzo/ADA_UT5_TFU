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
    private readonly UserManager _userManager = UserManager.GetInstance();
    
    [HttpPost]
    public ActionResult<BaseUser> Post(UserRegistrationDTO user)
    {
        switch (user.Type)
        {
            case UserType.Administrator:
                _userManager.AddAdministrator(user.Name, user.LastName, user.Email, user.Cedula, user.Password);
                break;
            case UserType.Athlete:
                _userManager.AddAthlete(user.Name, user.LastName, user.Email, user.Cedula, user.Password);
                break;
            case UserType.Referee:
                _userManager.AddReferee(user.Name, user.LastName, user.Email, user.Cedula, user.Password);
                break;
            default:
                throw new Exception("Invalid user type");
        }
        return Ok(_userManager.GetUserById(user.Cedula));
    }
    
}