using web.Interfaces;

namespace web.Models
{
	public class ProxyAdmin : AbstractHandler
	{
		private bool CheckAccess(object user)
		{
			return user is Administrator;
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
