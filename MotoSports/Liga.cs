using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSports
{
    class Liga
    {
        public Liga()
        {
            ZugelasseneStrecken = new List<Strecke>();
            AnstehendeRennen = new List<Rennen>();
            TeilnehmendeTeams = new List<Team>();
            TeilnehmendeFahrer = new List<Fahrer>();
        }

        public int Renntag = -1; // Chris ansprechen wie schöner lösen
        public enum League { MotoGP, Moto2, Moto3}
        public League LigaTyp { get; set; }
        
        public List<Strecke> ZugelasseneStrecken { get; set; }
        public List<Rennen> AnstehendeRennen { get; set; }
        public List<Team> TeilnehmendeTeams { get; set; }
        public List<Fahrer> TeilnehmendeFahrer { get; set; }

        public void RennenHinzufuegen(List<Tuple<Tuple<string, string>, Tuple<int, int, int, int>>> input)
        {
            // Strecken
            Console.WriteLine("  ##### STRECKEN #####");
            foreach (Tuple<Tuple<string, string>, Tuple<int, int, int, int>> t in input)
            {
                Strecke STemp = new Strecke(t.Item1.Item1, t.Item1.Item1);
                Console.WriteLine($"* Strecke \"{t.Item1}\"added!");
            }
            Console.WriteLine("\n");

            // Renntermine
            Console.WriteLine("  ##### RENNEN #####");
            foreach (Tuple<Tuple<string, string>, Tuple<int, int, int, int>> t in input)
            {
                Rennen RTemp = new Rennen(new Strecke(t.Item1.Item1,t.Item1.Item2), t.Item2.Item1, t.Item2.Item2, t.Item2.Item3, t.Item2.Item4);
                Console.WriteLine($"* Rennen \"{RTemp.AustragungsOrt.Streckenname}\"added!");
                AnstehendeRennen.Add(RTemp);
            }
            Console.WriteLine("\n");
        }

        public void FahrerHinzufuegen()
        {
            Console.WriteLine("  ##### FAHRER #####");
            foreach (Team t in TeilnehmendeTeams)
            {
                foreach(Fahrer f in t.TeamFahrer)
                {
                    TeilnehmendeFahrer.Add(f);
                    Console.WriteLine($"* Fahrer \"{f.Vorname} {f.Nachname}\"added!");
                }
            }
            Console.WriteLine("\n");
        }

        public void StarteNaechstesRennen()
        {
            Renntag += 1;
            if (Renntag >= AnstehendeRennen.Count)
            {
                Console.Clear();
                Console.WriteLine("Alle Rennen sind abgeschlossen! Gib \"show\" ein um die Endauswertung zu sehen.");
                Renntag -= 1;
                
            }

            else
            {

                AnstehendeRennen[Renntag].GeneriereRennergebnis(TeilnehmendeFahrer);
            }

            
        }
    }
}