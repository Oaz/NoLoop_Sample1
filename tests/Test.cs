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
		
		[Test]
		public void Compute_IntegerSum_For_UnderTwelve()
		{
			var ui = new FakeUserInteraction( "integer sum", "under", "12" );
			Computer.Execute(ui);
			Assert.That (ui.DisplayedMessage, Is.EqualTo("1, 3, 6, 10"));
		}
		
		[Test]
		public void Compute_IntegerSum_For_OddUnderSeventeen()
		{
			var ui = new FakeUserInteraction( "integer sum", "odd under", "17" );
			Computer.Execute(ui);
			Assert.That (ui.DisplayedMessage, Is.EqualTo("1, 3, 15"));
		}
		
		[Test]
		public void Compute_SyracuseThirdItem_For_UnderSix()
		{
			var ui = new FakeUserInteraction( "syracuse", "3", "under", "6" );
			Computer.Execute(ui);
			Assert.That (ui.DisplayedMessage, Is.EqualTo("2, 4, 5, 1"));
		}
	}
}

