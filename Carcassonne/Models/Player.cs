using System;
using System.Collections.Generic;

namespace Carcassonne.Models
{
	public class Player
	{

		public string Name { get; set;}

		public int Score { get; set; }

		public List<object> ScoreHistory { get; set; }

        public bool IsWinner { get; set; }

	}
}

