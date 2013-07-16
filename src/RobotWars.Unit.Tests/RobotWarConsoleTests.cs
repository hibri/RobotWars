﻿using NUnit.Framework;

namespace RobotWars.Unit.Tests
{
	[TestFixture]
	public class RobotWarConsoleTests
	{
		private Robot _robot;

		[SetUp]
		public void SetUp() {
			_robot = new Robot(new RobotHeadingChangeHandler());
		}

		[Test]
		public void Robot_should_report_current_position() {

			_robot.ParseCommands(new[] {"1 2 N"});

			Assert.That(_robot.GetCurrentPosition(), Is.EqualTo("1 2 N"));
		}

		[Test]
		public void Should_move_one_step_east() {

			_robot.ParseCommands(new[] {"1 2 E", "M"});

			Assert.That(_robot.GetCurrentPosition(), Is.EqualTo("2 2 E"));
		}

		[Test]
		public void Should_move_one_step_north() {

			_robot.ParseCommands(new[] {"1 2 N", "M"});

			Assert.That(_robot.GetCurrentPosition(), Is.EqualTo("1 3 N"));
		}

		[Test]
		public void Should_parse_X_pos_from_an_initial_position_command() {
			
			_robot.ParseCommands(new[] {"1 2 N"});

			Assert.That(_robot.X, Is.EqualTo(1));
		}

		[Test]
		public void Should_parse_Y_pos_from_an_initial_position_command() {
			
			_robot.ParseCommands(new[] {"1 2 N"});

			Assert.That(_robot.Y, Is.EqualTo(2));
		}

		[Test]
		public void Should_parse_current_heading_from_an_initial_position_command() {
			var robot = new Robot(new RobotHeadingChangeHandler());

			robot.ParseCommands(new[] {"1 2 N"});

			Assert.That(robot.Heading, Is.EqualTo('N'));
		}

		[Test]
		public void Should_turn_left() {
			_robot.ParseCommands(new[] {"1 2 E", "L"});

			Assert.That(_robot.GetCurrentPosition(), Is.EqualTo("1 2 N"));
		}

		[Test]
		public void Should_turn_right() {
			
			_robot.ParseCommands(new[] {"1 2 E", "R"});

			Assert.That(_robot.GetCurrentPosition(), Is.EqualTo("1 2 S"));
		}

		[Test]
		public void Should_do_two_turns()
		{

			_robot.ParseCommands(new[] { "1 2 E", "RL" });

			Assert.That(_robot.GetCurrentPosition(), Is.EqualTo("1 2 E"));
		}


	}
}