using NUnit.Framework;

namespace RobotWars.Unit.Tests
{
	[TestFixture]
	public class RobotHeadingChangeHandlerTests
	{
		private RobotHeadingChangeHandler _robotHeadingChangeHandler;

		[SetUp]
		public void SetUp() {
			_robotHeadingChangeHandler = new RobotHeadingChangeHandler();
		}

		[Test]
		public void Should_change_heading_when_turning_right() {
			Assert.That(_robotHeadingChangeHandler.ChangeHeading('R', 'N'), Is.EqualTo('E'));
			Assert.That(_robotHeadingChangeHandler.ChangeHeading('R', 'E'), Is.EqualTo('S'));
		}

		[Test]
		public void Should_change_heading_when_turning_left() {
			Assert.That(_robotHeadingChangeHandler.ChangeHeading('L', 'N'), Is.EqualTo('W'));
			Assert.That(_robotHeadingChangeHandler.ChangeHeading('L', 'E'), Is.EqualTo('N'));
		}
	}
}