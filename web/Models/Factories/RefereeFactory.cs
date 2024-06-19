namespace web.Models.Factories;

public class RefereeFactory : BaseUserFactory
{
    public override Referee Create(string name, string lastName, string email, int cedula)
    {
        return new Referee(name, lastName, email, cedula);
    }
    
}