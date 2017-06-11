namespace LEARNING_CONCEPTS
{
	class Program
	{
		static void Main(string[] args)
		{
			Person oPerson = new Person();

			oPerson.Age = 20;
			oPerson.FullName = "Ali Reza Alavi";

			Employee oEmployee = new Employee();

			oEmployee.Age = 30;
			oEmployee.Salary = 100000;
			oEmployee.FullName = "Sara Ahmadi";

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
