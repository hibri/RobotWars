using NUnit.Framework;

namespace RobotWars.Unit.Tests
{
	[TestFixture]
	public class RobotTests
	{
		private Robot _robot;

		[SetUp]
		public void SetUp() {
			SetUpRobot();
		}

		[Test]
		public void Robot_should_report_current_position() {
			SendCommandsToRobot(new[]
			{
				"1 2 N"
			});

			Assert.That(GetCurrentPosition(), Is.EqualTo("1 2 N"));
		}

		[Test]
		public void Should_do_two_turns() {

			SendCommandsToRobot(new[]
			{
				"1 2 E",
				"RL"
			});

			Assert.That(GetCurrentPosition(), Is.EqualTo("1 2 E"));
		}

		[Test]
		public void Should_move_one_robot() {

			SendCommandsToRobot(new[]
			{
				"1 2 N",
				"LMLMLMLMM"
			});

			Assert.That(GetCurrentPosition(), Is.EqualTo("1 3 N"));
		}

		[Test]
		public void Should_move_one_step_east() {
			SendCommandsToRobot(new[]
			{
				"1 2 E",
				"M"
			});

			Assert.That(GetCurrentPosition(), Is.EqualTo("2 2 E"));
		}

		[Test]
		public void Should_move_one_step_north() {
			SendCommandsToRobot(new[]
			{
				"1 2 N",
				"M"
			});

			Assert.That(GetCurrentPosition(), Is.EqualTo("1 3 N"));
		}

		[Test]
		public void Should_move_second_robot() {
			SendCommandsToRobot(new[]
			{
				"3 3 E",
				"MMRMMRMRRM"
			});

			Assert.That(GetCurrentPosition(), Is.EqualTo("5 1 E"));
		}

		[Test]
		public void Should_parse_X_pos_from_an_initial_position_command() {
			SendCommandsToRobot(new[]
			{
				"1 2 N"
			});

			Assert.That(_robot.RobotPosition.X, Is.EqualTo(1));
		}

		[Test]
		public void Should_parse_Y_pos_from_an_initial_position_command() {
			SendCommandsToRobot(new[]
			{
				"1 2 N"
			});

			Assert.That(_robot.RobotPosition.Y, Is.EqualTo(2));
		}

		[Test]
		public void Should_parse_current_heading_from_an_initial_position_command() {

			SendCommandsToRobot(new[]
			{
				"1 2 N"
			});


			Assert.That(_robot.Heading, Is.EqualTo('N'));
		}

		[Test]
		public void Should_turn_left() {

			SendCommandsToRobot(new[]
			{
				"1 2 E",
				"L"
			});

			Assert.That(GetCurrentPosition(), Is.EqualTo("1 2 N"));
		}

		[Test]
		public void Should_turn_right() {

			SendCommandsToRobot(new[]
			{
				"1 2 E",
				"R"
			});

			

			Assert.That(GetCurrentPosition(), Is.EqualTo("1 2 S"));
		}

		private string GetCurrentPosition() {
			return _robot.GetCurrentPosition();
		}

		private void SendCommandsToRobot(string[] commands) {
			_robot.ParsePosition(commands[0]);
			if (commands.Length == 2) {
				_robot.ParseMove(commands[1]);
			}
		}

		private void SetUpRobot() {
			_robot = new Robot(new RobotRotator(), new RobotMover());
		}
	}
}