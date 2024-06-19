using web.Models;

namespace web.Interfaces;

public interface IUserHandler
{
	public IHandler? Next {get; set;}
	public void Handle(BaseUser? user);
}
