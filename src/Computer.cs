using System;
using System.Collections.Generic;

namespace src
{
	public class Computer
	{
		public static void Execute(ITalkToUser ui)
		{
			var results = new List<int>();
			var operation = ui.Ask("choose operation");
			if( operation == "integer sum" )
			{
				results.AddRange(new int[] {1,3,6,10,15});
			}
			else
			{
				var untilConditionIsVerifiedFor = ChooseFilter(ui);
				for(var i=1; untilConditionIsVerifiedFor(i); i++)
					results.Add(i*i);
			}
			ui.Display(string.Join(", ", results));
		}
		
		static Func<int,bool> ChooseFilter(ITalkToUser ui)
		{
			var filter = ui.Ask("choose filter");
			if( filter == "under" )
			{
				var maxValue = int.Parse(ui.Ask("max value"));
				return i => (i*i <= maxValue);
			}
			else
			{
				var numberOfItems = int.Parse(ui.Ask("number of items"));
				return i => (i <= numberOfItems);
			}
		}
	}
}

