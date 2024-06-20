using web.Interfaces;

namespace web.Models
{
	public class FencingFactory : AbstractHandler, ISportFactory
	{
		private static FencingFactory _fencingFactory {get; set;}

		private FencingFactory(){}

		public static FencingFactory getInstance()
		{
			if (_fencingFactory == null)
			{
				_fencingFactory = new FencingFactory();
			}
			return _fencingFactory;
		}

		public override object Handle(object request)
		{
			return CreateDisciplines();
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
