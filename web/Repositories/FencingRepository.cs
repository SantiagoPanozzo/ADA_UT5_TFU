using web.Models;
using web.Interfaces;

namespace web.Repositories;

public class FencingRepository
{

    private static FencingRepository? _instance = null;
    private FencingRepository() { }

    public static FencingRepository GetInstance()
    {
        return _instance ??= new FencingRepository();
    } 
    
    private List<IDiscipline> _disciplines = [];
    
    public void Add(IDiscipline discipline)
    {
        _disciplines.Add(discipline);
    }
    
    public List<IDiscipline> GetAll()
    {
        return _disciplines;
    }

    public IDiscipline GetByName(string name)
    {
        var discipline = _disciplines.FirstOrDefault(d => d.Name == name);
        if (discipline == null)
        {
            throw new ArgumentException("Discipline with that name was not found");
        }
        return discipline;
    }
    
    public void Remove(string name)
    {
        _disciplines.RemoveAll(p => p.Name == name);
    }
    
    public void Update(IDiscipline discipline)
    {
        var index = _disciplines.FindIndex(p => p.Name == discipline.Name);
        _disciplines[index] = discipline;
    }
}
