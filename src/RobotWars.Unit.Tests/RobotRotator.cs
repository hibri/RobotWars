using System;
using System.Collections.Generic;

namespace RobotWars.Unit.Tests
{
	internal class RobotRotator
	{
		private readonly Dictionary<char, Dictionary<char, char>> _directionChangeRules;

		private readonly Dictionary<char, char> _headingChangesToTheLeft = new Dictionary<char, char>
		{
			{'N', 'W'},
			{'W', 'S'},
			{'S', 'E'},
			{'E', 'N'}
		};

		private readonly Dictionary<char, char> _headingChangesToTheRight = new Dictionary<char, char>
		{
			{'N', 'E'},
			{'E', 'S'},
			{'S', 'W'},
			{'W', 'N'}
		};

		public RobotRotator() {
			_directionChangeRules = new Dictionary<char, Dictionary<char, char>>
			{
				{'R', _headingChangesToTheRight},
				{'L', _headingChangesToTheLeft}
			};
		}

		public char ChangeHeading(char turnDirection, char currentHeading) {
			return _directionChangeRules[turnDirection][currentHeading];
		}
	}
}