using web.Utils;

namespace web.Interfaces;

public interface IDiscipline
{
	public string Name {get; set;}
	double Calculate(object request);
}
