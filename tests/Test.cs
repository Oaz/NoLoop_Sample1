using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;
using src;

namespace tests
{
	[TestFixture]
	public class Test
	{
		[Test]
		public void Compute_Square_For_FourFirstItems()
		{
			var ui = new FakeUserInteraction( "square", "first items", "4" );
			Computer.Execute(ui);
			Assert.That (ui.DisplayedMessage, Is.EqualTo("1, 4, 9, 16"));
		}
		
		[Test]
		public void Compute_Square_For_FiveFirstItems()
		{
			var ui = new FakeUserInteraction( "square", "first items", "5" );
			Computer.Execute(ui);
			Assert.That (ui.DisplayedMessage, Is.EqualTo("1, 4, 9, 16, 25"));
		}
		
		[Test]
		public void Compute_Square_For_UnderTwenty()
		{
			var ui = new FakeUserInteraction( "square", "under", "20" );
			Computer.Execute(ui);
			Assert.That (ui.DisplayedMessage, Is.EqualTo("1, 4, 9, 16"));
		}
		
		[Test]
		public void Compute_IntegerSum_For_FiveFirstItems()
		{
			var ui = new FakeUserInteraction( "integer sum", "first items", "5" );
			Computer.Execute(ui);
			Assert.That (ui.DisplayedMessage, Is.EqualTo("1, 3, 6, 10, 15"));
		}
	}
}

