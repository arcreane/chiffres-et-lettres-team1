using System;
using System.Collections.Generic;

namespace chiffres_et_lettres_team1.Controllers
{
    public class Player
    {
        public int PlayerID { get; set; }

        public string Name { get; set; }

        //public int Password { get; set; }

        public List<Player> Levels { get; set; }
    }
}
