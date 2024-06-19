using web.Interfaces;

namespace web.Models
{
	public class ProxyAdmin : IUserHandler
	{
		public IHandler? Next {get; set;}

		public ProxyAdmin(IHandler handler)
		{
			Next = handler;
		}

		private bool checkAccess(BaseUser? user)
		{
			return user is Administrator;
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