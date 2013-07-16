using System;

namespace RobotWars.Unit.Tests
{
	internal class RobotDirectionChangeHandler
	{
		public string HandleDirectionChange(string moves, string currentHeading) {
			if (moves == "L") {
				switch (currentHeading) {
					case "E":
						return "N";
				}
			}
			else if(moves == "R") {
				switch (currentHeading)
				{
					case "E":
						return "S";
						

				}
			}
			return String.Empty;
		}
	}
}