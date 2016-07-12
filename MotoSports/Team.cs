using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSports
{
    class Team
    {
        private string TeamName { get; set; }
        private List<Fahrer> TeamFahrer { get; set; }
        private List<Motorrad> TeamMotorraeder { get; set; }


        private Dictionary<Fahrer, Motorrad> FahrerMotorradZugehoerigkeit { get; set; }
    }
}
