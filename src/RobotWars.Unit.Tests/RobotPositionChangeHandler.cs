namespace RobotWars.Unit.Tests
{
	internal class RobotPositionChangeHandler
	{
		public void Move(char currentHeading, RobotPosition currentRobotPosition) {
			switch (currentHeading) {
				case 'N':
					currentRobotPosition.Up();
					break;
				case 'E':
					currentRobotPosition.Right();
					break;
				case 'W':
					currentRobotPosition.Left();
					break;
				case 'S':
					currentRobotPosition.Down();
					break;
			}
		}
	}
}