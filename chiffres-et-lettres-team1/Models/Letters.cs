using System;
using System.Collections.Generic;

namespace chiffres_et_lettres_team1.Controllers
{
    public class Letters
    {
        public int LettersID { get; set; }

        public string Name { get; set; }

        public List<Letters> Words { get; set; }

    }
}
