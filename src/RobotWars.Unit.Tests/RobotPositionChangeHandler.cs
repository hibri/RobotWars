namespace RobotWars.Unit.Tests
{
	internal class RobotPositionChangeHandler
	{
		public RobotPosition Move(char currentHeading, RobotPosition currentRobotPosition) {
			switch (currentHeading) {
				case 'N':
					currentRobotPosition.Y++;
					break;
				case 'E':
					currentRobotPosition.X++;
					break;
			}
			return currentRobotPosition;
		}
	}
}