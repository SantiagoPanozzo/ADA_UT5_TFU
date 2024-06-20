using web.Interfaces;

namespace web.Models;

public abstract class AbstractHandler : IHandler
{
	protected IHandler _next;

	public IHandler SetNext(IHandler handler)
	{
		this._next = handler;
		return handler;
	}
	
	public virtual object Handle(object request)
	{
		if (this._next != null)
		{
			return this._next.Handle(request);
		}
		else
		{
			return null;
		}
	}
}
