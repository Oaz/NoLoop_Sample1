using System;

namespace src
{
	public interface ITalkToUser
	{
		string Ask(string message);
		void Display(string message);
	}
}

