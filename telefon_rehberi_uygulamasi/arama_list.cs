namespace telefon_rehber
{
public class Kisi
	{ //encapsulation
		private string name, surName, phoneNumber;
		
		//Constructor
		public Kisi(string name, string surName, string phoneNumber)
		{
			this.Name = name;
			this.Surname = surName;
			this.Phone_Number = phoneNumber;
		}
		//props
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Phone_Number { get; set; }
	}
}