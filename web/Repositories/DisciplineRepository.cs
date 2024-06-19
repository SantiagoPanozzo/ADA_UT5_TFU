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

    public Persona GetById(string name)
    {
        return _disciplines.FirstOrDefault(p => p.Name == name);
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
