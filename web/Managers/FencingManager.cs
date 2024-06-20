using web.Interfaces;
using web.Interfaces.Disciplines;
using web.Repositories;
using web.Services;

namespace web.Models
{
	public class FencingManager : ISportManager<IFencing>
	{
		private static FencingManager instance;

		private FencingManager()
		{
			UserService userService = UserService.GetInstance();
			var admin = userService.GetUserById(55555555);
			this.CreateDisciplines(admin);
		}

		public static FencingManager GetInstance()
		{
			if (instance == null)
			{
				instance = new FencingManager();
			}
			return instance;
		}
		
		private readonly FencingRepository _fencingRepository = FencingRepository.GetInstance();
		private readonly FencingFactory _fencingFactory = FencingFactory.GetInstance();
		
		public List<IFencing> CreateDisciplines(BaseUser user)
		{
			FencingFactory fencingFactory = FencingFactory.GetInstance();
			IHandler proxy = new ProxyAdmin(next: fencingFactory);
			List<IFencing> disciplines = (List<IFencing>)(proxy.Handle(user));
			foreach (var dis in disciplines)
			{
			    _fencingRepository.Add(dis);
			}
			return _fencingRepository.GetAll();
		}

		public double CalculateDisciplines(BaseUser user, MatchDataDTO data)
		{
			IHandler proxy = new ProxyReferee();
			FencingRepository disciplineRep = FencingRepository.GetInstance();
			IHandler discipline = (IHandler)disciplineRep.GetByKey(data.Discipline);
			proxy.SetNext(discipline);
			return (double)(proxy.Handle((user, data)));
		}
		
		public List<IFencing> GetAll()
		{
			return _fencingRepository.GetAll();
		}
		
		public IFencing GetByName(string name)
		{
			return _fencingRepository.GetByKey(name);
		}
		
		public void Update(IFencing discipline)
		{
			_fencingRepository.Update(discipline);
		}
		
		public void Remove(string name)
		{
			_fencingRepository.Remove(name);
		}
		
		public void Add(IFencing discipline)
		{
			_fencingRepository.Add(discipline);
		}
		
	}
}


