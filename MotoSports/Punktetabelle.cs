using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSports
{
    class Punktetabelle
    {
        public Punktetabelle()
        {
            // Reihenfolge = new List<KvpCollection>();
            // LookupByPoints = Reihenfolge.ToLookup<int, Fahrer>(n => n);
            PunkteTuple = new List<Tuple<int, Fahrer>>();
        }

        // private List<KvpCollection> Reihenfolge { get; set; }
        // public Lookup<int, Fahrer> LookupByPoints { get; set; }
        public List<Tuple<int, Fahrer>> PunkteTuple { get; set; }

        public void PunkteVergeben(Rennen rennen)
        {
            int[] Platzwerte = { 25, 20, 16, 13, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            
            foreach (Fahrer f in rennen.RanglisteNachBeendigung)
            {
                f.SaisonPunkte += Platzwerte[rennen.RanglisteNachBeendigung.IndexOf(f)];
                Console.WriteLine($"{f.Vorname} hat {Platzwerte[rennen.RanglisteNachBeendigung.IndexOf(f)]} Punkte gutgeschreiben bekommen!");
            }


        }

        public void ZeigePunkteTabelleAn(List<Fahrer> input)
        {
            Console.Clear();
            List<Fahrer> temp = input.OrderBy(item => item.SaisonPunkte).ToList();
            temp.Reverse();
            foreach(Fahrer f in temp)
            {
                Console.WriteLine($"{f.Vorname} {f.Nachname} hat diese Saison {f.SaisonPunkte} verdient.");
            }
        }

        // Collection Class
        /*private class KvpCollection
        {
            public KvpCollection(int keyInput, Fahrer valueInput)
            {
                key = keyInput;
                value = valueInput;
            }

            public int key { get; set; }
            public Fahrer value { get; set; }
        }*/
    }
}
