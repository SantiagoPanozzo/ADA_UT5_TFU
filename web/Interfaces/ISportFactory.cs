namespace web.Interfaces;

public interface ISportFactory
{
	List<IDiscipline> CreateDisciplines();
	ISportFactory getInstance();
}
