namespace LEARNING_CONCEPTS
{
	public class Employee : Person
	{
		public Employee()
		{
		}

		public int Salary { get; set; }

		public void SomeFunction2()
		{
			Age = 30;
			Salary = 1000000;
			FullName = "Sara Ahmadi";

			//this.Age = 30;
			//this.Salary = 1000000;
			//this.FullName = "Sara Ahmadi";

			// Note: somePrivateField is not accessable! But does exist!!!
			//this.somePrivateField = 200;
		}
	}
}
