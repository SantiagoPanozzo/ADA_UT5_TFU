using web.Interfaces;

namespace web.Models
{
	public class FencingFactory : ISportFactory, IHandler
	{
		private static FencingFactory _fencingFactory {get; set;}
		private List<IDiscipline> _disciplines {get; set;}
		public IHandler? Next {get; set;}

		private FencingFactory(IHandler? handler)
		{
			Next = handler;
			_disciplines = new List<IDiscipline>();
		}

		public static ISportFactory getInstance()
		{
			if (_fencingFactory == null)
			{
				_fencingFactory = new FencingFactory(null);
			}
			return _fencingFactory;
		}

		public void Handle()
		{
			CreateDisciplines();
		}

		public List<IDiscipline> CreateDisciplines() {
			IDiscipline sword = new Sword();
			IDiscipline rapier = new Rapier();
			IDiscipline saber = new Saber();
			List<IDiscipline> res = new List<IDiscipline>{sword, rapier, saber};
			return res;
		}
	}
}
