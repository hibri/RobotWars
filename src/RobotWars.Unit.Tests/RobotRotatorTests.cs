using NUnit.Framework;

namespace RobotWars.Unit.Tests
{
	[TestFixture]
	public class RobotRotatorTests
	{
		private RobotRotator _robotRotator;

		[SetUp]
		public void SetUp() {
			_robotRotator = new RobotRotator();
		}

		[Test]
		public void Should_change_heading_when_turning_right() {
			Assert.That(_robotRotator.ChangeHeading('R', 'N'), Is.EqualTo('E'));
			Assert.That(_robotRotator.ChangeHeading('R', 'E'), Is.EqualTo('S'));
		}

		[Test]
		public void Should_change_heading_when_turning_left() {
			Assert.That(_robotRotator.ChangeHeading('L', 'N'), Is.EqualTo('W'));
			Assert.That(_robotRotator.ChangeHeading('L', 'E'), Is.EqualTo('N'));
		}
	}
}