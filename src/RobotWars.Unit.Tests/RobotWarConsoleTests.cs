using NUnit.Framework;

namespace RobotWars.Unit.Tests
{
	[TestFixture]
	public class RobotWarConsoleTests
	{
		private RobotWarConsole _console;

		[SetUp]
		public void SetUp() {
			_console = new RobotWarConsole();
		}

		[Test]
		public void Should_create_a_robot() {
			string[] inputs =
			{
				"5 5",
				"1 2 N",
				"LMLMLMLMM"
			};

			SendInputs(inputs);

			Assert.That(_console.GetRobots()[0], Is.Not.Null);

		}

		[Test]
		public void Should_create_two_robots()
		{
			string[] inputs =
			{
				"5 5",
				"1 2 N",
				"LMLMLMLMM",
				"3 3 E",
				"MMRMMRMRRM"
			};

			SendInputs(inputs);

			Assert.That(_console.GetRobots()[0], Is.Not.Null);
			Assert.That(_console.GetRobots()[1], Is.Not.Null);
		}

		[Test]
		public void Should_move_a_robot() {
			string[] inputs =
			{
				"5 5",
				"1 2 N",
				"LMLMLMLMM"
			};

			SendInputs(inputs);

			Assert.That(_console.GetRobots()[0].GetCurrentPosition(), Is.EqualTo("1 3 N"));
		}

		[Test]
		public void Should_move_two_robots()
		{
			string[] inputs =
			{
				"5 5",
				"1 2 N",
				"LMLMLMLMM",
				"3 3 E",
				"MMRMMRMRRM"
			};

			SendInputs(inputs);

			Assert.That(_console.GetRobots()[0].GetCurrentPosition(), Is.EqualTo("1 3 N"));
			Assert.That(_console.GetRobots()[1].GetCurrentPosition(), Is.EqualTo("5 1 E"));
		}

		private void SendInputs(string[] inputs) {

			foreach (string line in inputs) {
				_console.ParseInput(line);
			}
		}
	}
}