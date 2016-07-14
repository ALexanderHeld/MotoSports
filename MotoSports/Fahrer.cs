using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSports
{
    class Fahrer
    {
        // Alter, Name etc
        private string Name { get; set; }
        private int Alter { get; set; }
        private float Gewicht { get; set; }
        private bool KannTeilnehmen { get; set; }

        // Wertung
        private int SaisonPunkte { get; set; }
    }
}
