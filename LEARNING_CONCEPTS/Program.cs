﻿namespace LEARNING_CONCEPTS
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();

			//person.Equals();
			//person.GetType();
			//person.ToString()
			//person.GetHashCode();

			person.Age = 20;
			person.FullName = "Ali Reza Alavi";

			Employee employee = new Employee();

			employee.Age = 30;
			employee.Salary = 100000;
			employee.FullName = "Sara Ahmadi";

			Person person1 = employee; // OK

			System.Collections.ArrayList list = new System.Collections.ArrayList();

			list.Add(person);
			list.Add(10);
			list.Add("Hello, World!");

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
