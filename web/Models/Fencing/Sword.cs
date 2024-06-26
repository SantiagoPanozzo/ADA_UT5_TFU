using web.Interfaces;
using web.Interfaces.Disciplines;

namespace web.Models
{
	public class Sword : AbstractHandler, IDiscipline, IFencing
	{
		private string _name = "Sword";
		public string Name {get => _name; set => _name = value;}

		public Sword() {}

		public override object Handle(object request) {
			return Calculate(request);
		}

		public double Calculate(object request) {
			return 2;
		}
	}
}
