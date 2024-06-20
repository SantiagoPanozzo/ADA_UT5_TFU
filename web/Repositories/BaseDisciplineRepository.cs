using web.Interfaces;

namespace web.Repositories;

public abstract class BaseDisciplineRepository<T>: IRepository<T, string> where T : IDiscipline
{
    private List<T> _disciplines = [];
    
    public void Add(T discipline)
    {
        _disciplines.Add(discipline);
    }
    
    public List<T> GetAll()
    {
        return _disciplines;
    }

    public T GetByKey(string name)
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

    public void Update(T discipline)
    {
        var index = _disciplines.FindIndex(p => p.Name == discipline.Name);
        _disciplines[index] = discipline;
    }
}