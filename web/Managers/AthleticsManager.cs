using web.Interfaces;
using web.Interfaces.Disciplines;
using web.Repositories;
using web.Services;

namespace web.Models;

public class AthleticsManager : ISportManager<IAthletics>
{
    private static AthleticsManager? _instance = null;

    private AthleticsManager()
    {
        UserManager userManager = UserManager.GetInstance();
        var admin = userManager.GetUserById(55555555);
        this.CreateDisciplines(admin);
    }
    
    public static AthleticsManager GetInstance()
    {
        return _instance ??= new AthleticsManager();
    }
    
    private readonly AthleticsRepository _athleticsRepository = AthleticsRepository.GetInstance();
    private readonly AthleticsFactory _athleticsFactory = AthleticsFactory.GetInstance();
    
    public List<IAthletics> CreateDisciplines(BaseUser user)
    {
        IHandler proxy = new ProxyAdmin(next: _athleticsFactory);
        List<IAthletics> disciplines = (List<IAthletics>)(proxy.Handle(user)); ;
        foreach (var dis in disciplines)
        {
            _athleticsRepository.Add(dis);
        }
        return _athleticsRepository.GetAll();
    }
    
    public double CalculateDisciplines(BaseUser user, MatchDataDTO data)
    {
        IHandler proxy = new ProxyReferee();
        IHandler discipline = (IHandler)_athleticsRepository.GetByKey(data.Discipline);
        proxy.SetNext(discipline);
        var points = (double)(proxy.Handle((user, data)));
        var athlete = UserManager.GetInstance().GetUserById(data.ParticipantCedula);
        return ((Athlete)athlete).AddPoints(points);
    }
    
    public List<IAthletics> GetAll()
    {
        return _athleticsRepository.GetAll();
    }
    
    public IAthletics GetByName(string name)
    {
        return _athleticsRepository.GetByKey(name);
    }
    
    public void Update(IAthletics discipline)
    {
        _athleticsRepository.Update(discipline);
    }
    
    public void Remove(string name)
    {
        _athleticsRepository.Remove(name);
    }
    
    public void Add(IAthletics discipline)
    {
        _athleticsRepository.Add(discipline);
    }
    
}