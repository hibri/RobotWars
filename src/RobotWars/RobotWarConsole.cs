using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RobotWars
{
	public class RobotWarConsole
	{
		private static readonly Regex InitialPositionRegex = new Regex(@"^[\d]+ [\d]+ [NESW]$");
		private static readonly Regex MoveRegex = new Regex(@"^[MLR]+$");
		private readonly List<Robot> _robots = new List<Robot>();
		private Robot _robot;

		public void ParseInput(string line) {
			if (InitialPositionRegex.IsMatch(line)) {
				Robot robot = CreateRobot();
				robot.ParsePosition(line);
				_robots.Add(robot);
			}
			else if (MoveRegex.IsMatch(line)) {
				_robot = _robots.Last();
				_robot.ParseMove(line);
				Console.WriteLine(_robot.GetCurrentPosition());

			}
		}

		private static Robot CreateRobot() {

			return new Robot(new RobotRotator(), new RobotMover());
		}

		public Robot[] GetRobots() {
			return _robots.ToArray();
		}
	}
}