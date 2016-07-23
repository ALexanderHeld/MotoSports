using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSports
{
    class Strecke
    {
        public Strecke(string name, string land)
        {
            Streckenname = name;
            Land = land;
        }

        // Generelle Infos
        public string Streckenname { get; set; }
        public string Land { get; set; }
    }
}
