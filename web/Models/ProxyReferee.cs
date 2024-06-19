using web.Interfaces;

namespace web.Models
{
	public class ProxyReferee : IUserHandler
	{
		public IHandler? Next {get; set;}

		public ProxyReferee(IHandler handler)
		{
			Next = handler;
		}

		private bool checkAccess(BaseUser? user)
		{
			return user is Referee;
		}

		public void Handle(BaseUser? user)
		{	
			if (checkAccess(user))
			{
				Next?.Handle();
			}
		}
	}
}
