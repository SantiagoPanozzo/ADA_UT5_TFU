using web.Interfaces.Disciplines;

namespace web.Repositories;

public class FencingRepository : BaseDisciplineRepository<IFencing>
{
    private static FencingRepository? _instance = null;
    private FencingRepository() {}
    
    public static FencingRepository GetInstance()
    {
        return _instance ??= new FencingRepository();
    }
}