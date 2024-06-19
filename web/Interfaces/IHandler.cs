using web.Models;

namespace web.Interfaces;

public interface IHandler
{
	public IHandler? Next {get; set;}
	public void Handle();
}
