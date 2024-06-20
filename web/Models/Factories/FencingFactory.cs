using web.Interfaces;

namespace web.Models
{
	public class FencingFactory : ISportFactory, IHandler
	{
		private static FencingFactory _fencingFactory {get; set;}

		private IHandler? _next {get; set;}

		private FencingFactory(){}

		public static FencingFactory getInstance()
		{
			if (_fencingFactory == null)
			{
				_fencingFactory = new FencingFactory();
			}
			return _fencingFactory;
		}

		public IHandler SetNext(IHandler handler)
        {
            this._next = handler;
            return handler;
        }

		public object Handle(object request)
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
