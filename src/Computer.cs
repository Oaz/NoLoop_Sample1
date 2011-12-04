using System;

namespace src
{
	public class Computer
	{
		public static void Execute(ITalkToUser ui)
		{
			ui.Display("1, 4, 9, 16");
		}
	}
}

