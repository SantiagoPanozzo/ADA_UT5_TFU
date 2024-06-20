	using web.Interfaces;
	using web.Interfaces.Disciplines;

	namespace web.Models
{
	public class FencingFactory : AbstractHandler, ISportFactory<IFencing>
	{
		private static FencingFactory _fencingFactory {get; set;}

		private FencingFactory(){}

		public static FencingFactory GetInstance()
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

		public List<IFencing> CreateDisciplines() {
			IFencing sword = new Sword();
			IFencing rapier = new Rapier();
			IFencing saber = new Saber();
			List<IFencing> res = new List<IFencing>{sword, rapier, saber};
			return res;
		}
	}
}
