using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Carcassonne.Models
{
    public class GameModel
    {
        public List<Player> Players { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        [DisplayName("Number of Players:")]
        public int NumberOfPlayers { get; set; }

        public GameModel()
        {
            Players = new List<Player>();
        }

    }
}