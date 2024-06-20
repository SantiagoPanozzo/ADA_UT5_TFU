using web.Interfaces;

namespace web.Models
{
	public class ProxyAdmin : AbstractHandler
	{
		private bool checkAccess(object user)
		{
			return user is Administrator;
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
