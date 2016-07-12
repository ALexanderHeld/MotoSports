using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSports
{
    class Strecke
    {
        // Generelle Infos
        private string Stadt { get; set; }
        private string Streckenname { get; set; }
        private int Kilometer { get; set; }
        private int KurvenAnzahl { get; set; }

        // Runden/-Zeiten
        private float Bestzeit { get; set; }
        private int Rundenanzahl { get; set; }
    }
}
