using System;
using System.Collections.Generic;

namespace chiffres_et_lettres_team1.Controllers
{
    public class Numbers
    {
        public int NumbersID { get; set; }

        public string Name { get; set; }

        public List<Numbers> Operations { get; set; }
    }
}
