using web.Models;

namespace web.Repositories;

public class UsuarioRepository
{
    private readonly List<BaseUser> _users = new List<BaseUser>();
    
    public void Add(BaseUser baseUser)
    {
        _users.Add(baseUser);
    }
    
    public List<BaseUser> GetAll()
    {
        return _users;
    }

    public BaseUser GetById(int cedula)
    {
        var user = _users.FirstOrDefault(p => p.Cedula == cedula);
        if (user == null)
        {
            throw new ArgumentException("User with that cedula was not found");
        }
    
        return user;
    }
    
    public void Remove(int cedula)
    {
        _users.RemoveAll(p => p.Cedula == cedula);
    }
    
    public void Update(BaseUser baseUser)
    {
        var index = _users.FindIndex(p => p.Cedula == baseUser.Cedula);
        _users[index] = baseUser;
    }
}
