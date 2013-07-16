using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RobotWars.Unit.Tests
{
	public class RobotWarConsole
	{
		private readonly List<Robot> _robots = new List<Robot>();
		private static readonly Regex InitialPositionRegex = new Regex(@"^[\d]+ [\d]+ [NESW]$");
		private static readonly Regex MoveRegex = new Regex(@"^[MLR]+$");

		public void ParseInput(string line) {
			if(InitialPositionRegex.IsMatch(line)) {
				var robot = new Robot(new RobotRotator(), new RobotMover());
				robot.ParsePosition(line);
				_robots.Add(robot);
			}
			else if (MoveRegex.IsMatch(line)) {
				_robots.Last().ParseMove(line);
			}
		}

		public Robot[] GetRobots() {
			return _robots.ToArray();
		}
	}
}