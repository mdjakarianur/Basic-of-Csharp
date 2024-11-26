using System;
 
namespace UserInput
{
	class MyClass
	{
		public static void Main(string[] args)
		{
			string userInput;
			int intVal;
			double doubleVal;

			Console.Write("Enter integer value: ");
			userInput = Console.ReadLine();
		
			intVal = Convert.ToInt32(userInput);
			Console.WriteLine("You entered {0}",intVal);

			Console.Write("Enter double value: ");
			userInput = Console.ReadLine();
			
			doubleVal = Convert.ToDouble(userInput);
			Console.WriteLine("You entered {0}",doubleVal);
		}
	}
}
