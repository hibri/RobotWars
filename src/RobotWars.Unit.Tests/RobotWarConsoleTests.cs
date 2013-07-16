using NUnit.Framework;

namespace RobotWars.Unit.Tests
{
    [TestFixture]
	public class RobotWarConsoleTests
    {
	    [Test]
	    public void Robot_should_report_current_position() {
		    
			var robot1 = new Robot();
		    
			robot1.ParseCommands(new []{"1 2 N"});

		    Assert.That(robot1.GetCurrentPosition(), Is.EqualTo("1 2 N"));
	    }

	    [Test]
	    public void Should_parse_X_pos_from_an_initial_position_command() {
		    
			var robot = new Robot();
		    
			robot.ParseCommands(new []{"1 2 N"});

		    Assert.That(robot.X, Is.EqualTo(1));
	    }

	    [Test]
		public void Should_parse_Y_pos_from_an_initial_position_command() {
		    
			var robot = new Robot();

		    robot.ParseCommands(new[] { "1 2 N" });

		    Assert.That(robot.Y, Is.EqualTo(2));
		}

		[Test]
		public void Should_parse_current_heading_from_an_initial_position_command()
		{
			var robot = new Robot();
			
			robot.ParseCommands(new[] { "1 2 N" });

			Assert.That(robot.Heading, Is.EqualTo("N"));
		}
    }
}
