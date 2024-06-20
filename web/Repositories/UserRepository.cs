using web.Models;

namespace web.Repositories;

public class UserRepository : IRepository<BaseUser, int>
{
    private static UserRepository _instance;
    private UserRepository()
    {
    }

    public static UserRepository GetInstance()
    {
        return _instance ??= new UserRepository();
    }

    private readonly List<BaseUser> _users = new List<BaseUser>();
    
    public void Add(BaseUser baseUser)
    {
        _users.Add(baseUser);
    }
    
    public List<BaseUser> GetAll()
    {
        return _users;
    }

    public BaseUser GetByKey(int cedula)
    {
        var user = _users.FirstOrDefault(p => p.Cedula == cedula);
        if (user == null)
        {
            throw new ArgumentException("User with that cedula was not found");
        }
    
        return user;
    }
    
    public List<BaseUser> GetAllByType(Type type)
    {
        return _users.Where(p => p.GetType() == type).ToList();
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
