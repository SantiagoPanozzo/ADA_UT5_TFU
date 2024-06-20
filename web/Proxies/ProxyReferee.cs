using web.Interfaces;

namespace web.Models
{
	public class ProxyReferee : AbstractHandler
	{
		private bool checkAccess(object user)
		{
			return user is Referee;
		}

		public override object Handle(object request)
		{
			(BaseUser user, MatchDataDTO data) = ((BaseUser, MatchDataDTO))request;
			if (checkAccess(user))
			{
				return base.Handle(data);
			}
			else
			{
				return null;
			}
		}
	}
}
