using System;
using System.Collections.Generic;

namespace src
{
	public class Computer
	{
		public static void Execute(ITalkToUser ui)
		{
			var results = new List<int>();
			var operation = ChooseOperation(ui);
			var untilConditionIsVerifiedFor = ChooseFilter(ui,operation);
			for(var i=1; untilConditionIsVerifiedFor(i); i++)
				results.Add(operation(i));
			ui.Display(string.Join(", ", results));
		}
		
		static Func<int,int> ChooseOperation(ITalkToUser ui)
		{
			var operation = ui.Ask("choose operation");
			if( operation == "integer sum" )
			{
				return i => i*(i+1)/2;
			}
			else
			{
				return i => i*i;
			}
		}
		
		static Func<int,bool> ChooseFilter(ITalkToUser ui, Func<int,int> operation)
		{
			var filter = ui.Ask("choose filter");
			if( filter == "under" )
			{
				var maxValue = int.Parse(ui.Ask("max value"));
				return i => (operation(i) <= maxValue);
			}
			else
			{
				var numberOfItems = int.Parse(ui.Ask("number of items"));
				return i => (i <= numberOfItems);
			}
		}
	}
}

