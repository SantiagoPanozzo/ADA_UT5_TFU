using web.Utils;

namespace web.Models;

public abstract class BaseUser (string name, string lastName, string email, int cedula, string password)
{
    private string _name = name;
    private string _lastName = lastName;
    private string _email = email;
    private int _cedula = cedula;
    private string _password = password;
    
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    
    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }
    
    public string Email
    {
        get => _email;
        set => _email = value;
    }
    
    public int Cedula
    {
        get => _cedula; 
        set => _cedula = value;
    }
    
    public string Password
    {
        get => _password;
        set => _password = value;
    }
    
    public override string ToString()
    {
        return $"Name: {_name}, Last Name: {_lastName}, Email: {_email}, Cedula: {_cedula}";
    }
}