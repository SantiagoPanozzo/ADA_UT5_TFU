using web.Utils;
using web.Models;
namespace web.DTO;

public class UserRegistrationDTO(string name, string lastName, string email, int cedula, string password, UserType type)
    : BaseUser(name, lastName, email, cedula, password)
{
    public UserType Type { get; set; } = type;
}