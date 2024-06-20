using web.Models;

namespace web.Interfaces;

public interface IHandler
{
	IHandler SetNext(IHandler handler);
	object Handle(object request);
}
