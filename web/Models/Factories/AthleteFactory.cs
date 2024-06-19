namespace web.Models.Factories;

public class AthleteFactory : BaseUserFactory
{
    public override Athlete Create(string name, string lastName, string email, int cedula)
    {
        return new Athlete(name, lastName, email, cedula);
    }
}