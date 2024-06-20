using System.Security.Authentication;
using web.Models;
using web.Models.Factories;
using web.Repositories;

namespace web.Services;

public class UserService
{
    private static UserService? _instance;
    private UserService()
    {
    }

    public static UserService GetInstance()
    {
        return _instance ??= new UserService();
    }
    
    private readonly UserRepository _userRepository = UserRepository.GetInstance();
    private readonly AthleteFactory _athleteFactory = AthleteFactory.GetInstance();
    private readonly AdministratorFactory _administratorFactory = AdministratorFactory.GetInstance();
    private readonly RefereeFactory _refereeFactory = RefereeFactory.GetInstance();
    
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
        return _userRepository.GetById(cedula);
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
        var user = _userRepository.GetById(cedula);
        if (user.Password != password)
        {
            throw new ArgumentException("Invalid password");
        }
    }
}