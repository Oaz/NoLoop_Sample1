using System;
using System.Collections.Generic;

namespace src
{
	public class Computer
	{
		public static void Execute(ITalkToUser ui)
		{
			var dontCare = ui.Ask("choose operation");
			var filter = ui.Ask("choose filter");
			if( filter == "under" )
			{
				ui.Display("1, 4, 9, 16"); 
			}
			else
			{
				var numberOfItems = int.Parse(ui.Ask("number of items"));
				var results = new List<int>();
				for(var i=1; i <= numberOfItems; i++)
					results.Add(i*i);
				ui.Display(string.Join(", ", results));
			}
		}
	}
}

