using web.Interfaces;
using web.Interfaces.Disciplines;

namespace web.Models
{
	public class Saber : AbstractHandler, IDiscipline, IFencing
	{
		private string _name = "Saber";
		public string Name {get => _name; set => _name = value;}

		public Saber() {}

		public override object Handle(object request) {
			return Calculate(request);
		}

		public double Calculate(object request) {
			return 2;
		}
	}
}
