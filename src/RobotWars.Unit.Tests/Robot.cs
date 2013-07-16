using System;

namespace RobotWars.Unit.Tests
{
	internal class Robot
	{
		private readonly RobotDirectionChangeHandler _robotDirectionChangeHandler;

		public Robot(RobotDirectionChangeHandler robotDirectionChangeHandler) {
			_robotDirectionChangeHandler = robotDirectionChangeHandler;
		}

		public int X { get; set; }
		public int Y { get; set; }
		public string Heading { get; set; }

		public void ParseCommands(string[] commands) {
			ParseInitialPosition(commands[0]);
			if (commands.Length == 2) {
				ParseMoveInput(commands[1]);
			}
		}

		private void ParseMoveInput(string moves) {
			if (moves == "M") {
				HandleMove(Heading);
			}
			else {
				Heading = _robotDirectionChangeHandler.HandleDirectionChange(moves, Heading);

			}
		}

		private void HandleMove(string currentHeading) {
			switch (currentHeading) {
				case "N":
					Y++;
					break;
				case "E":
					X++;
					break;
			}
		}

		private void ParseInitialPosition(string initialPositionInput) {
			string[] initialPositionCommandParts = initialPositionInput.Split(' ');
			X = Int32.Parse(initialPositionCommandParts[0]);
			Y = Int32.Parse(initialPositionCommandParts[1]);
			Heading = initialPositionCommandParts[2];
		}

		public string GetCurrentPosition() {
			return string.Format("{0} {1} {2}", X, Y, Heading);
		}
	}
}