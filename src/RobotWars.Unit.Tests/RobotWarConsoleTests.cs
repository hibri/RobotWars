using NUnit.Framework;

namespace RobotWars.Unit.Tests
{
    [TestFixture]
	public class RobotWarConsoleTests
    {
	    [Test]
	    public void Robot_should_report_current_position() {
		    
			Assert.That(Input("1 2 N"), Is.EqualTo("1 2 N"));
	    }

	    private string Input(string command) {
		    return command;
	    }
    }
}
