using web.Interfaces.Disciplines;

namespace web.Repositories;

public class AthleticsRepository: BaseDisciplineRepository<IAthletics>
{
    private static AthleticsRepository? _instance = null;
    private AthleticsRepository() {}
    
    public static AthleticsRepository GetInstance()
    {
        return _instance ??= new AthleticsRepository();
    }
}