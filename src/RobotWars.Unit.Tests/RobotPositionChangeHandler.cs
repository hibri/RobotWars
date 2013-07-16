namespace RobotWars.Unit.Tests
{
	internal class RobotPositionChangeHandler
	{
		public RobotPosition ChangePosition(char currentHeading, RobotPosition currentRobotPosition) {
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