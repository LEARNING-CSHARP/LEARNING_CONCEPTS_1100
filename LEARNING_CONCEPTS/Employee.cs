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
			this.Age = 30;
			this.FullName = "Sara Ahmadi";
			this.Salary = 1000000;

			//this.somePrivateField = 200;
		}
	}
}
