using System.Security.Authentication;
using web.Models;
using web.Models.Factories;
using web.Repositories;

namespace web.Services;

public class UserManager
{
    private readonly UserRepository _userRepository = UserRepository.GetInstance();
    private readonly AthleteFactory _athleteFactory = AthleteFactory.GetInstance();
    private readonly AdministratorFactory _administratorFactory = AdministratorFactory.GetInstance();
    private readonly RefereeFactory _refereeFactory = RefereeFactory.GetInstance();
    
    private static UserManager? _instance;
    private UserManager()
    {
        var juan = _athleteFactory.Create("Juan", "Perez", "juanperez@correo.com", 12345678, "contra");
        var pablo = _administratorFactory.Create("Pablo", "Pablo", "Pablo@correo.com", 55555555, "admin");
        var pablin = _refereeFactory.Create("Pablin", "Pablin", "pablin@correo.com", 33333333, "contra");
        
        _userRepository.Add(juan);
        _userRepository.Add(pablo);
        _userRepository.Add(pablin);
    }

    public static UserManager GetInstance()
    {
        return _instance ??= new UserManager();
    }
    

    
    public void AddAthlete(string name, string lastName, string email, int cedula, string password)
    {
        var athlete = _athleteFactory.Create(name, lastName, email, cedula,  password);
        _userRepository.Add(athlete);
    }
    
    public void AddAdministrator(string name, string lastName, string email, int cedula, string password)
    {
        var admin = _administratorFactory.Create(name, lastName, email, cedula, password);
        _userRepository.Add(admin);
    }
    
    public void AddReferee(string name, string lastName, string email, int cedula, string password)
    {
        var referee = _refereeFactory.Create(name, lastName, email, cedula, password);
        _userRepository.Add(referee);
    }
    
    public List<BaseUser> GetAllUsers()
    {
        return _userRepository.GetAll();
    }
    
    public BaseUser GetUserById(int cedula)
    {
        return _userRepository.GetByKey(cedula);
    }
    
    public void RemoveUser(int cedula)
    {
        _userRepository.Remove(cedula);
    }
    
    public void UpdateUser(BaseUser baseUser)
    {
        _userRepository.Update(baseUser);
    }
    
    public void AuthenticateUser (int cedula, string password)
    {
        var user = _userRepository.GetByKey(cedula);
        if (user.Password != password)
        {
            throw new ArgumentException("Invalid password");
        }
    }
}