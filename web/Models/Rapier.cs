using web.Interfaces;

namespace web.Models
{
	public class Rapier : AbstractHandler, IDiscipline
	{
		private string _name = "Rapier";
		public string Name {get => _name; set => _name = value;}

		public Rapier(){}

		public override object Handle(object request) {
			return Calculate(request);
		}

		public double Calculate(object request) {
			MatchDataDTO data = (MatchDataDTO)request;
			return 2;
		}
	}
}
