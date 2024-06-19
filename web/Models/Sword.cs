using web.Interfaces;

namespace web.Models
{
	public class Sword : IDiscipline
	{
		private string _name = "Sword";
		public string Name {get => _name; set => _name = value;}

		public Sword() {}

		public double Calculate() {
			return 2;
		}
	}
}
