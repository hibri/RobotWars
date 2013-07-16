using System;

namespace RobotWars.Unit.Tests
{
	internal class Robot
	{
		private readonly RobotHeadingChangeHandler _robotHeadingChangeHandler;
		private RobotPosition _robotPosition;
		private readonly RobotPositionChangeHandler _robotPositionChangeHandler;

		public Robot(RobotHeadingChangeHandler robotHeadingChangeHandler, RobotPositionChangeHandler robotPositionChangeHandler) {
			_robotHeadingChangeHandler = robotHeadingChangeHandler;
			_robotPosition = new RobotPosition();
			_robotPositionChangeHandler = robotPositionChangeHandler;
		}

		public char Heading { get; set; }

		public RobotPosition RobotPosition {
			get { return _robotPosition; }
		}

		public void ParseCommands(string[] commands) {
			ParseInitialPosition(commands[0]);
			if (commands.Length == 2) {
				ParseMoveInput(commands[1]);
			}
		}

		private void ParseMoveInput(string moves) {
			for (int currentMoveIndex = 0; currentMoveIndex < moves.Length; currentMoveIndex++) {
				;
				if (moves[currentMoveIndex] == 'M') {
					_robotPosition = _robotPositionChangeHandler.Move(Heading, RobotPosition);
				}
				else {
					Heading = _robotHeadingChangeHandler.ChangeHeading(moves[currentMoveIndex], Heading);
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