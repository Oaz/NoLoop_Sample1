using System;
using System.Collections.Generic;

namespace src
{
	public class Computer
	{
		public static void Execute(ITalkToUser ui)
		{
			var dontCare = ui.Ask("choose operation");
			var dontCareAgain = ui.Ask("choose filter");
			var numberOfItems = int.Parse(ui.Ask("number of items"));
			var results = new List<int>();
			for(var i=1; i <= numberOfItems; i++)
				results.Add(i*i);
			ui.Display(string.Join(", ", results));
		}
	}
}

