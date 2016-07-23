using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSports
{
    class Fahrer
    {
        public Fahrer(string vorname, string nachname, Motorrad moped)
        {
            Vorname = vorname;
            Nachname = nachname;
            MotorradDesFahrers = moped;
            SaisonPunkte = 0;
        }

        // Alter, Name etc
        public string Vorname { get; set; }
        public string Nachname { get; set; }


        // Motorrad
        public Motorrad MotorradDesFahrers { get; set; }

        // Wertung
        public int SaisonPunkte { get; set; }

    }

}
