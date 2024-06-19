using web.Models;
using web.Interfaces;

namespace web.Repositories;

public class DisciplineRepository
{
    private List<IDiscipline> _disciplines = new List<IDiscipline>();
    
    public void Add(IDiscipline discipline)
    {
        _disciplines.Add(discipline);
    }
    
    public List<IDiscipline> GetAll()
    {
        return _disciplines;
    }

    public IDiscipline GetById(string name)
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
