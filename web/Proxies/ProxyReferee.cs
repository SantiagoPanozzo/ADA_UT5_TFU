using web.Interfaces;

namespace web.Models
{
	public class ProxyReferee : AbstractHandler
	{
		private bool CheckAccess(object user)
		{
			return user is Referee;
		}

		public override object Handle(object request)
		{
			(BaseUser user, MatchDataDTO data) = ((BaseUser, MatchDataDTO))request;
			if (CheckAccess(user))
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
