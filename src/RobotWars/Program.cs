using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars
{
	class Program
	{
		static void Main(string[] args) {
			Console.WriteLine("Enter robot commands, hit enter to end");
			string line = Console.ReadLine();
			var robotWarConsole = new RobotWarConsole();
			do {
				robotWarConsole.ParseInput(line);
				line = Console.ReadLine();

			} while (!string.IsNullOrEmpty(line));
		}
	}
}
