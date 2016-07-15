using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSports
{
    // Liga = Moto3 oder Moto2 oder MotoGP
    class Liga
    {
        public Liga()
        {
            ZugelasseneStrecken = new List<Strecke>();
            TeilnehmendeTeams = new List<Team>();
        }
        public enum League { MotoGP, Moto2, Moto3}
        public League LigaTyp { get; set; }

        public List<Strecke> ZugelasseneStrecken { get; set; }
        public List<Team> TeilnehmendeTeams { get; set; }

        public void StreckeHinzufuegen(string name, string land, int tag, int monat, int jahr, int stunde, int minute)
        {
            Strecke STemp = new Strecke(name, land, tag, monat, jahr, stunde, minute);
            Console.WriteLine($"*  {name} added!");
            ZugelasseneStrecken.Add(STemp);
        }
    }
}
