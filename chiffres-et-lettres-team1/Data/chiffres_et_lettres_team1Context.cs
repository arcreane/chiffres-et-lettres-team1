using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using chiffres_et_lettres_team1.Controllers;

namespace chiffres_et_lettres_team1.Data
{
    public class chiffres_et_lettres_team1Context : DbContext
    {
        public chiffres_et_lettres_team1Context (DbContextOptions<chiffres_et_lettres_team1Context> options)
            : base(options)
        {
        }

        public DbSet<chiffres_et_lettres_team1.Controllers.Letters> Letters { get; set; }

        public DbSet<chiffres_et_lettres_team1.Controllers.Numbers> Numbers { get; set; }

        public DbSet<chiffres_et_lettres_team1.Controllers.Game> Game { get; set; }

        public DbSet<chiffres_et_lettres_team1.Controllers.Player> Player { get; set; }
    }
}
