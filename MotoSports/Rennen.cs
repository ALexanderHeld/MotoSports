using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSports
{
    class Rennen
    {
        // Enum
        // private enum Renntyp { Qualifying, Rennen}

        // Properties
        // private Renntyp ArtDesRennens { get; set; }
        private Strecke AustragungsOrt { get; set; }

        // Reihenfolge der Fahrer im Rennen
        private SortedDictionary<int, Fahrer> Platzierung { get; set; }

        // Rennen
        public void StarteRennen()
        {
            
        }
    }
}
