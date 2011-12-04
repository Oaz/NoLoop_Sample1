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
			var results = new List<int>();
			if( filter == "under" )
			{
				var maxValue = int.Parse(ui.Ask("max value"));
				for(var i=1; i*i <= maxValue; i++)
					results.Add(i*i);
			}
			else
			{
				var numberOfItems = int.Parse(ui.Ask("number of items"));
				for(var i=1; i <= numberOfItems; i++)
					results.Add(i*i);
			}
			ui.Display(string.Join(", ", results));
		}
	}
}

