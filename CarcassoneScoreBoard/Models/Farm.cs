using System;

namespace CarcassoneScoreBoard
{
	public class Farm
	{
		public List<Player> MajorityOwners { get; set; }

		public int PointsPerClosedCity { get; set; }

		public bool HasPig { get; set; }

		public int PigPointModifier { get; set; }

		public Farm ()
		{
		}
	}
}

