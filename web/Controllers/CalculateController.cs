using Microsoft.AspNetCore.Mvc;
using web.Models;
using web.Repositories;

namespace web.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculateController : ControllerBase
{
    DisciplineManager _disciplineManager = DisciplineManager.GetInstance();
    UserRepository _userRepository = UserRepository.GetInstance();
    
    /* A este hay que tirarle en el body de la request un JSON tipo así
    {
        "Sport": "Fencing",
        "Discipline": "Rapier",
        "Participant" : "Juan",
        "Data": "5"
    } 
    */
    [HttpPost]
    public async Task<ActionResult<Double>> Post(MatchDataDTO data)
    {
        var referee = _userRepository.GetById(33333333);
        try
        {
            var result = _disciplineManager.CalculateFencingDisciplines(referee, data);
            return Ok(result);
        }
        catch (UnauthorizedAccessException e)
        {
            return Unauthorized("Unauthorized access to the method CalculateFencingDisciplines. Only referees can access this method.");
        }
    }
}