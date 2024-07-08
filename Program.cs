using System;

namespace HelloWorldApp 
{

	class App
	{
		static void Main(string[] args) 
		{
			Console.Write("Name = ");
			var name = Console.ReadLine();
			Console.WriteLine("Hello, " + name + "!");
			Console.Write("How old are you? Age = ");
			int age = int.Parse(Console.ReadLine());
			Console.WriteLine("You are " + age);

			NewClass.Goodbye();
		}
	}
}