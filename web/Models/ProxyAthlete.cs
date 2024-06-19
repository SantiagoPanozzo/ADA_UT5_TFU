using web.Interfaces;

namespace web.Models
{
	public class ProxyAthlete : IUserHandler
	{
		public IHandler? Next {get; set;}

		public ProxyAthlete(IHandler handler)
		{
			Next = handler;
		}

		private bool checkAccess(BaseUser? user)
		{
			return user is Athlete;
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
