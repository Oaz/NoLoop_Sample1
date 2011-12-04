using System;
using System.Linq;
using System.Collections.Generic;

namespace src
{
	public class Computer
	{
		public static void Execute(ITalkToUser ui)
		{
			var operation = ChooseOperation(ui);
			var results = Integers().Select(operation);
			var filteredResults = ChooseFilter(ui)(results);
			ui.Display(string.Join(", ", filteredResults));
		}
		
		static IEnumerable<int> Integers()
		{
			int n = 1;
			while(true)
			{
				yield return n;
				n++;
			}
		}
		
		static Func<int,int> ChooseOperation(ITalkToUser ui)
		{
			var operation = ui.Ask("choose operation");
			if( operation == "syracuse" )
			{
				var rank = int.Parse(ui.Ask("rank"));
				return i => SyracuseSequence(i).ElementAt(rank-1);
			}
			else if( operation == "integer sum" )
			{
				return i => i*(i+1)/2;
			}
			else
			{
				return i => i*i;
			}
		}
		
		static IEnumerable<int> SyracuseSequence(int seed)
		{
			var n = seed;
			while(true)
			{
				yield return n;
				if(n%2==0)
					n = n/2;
				else
					n = 3*n+1;
			}
		}
		
		static Func<IEnumerable<int>,IEnumerable<int>> ChooseFilter(ITalkToUser ui)
		{
			var filter = ui.Ask("choose filter");
			if( filter == "odd under" )
			{
				var maxValue = int.Parse(ui.Ask("max value"));
				return e => e.TakeWhile( n => n <= maxValue ).Where( n => n%2==1 );
			}
			else if( filter == "under" )
			{
				var maxValue = int.Parse(ui.Ask("max value"));
				return e => e.TakeWhile( n => n <= maxValue );
			}
			else
			{
				var numberOfItems = int.Parse(ui.Ask("number of items"));
				return e => e.Take(numberOfItems);
			}
		}
	}
}

