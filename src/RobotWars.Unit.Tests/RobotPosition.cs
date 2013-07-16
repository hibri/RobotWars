using System;

namespace RobotWars.Unit.Tests
{
	public class RobotPosition
	{
		public int X;
		public int Y;

		public bool Equals(RobotPosition other) {
			return X == other.X && Y == other.Y;
		}

		public override int GetHashCode() {
			unchecked {
				return (X*397) ^ Y;
			}
		}

		public override string ToString() {
			return String.Format("{0} {1}", X, Y);
		}

		public override bool Equals(object obj) {
			if (ReferenceEquals(null, obj)) return false;
			return obj is RobotPosition && Equals((RobotPosition) obj);
		}

		public void Down() {
			Y--;
		}

		public void Left() {
			X--;
		}

		public void Right() {
			X++;
		}

		public void Up() {
			Y++;
		}
	}
}