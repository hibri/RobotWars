using NUnit.Framework;

namespace RobotWars.Unit.Tests
{
	[TestFixture]
	public class RobotMoverTests
	{
		private RobotPosition _currentRobotPosition;
		private RobotMover _robotMover;

		[SetUp]
		public void SetUp() {
			_robotMover = new RobotMover();
			_currentRobotPosition = new RobotPosition {X = 0, Y = 0};
		}

		[Test]
		public void Should_move_down_when_facing_south() {
			var expected = new RobotPosition {X = 0, Y = -1};

			_robotMover.Move('S', _currentRobotPosition);

			Assert.That(_currentRobotPosition, Is.EqualTo(expected));
		}

		[Test]
		public void Should_move_left_when_facing_east() {
			var expected = new RobotPosition {X = 1, Y = 0};

			_robotMover.Move('E', _currentRobotPosition);

			Assert.That(_currentRobotPosition, Is.EqualTo(expected));
		}


		[Test]
		public void Should_move_right_when_facing_west() {
			var expected = new RobotPosition {X = -1, Y = 0};

			_robotMover.Move('W', _currentRobotPosition);

			Assert.That(_currentRobotPosition, Is.EqualTo(expected));
		}

		[Test]
		public void Should_move_up_when_facing_north() {
			var expected = new RobotPosition {X = 0, Y = 1};

			_robotMover.Move('N', _currentRobotPosition);

			Assert.That(_currentRobotPosition, Is.EqualTo(expected));
		}
	}
}