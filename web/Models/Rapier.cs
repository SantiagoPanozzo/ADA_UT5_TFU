using web.Interfaces;

namespace web.Models
{
	public class Rapier : IDiscipline
	{
		private string _name = "Rapier";
		public string Name {get => _name; set => _name = value;}

		public Rapier(){}

		public double Calculate() {
			return 2;
		}
	}
}
