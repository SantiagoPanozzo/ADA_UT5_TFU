using web.Interfaces;

namespace web.Models
{
	public class FencingFactory : ISportFactory
	{
		private FencingFactory _fencingFactory {get; set;}
		private List<IDiscipline> _disciplines {get; set;}

		private FencingFactory()
		{
		}

		public ISportFactory getInstance()
		{
			if (_fencingFactory == null)
			{
				_fencingFactory = new FencingFactory();
			}
			return _fencingFactory;
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
