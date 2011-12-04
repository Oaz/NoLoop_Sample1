using System;

namespace src
{
	public class ConsoleUserInteraction : ITalkToUser
	{
		public string Ask(string message)
		{
			Console.WriteLine(message);
			return Console.ReadLine();
		}
		
		public void Display(string message)
		{
			Console.WriteLine(message);
		}
	}
}

