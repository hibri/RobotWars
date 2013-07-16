using System;

namespace RobotWars.Unit.Tests
{
	internal class Robot
	{
		private readonly RobotHeadingChangeHandler _robotHeadingChangeHandler;

		public Robot(RobotHeadingChangeHandler robotHeadingChangeHandler) {
			_robotHeadingChangeHandler = robotHeadingChangeHandler;
		}

		public int X { get; set; }
		public int Y { get; set; }
		public char Heading { get; set; }

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
					HandleMove(Heading);
				}
				else {
					Heading = _robotHeadingChangeHandler.ChangeHeading(moves[currentMoveIndex], Heading);
				}
			}
		}

		private void HandleMove(char currentHeading) {
			switch (currentHeading) {
				case 'N':
					Y++;
					break;
				case 'E':
					X++;
					break;
			}
		}

		private void ParseInitialPosition(string initialPositionInput) {
			string[] initialPositionCommandParts = initialPositionInput.Split(' ');
			X = Int32.Parse(initialPositionCommandParts[0]);
			Y = Int32.Parse(initialPositionCommandParts[1]);
			Heading = Convert.ToChar(initialPositionCommandParts[2]);
		}

		public string GetCurrentPosition() {
			return string.Format("{0} {1} {2}", X, Y, Heading);
		}
	}
}