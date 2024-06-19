namespace web.Models;

public abstract class BaseUser (string name, string lastName, string email, int cedula)
{
    private string _name = name;
    private string _lastName = lastName;
    private string _email = email;
    private int _cedula = cedula;
    
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
    
    public override string ToString()
    {
        return $"Name: {_name}, Last Name: {_lastName}, Email: {_email}, Cedula: {_cedula}";
    }
}