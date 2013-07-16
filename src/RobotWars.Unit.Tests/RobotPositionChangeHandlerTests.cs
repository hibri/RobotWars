using NUnit.Framework;

namespace RobotWars.Unit.Tests
{
	[TestFixture]
	public class RobotPositionChangeHandlerTests
	{
		private RobotPosition _currentRobotPosition;
		private RobotPositionChangeHandler _robotPositionChangeHandler;

		[SetUp]
		public void SetUp() {
			_robotPositionChangeHandler = new RobotPositionChangeHandler();
			_currentRobotPosition = new RobotPosition {X = 0, Y = 0};
		}

		[Test]
		public void Should_move_down_when_facing_south() {
			var expected = new RobotPosition {X = 0, Y = -1};

			_robotPositionChangeHandler.Move('S', _currentRobotPosition);

			Assert.That(_currentRobotPosition, Is.EqualTo(expected));
		}

		[Test]
		public void Should_move_left_when_facing_east() {
			var expected = new RobotPosition {X = 1, Y = 0};

			_robotPositionChangeHandler.Move('E', _currentRobotPosition);

			Assert.That(_currentRobotPosition, Is.EqualTo(expected));
		}


		[Test]
		public void Should_move_right_when_facing_west() {
			var expected = new RobotPosition {X = -1, Y = 0};

			_robotPositionChangeHandler.Move('W', _currentRobotPosition);

			Assert.That(_currentRobotPosition, Is.EqualTo(expected));
		}

		[Test]
		public void Should_move_up_when_facing_north() {
			var expected = new RobotPosition {X = 0, Y = 1};

			_robotPositionChangeHandler.Move('N', _currentRobotPosition);

			Assert.That(_currentRobotPosition, Is.EqualTo(expected));
		}
	}
}