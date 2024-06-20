using web.Utils;

namespace web.Models;

public class Administrator(string name, string lastName, string email, int cedula, string password)
    : BaseUser(name, lastName, email, cedula, password)
{
}