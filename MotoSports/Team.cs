using System;
using System.Collections;
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
            teamName = name;
            saisonPunkte = 0;
            TeamFahrer = new List<Fahrer>();
        }

        private string teamName { get; set; } // Fehler
        private int saisonPunkte { get; set; } // Fehler

        public List<Fahrer> TeamFahrer { get; set; }

        public void FahrerHinzufuegen(string fahrerVorname, string fahrerNachname, string mopedHersteller)
        {
            Motorrad MTemp = new Motorrad(mopedHersteller);
            Fahrer FTemp = new Fahrer(fahrerVorname, fahrerNachname, MTemp);
            TeamFahrer.Add(FTemp);
        }
    }
}
