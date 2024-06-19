using web.Interfaces;

namespace web.Models
{
	public class Saber : IDiscipline
	{
		private string _name = "Saber";
		public string Name {get => _name; set => _name = value;}

		public Saber() {}

		public double Calculate() {
			return 2;
		}
	}
}
