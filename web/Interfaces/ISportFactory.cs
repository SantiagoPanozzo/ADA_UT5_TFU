namespace web.Interfaces;

public interface ISportFactory<T> where T : IDiscipline
{
	List<T> CreateDisciplines();
}
