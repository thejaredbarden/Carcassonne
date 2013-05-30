using System;

namespace CarcassoneScoreBoard
{
	public class City
	{
		public List<Player> MajorityOwners { get; set; }

		public int NumberOfTiles { get; set; }

		public int PointsPerTile { get; set; }

		public List<Shield> Shields {get;set;}
	
		public City ()
		{
		}
	}
}

