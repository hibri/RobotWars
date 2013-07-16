using System;

namespace RobotWars.Unit.Tests
{
	internal class Robot
	{
		private readonly RobotRotator _robotRotator;
		private RobotPosition _robotPosition;
		private readonly RobotMover _robotMover;

		public Robot(RobotRotator robotRotator, RobotMover robotMover) {
			_robotRotator = robotRotator;
			_robotPosition = new RobotPosition();
			_robotMover = robotMover;
		}

		public char Heading { get; set; }

		public RobotPosition RobotPosition {
			get { return _robotPosition; }
		}

		public void ParseCommands(string[] commands) {
			ParseInitialPosition(commands[0]);
			if (commands.Length == 2) {
				Move(commands[1]);
			}
		}

		private void Move(string moves) {
			for (int currentMoveIndex = 0; currentMoveIndex < moves.Length; currentMoveIndex++) {
				;
				if (moves[currentMoveIndex] == 'M') {
					_robotMover.Move(Heading, _robotPosition);
				}
				else {
					Heading = _robotRotator.ChangeHeading(moves[currentMoveIndex], Heading);
				}
			}
		}

		private void ParseInitialPosition(string initialPositionInput) {
			string[] initialPositionCommandParts = initialPositionInput.Split(' ');
			_robotPosition = new RobotPosition
			{
				X = Int32.Parse(initialPositionCommandParts[0]),
				Y = Int32.Parse(initialPositionCommandParts[1])
			};
			Heading = Convert.ToChar(initialPositionCommandParts[2]);
		}

		public string GetCurrentPosition() {
			return string.Format("{0} {1} {2}", _robotPosition.X, _robotPosition.Y, Heading);
		}
	}
}