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
            PunkteTuple = new List<Tuple<int, Fahrer>>();
        }

        public List<Tuple<int, Fahrer>> PunkteTuple { get; set; }

        public void PunkteVergeben(Rennen rennen)
        {
            int[] Platzwerte = { 25, 20, 16, 13, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            Console.WriteLine("------------------");
            foreach (Fahrer f in rennen.RanglisteNachBeendigung)
            {
                f.SaisonPunkte += Platzwerte[rennen.RanglisteNachBeendigung.IndexOf(f)];
                Console.WriteLine($"{(rennen.RanglisteNachBeendigung.IndexOf(f) + 1).ToString("D2")} | {f.Vorname}:\t{Platzwerte[rennen.RanglisteNachBeendigung.IndexOf(f)].ToString("D2")}");
            }
            Console.WriteLine("------------------");
        }

        public void ZeigePunkteTabelleAn(List<Fahrer> input)
        {
            Console.Clear();
            //List<Fahrer> temp = input.OrderBy(item => item.SaisonPunkte).ToList();
            //temp.Reverse();
            bubbleSortierenToo(ref input);
            foreach(Fahrer f in input)
            {
                Console.WriteLine($"{(input.IndexOf(f)+1).ToString("D2")}| {f.Vorname} {f.Nachname}   \t|\t{f.SaisonPunkte}");
            }
        }

        private void bubbleSortierenToo(ref List<Fahrer> input)
        {
            int TempJ;
            int TempJPlus1;
            // Vorsicht durch doppelte Vernestung der For-Schleife ergibt sich O = n*n
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count - 1; j++)
                {
                    if (input[j].SaisonPunkte < input[j + 1].SaisonPunkte) // > Aufsteigend | < Absteigend
                    {
                        TempJ = input[j].SaisonPunkte;
                        TempJPlus1 = input[j + 1].SaisonPunkte;

                        // Tauschen

                        input[j].SaisonPunkte = TempJPlus1;
                        input[j + 1].SaisonPunkte = TempJ;
                    }
                }
            }
        }
    }
}