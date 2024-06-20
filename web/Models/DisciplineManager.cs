using web.Interfaces;
using web.Repositories;

namespace web.Models
{
	public class DisciplineManager
	{
		private static DisciplineManager instance;

		private DisciplineManager(){}

		public static DisciplineManager GetInstance()
		{
			if (instance == null)
			{
				instance = new DisciplineManager();
			}
			return instance;
		}
		
		public List<IDiscipline> CreateFencingDisciplines(BaseUser user)
		{
			FencingFactory fencingFactory = FencingFactory.getInstance();
			IHandler proxy = new ProxyAdmin();
			proxy.SetNext(FencingFactory.getInstance());
			List<IDiscipline> disciplines = (List<IDiscipline>)(proxy.Handle(user));
			FencingRepository disciplineRep = new FencingRepository();
			foreach (var dis in disciplines)
			{
			    disciplineRep.Add(dis);
			}
			return disciplineRep.GetAll();
		}

		public double CalculateFencingDisciplines(BaseUser user)
		{
			IHandler proxy = new ProxyReferee();
			proxy.SetNext(FencingFactory.getInstance());
			return (double)(proxy.Handle(user));
		}
	}
}


