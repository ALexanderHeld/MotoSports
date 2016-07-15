using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSports
{
    class Team
    {
        public Team(string name)
        {
            TeamName = name;
            SaisonPunkte = 0;
            TeamFahrer = new List<Fahrer>();
        }

        private string TeamName { get; set; }
        private int SaisonPunkte { get; set; }

        public List<Fahrer> TeamFahrer { get; set; }

        public void FahrerHinzufuegen(string fahrerVorname, string fahrerNachname, string mopedHersteller)
        {
            Motorrad MTemp = new Motorrad(mopedHersteller);
            Fahrer FTemp = new Fahrer(fahrerVorname, fahrerNachname, MTemp);
            TeamFahrer.Add(FTemp);
        }
    }
}
