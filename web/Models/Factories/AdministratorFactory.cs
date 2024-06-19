namespace web.Models.Factories;

public class AdministratorFactory : BaseUserFactory
{
    public override Administrator Create(string name, string lastName, string email, int cedula)
    {
        return new Administrator(name, lastName, email, cedula);
    }
}