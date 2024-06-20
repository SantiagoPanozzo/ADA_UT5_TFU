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
			FencingRepository fencingRep = FencingRepository.GetInstance();
			foreach (var dis in disciplines)
			{
			    fencingRep.Add(dis);
			}
			return fencingRep.GetAll();
		}

		public double CalculateFencingDisciplines(BaseUser user, MatchDataDTO data)
		{
			IHandler proxy = new ProxyReferee();
			FencingRepository fencingRep = FencingRepository.GetInstance();
			IHandler discipline = (IHandler)fencingRep.GetByName(data.Discipline);
			proxy.SetNext(discipline);
			return (double)(proxy.Handle((user, data)));
		}
	}
}


