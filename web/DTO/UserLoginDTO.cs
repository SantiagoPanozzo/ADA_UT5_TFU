namespace web.DTO;

public class UserLoginDTO(int cedula, string password)
{
    public int Cedula { get; set; } = cedula;
    public string Password { get; set; } = password;
}