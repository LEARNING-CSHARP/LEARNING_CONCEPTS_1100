namespace LEARNING_CONCEPTS
{
	//public class Person
	//public class Person : System.Object
	public class Person : object
	{
		public Person()
		{
		}

		public int Age { get; set; }

		public string FullName { get; set; }

		private int somePrivateField;

		public void SomeFunction1()
		{
			Age = 20;
			FullName = "Ali Reza Alavi";

			somePrivateField = 100;

			//this.Age = 20;
			//this.FullName = "Ali Reza Alavi";

			//this.somePrivateField = 100;
		}
	}
}
