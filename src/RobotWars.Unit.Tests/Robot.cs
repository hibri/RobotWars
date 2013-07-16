using System;

namespace RobotWars.Unit.Tests
{
	internal class Robot
	{
		public void ParseCommands(string[] command) {
			string[] positionCommandParts = command[0].Split(' ');
			X = Int32.Parse(positionCommandParts[0]);
			Y = Int32.Parse(positionCommandParts[1]);
			Heading = positionCommandParts[2];
		}

		public int X { get; set; }
		public int Y { get; set; }
		public string Heading { get; set; }

		public string GetCurrentPosition() {
			return string.Format("{0} {1} {2}", X, Y , Heading);
		}
	}
}