using web.Models;

namespace web.Repositories;

public class PersonaRepository
{
    private List<Persona> _personas = new List<Persona>();
    
    public void Add(Persona persona)
    {
        _personas.Add(persona);
    }
    
    public List<Persona> GetAll()
    {
        return _personas;
    }

    public Persona GetById(int cedula)
    {
        return _personas.FirstOrDefault(p => p.Cedula == cedula);
    }
    
    public void Remove(int cedula)
    {
        _personas.RemoveAll(p => p.Cedula == cedula);
    }
    
    public void Update(Persona persona)
    {
        var index = _personas.FindIndex(p => p.Cedula == persona.Cedula);
        _personas[index] = persona;
    }
}