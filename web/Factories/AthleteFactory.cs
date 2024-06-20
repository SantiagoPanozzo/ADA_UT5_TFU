namespace web.Models.Factories;

public class AthleteFactory : BaseUserFactory
{
    private static AthleteFactory instance;
    private AthleteFactory() { }
    public static AthleteFactory GetInstance()
    {
        if (instance == null)
        {
            instance = new AthleteFactory();
        }
        return instance;
    }
    public override Athlete Create(string name, string lastName, string email, int cedula, string password)
    {
        return new Athlete(name, lastName, email, cedula, password);
    }
}