using web.Interfaces;

namespace web.Models
{
	public class ProxyAthlete : AbstractHandler
	{
		private bool CheckAccess(object user)
		{
			return user is Athlete;
		}

		public override object Handle(object request)
		{
			if (CheckAccess(request))
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
