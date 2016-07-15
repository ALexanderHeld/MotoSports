using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSports
{
    class Strecke
    {
        public Strecke(string name, string land, int tag, int monat, int jahr, int stunde, int minute)
        {
            Streckenname = name;
            Land = land;
            Datum = new DateTime(jahr, monat, tag, stunde, minute, 0);
        }

        // Generelle Infos
        public string Streckenname { get; set; }
        public string Land { get; set; }
        public DateTime Datum { get; set; }

        // private int KurvenAnzahl { get; set; }

    }
}
