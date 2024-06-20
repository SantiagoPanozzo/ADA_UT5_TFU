namespace web.Models.Factories;

public class AdministratorFactory : BaseUserFactory
{
    private static AdministratorFactory instance;
    private AdministratorFactory() { }
    public static AdministratorFactory GetInstance()
    {
        if (instance == null)
        {
            instance = new AdministratorFactory();
        }
        return instance;
    }
    public override Administrator Create(string name, string lastName, string email, int cedula, string password)
    {
        return new Administrator(name, lastName, email, cedula, password);
    }
}