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
	}
}

