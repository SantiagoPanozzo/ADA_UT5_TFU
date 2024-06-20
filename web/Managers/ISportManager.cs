using web.Interfaces;

namespace web.Models;

public interface ISportManager<T> where T : IDiscipline
{
    List<T> CreateDisciplines(BaseUser user);
    double CalculateDisciplines(BaseUser user, MatchDataDTO data);
}