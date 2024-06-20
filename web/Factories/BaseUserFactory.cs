namespace web.Models.Factories;

public abstract class BaseUserFactory
{
    public abstract BaseUser Create(string name, string lastName, string email, int cedula, string password);
}