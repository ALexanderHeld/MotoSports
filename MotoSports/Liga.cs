using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSports
{
    // Liga = Moto3 oder Moto2 oder MotoGP
    class League
    {
        private List<Motorrad> ZugelasseneMotorraeder { get; set; }
        private List<Strecke> ZugelasseneStrecken { get; set; }
        private List<Team> TeilnehmendeTeams { get; set; }
    }
}
