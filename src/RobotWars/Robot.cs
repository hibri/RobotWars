using System;

namespace RobotWars
{
	public class Robot
	{
		private readonly RobotMover _robotMover;
		private readonly RobotRotator _robotRotator;
		private char _heading;
		private RobotPosition _robotPosition;

		public Robot(RobotRotator robotRotator, RobotMover robotMover) {
			_robotRotator = robotRotator;
			_robotPosition = new RobotPosition();
			_robotMover = robotMover;
		}

		public void ParseMove(string moves) {
			for (int currentMoveIndex = 0; currentMoveIndex < moves.Length; currentMoveIndex++) {
				char currentMove = moves[currentMoveIndex];
				if (currentMove == 'M') {
					_robotMover.Move(_heading, _robotPosition);
				}
				else {
					_heading = _robotRotator.ChangeHeading(currentMove, _heading);
				}
			}
		}

		public void ParsePosition(string initialPositionInput) {
			string[] initialPositionCommandParts = initialPositionInput.Split(' ');
			_robotPosition = new RobotPosition
			{
				X = Int32.Parse(initialPositionCommandParts[0]),
				Y = Int32.Parse(initialPositionCommandParts[1])
			};
			_heading = Convert.ToChar(initialPositionCommandParts[2]);
		}

		public string GetCurrentPosition() {
			return string.Format("{0} {1} {2}", _robotPosition.X, _robotPosition.Y, _heading);
		}
	}
}