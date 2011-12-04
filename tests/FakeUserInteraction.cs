using System.Collections.Generic;
using src;

namespace tests
{
	public class FakeUserInteraction : ITalkToUser
	{
		public FakeUserInteraction (params string[] answers)
		{
			answers_ = new Queue<string>(answers);
		}
		
		Queue<string> answers_;
		
		public string Ask(string message)
		{
			return answers_.Dequeue();
		}
		
		public void Display(string message)
		{
			DisplayedMessage = message;
		}
		
		public string DisplayedMessage { get; private set; }
	}
}

