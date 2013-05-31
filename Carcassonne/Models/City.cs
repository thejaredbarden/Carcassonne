using System;
using System.Collections.Generic;

namespace Carcassonne.Models
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

