namespace LEARNING_CONCEPTS
{
	//public class Person
	//public class Person : System.Object
	public class Person : object
	{
		public Person()
		{
		}

		//private int age;

		//public int Age
		//{
		//	get
		//	{
		//		return (age);
		//	}
		//	set
		//	{
		//		age = value;
		//	}
		//}

		public int Age { get; set; }

		public string FullName { get; set; }

		private int somePrivateField;

		public void SomeFunction1()
		{
			this.Age = 20;
			this.FullName = "Ali Reza Alavi";
			this.somePrivateField = 100;
		}
	}
}
