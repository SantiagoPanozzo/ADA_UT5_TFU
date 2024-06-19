namespace web.Models.Factories;

public class RefereeFactory : BaseUserFactory
{
    private static RefereeFactory instance;
    private RefereeFactory() { }
    public static RefereeFactory GetInstance()
    {
        if (instance == null)
        {
            instance = new RefereeFactory();
        }
        return instance;
    }
    public override Referee Create(string name, string lastName, string email, int cedula)
    {
        return new Referee(name, lastName, email, cedula);
    }
    
}