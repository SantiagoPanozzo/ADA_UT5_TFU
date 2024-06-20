using web.Utils;

namespace web.Models;

public class Athlete(string name, string lastName, string email, int cedula, string password)
    : BaseUser(name, lastName, email, cedula, password)
{
    public double Points { get; private set; }

    public double AddPoints(double points)
    {
        return this.Points += points;
    }
}