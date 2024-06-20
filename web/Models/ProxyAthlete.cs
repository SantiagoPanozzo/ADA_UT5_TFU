using web.Interfaces;

namespace web.Models
{
	public class ProxyAthlete : AbstractHandler
	{
		private bool checkAccess(object user)
		{
			return user is Athlete;
		}

		public override object Handle(object request)
		{
			if (checkAccess(request) && (this._next != null))
			{
				return base.Handle(request);
			}
			else
			{
				return null;
			}
		}
	}
}
