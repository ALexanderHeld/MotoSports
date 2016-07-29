using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSports
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<Liga, Punktetabelle> InitParams = Init();
            Liga MotoGP = InitParams.Item1;
            Punktetabelle PunkteTab = InitParams.Item2;

            while (true)
            {
                string eingabe = Console.ReadLine();
                if (eingabe == "exit")
                    break;
                if (eingabe == "")
                {
                    MotoGP.StarteNaechstesRennen();
                    if (!(MotoGP.AnstehendeRennen.Count == MotoGP.Renntag))
                        PunkteTab.PunkteVergeben(MotoGP.AnstehendeRennen[MotoGP.Renntag]);
                    else
                        PunkteTab.ZeigePunkteTabelleAn(MotoGP.TeilnehmendeFahrer);
                }
                if (eingabe == "show")
                {
                    PunkteTab.ZeigePunkteTabelleAn(MotoGP.TeilnehmendeFahrer);
                }

            }
            Close();
        }

        static Tuple<Liga, Punktetabelle> Init()
        {
            // Instanzieren
            Liga MotoGP = new Liga();
            MotoGP.LigaTyp = Liga.League.MotoGP;
            Punktetabelle PunkteTab = new Punktetabelle();

            // Aprilia Racing Team Gresini
            Team TApriliaRacing = new Team("Aprilia Racing Team Gresini");
            TApriliaRacing.FahrerHinzufuegen("Stefan", "Bradel", "Aprilia");
            TApriliaRacing.FahrerHinzufuegen("Alvaro", "Bautista", "Aprilia");
            MotoGP.TeilnehmendeTeams.Add(TApriliaRacing);

            // Yamaha Factory Racing
            Team TYamahaFactory = new Team("Yamaha Factory Racing");
            TYamahaFactory.FahrerHinzufuegen("Valentino", "Rossi", "Yamaha");
            TYamahaFactory.FahrerHinzufuegen("Jorge", "Lorenzo", "Yamaha");
            MotoGP.TeilnehmendeTeams.Add(TYamahaFactory);

            // Ducati Team
            Team TDucati = new Team("Ducati Team");
            TDucati.FahrerHinzufuegen("Andrea", "Iannone", "Ducati");
            TDucati.FahrerHinzufuegen("Andrea", "Dovizioso", "Ducati");
            MotoGP.TeilnehmendeTeams.Add(TDucati);

            // Avintia
            Team TAvintia = new Team("Avintia");
            TAvintia.FahrerHinzufuegen("Hector", "Barbera", "Ducati");
            TAvintia.FahrerHinzufuegen("Loris", "Baz", "Ducati");
            MotoGP.TeilnehmendeTeams.Add(TAvintia);

            // Aspar
            Team TAspar = new Team("Aspar");
            TAspar.FahrerHinzufuegen("Eugene", "Laverty", "Ducati");
            TAspar.FahrerHinzufuegen("Yonny", "Hernandez", "Ducati");
            MotoGP.TeilnehmendeTeams.Add(TAspar);

            // Pramac-Ducati
            Team TPramacDucati = new Team("Pramac Ducati");
            TPramacDucati.FahrerHinzufuegen("Danilo", "Petrucci", "Ducati");
            TPramacDucati.FahrerHinzufuegen("Scott", "Redding", "Ducati");
            MotoGP.TeilnehmendeTeams.Add(TPramacDucati);

            // Monster Yamaha Tech 3
            Team TMonster = new Team("Monster Yamaha Tech 3");
            TMonster.FahrerHinzufuegen("Bradley", "Smith", "Yamaha");
            TMonster.FahrerHinzufuegen("Pol", "Espargaro", "Yamaha");
            MotoGP.TeilnehmendeTeams.Add(TMonster);

            // Repsol Honda Team
            Team TRepsol = new Team("Repsol Honda Team");
            TRepsol.FahrerHinzufuegen("Dani", "Petrosa", "Honda");
            TRepsol.FahrerHinzufuegen("Marc", "Marquez", "Honda");
            MotoGP.TeilnehmendeTeams.Add(TRepsol);

            // Team Marc VDS
            Team TEstrella = new Team("Estrella Galicia 0,0 Marc VDS");
            TEstrella.FahrerHinzufuegen("Jack", "Miller", "Honda");
            TEstrella.FahrerHinzufuegen("Tito", "Rabat", "Honda");
            MotoGP.TeilnehmendeTeams.Add(TEstrella);

            // Suzuki
            Team TSuzuki = new Team("Suzuki");
            TSuzuki.FahrerHinzufuegen("Maverick", "Vinales", "Suzuki");
            TSuzuki.FahrerHinzufuegen("Aleix", "Espargaro", "Suzuki");
            MotoGP.TeilnehmendeTeams.Add(TSuzuki);

            // LCR - Honda
            Team TLCR = new Team("LCR Honda");
            TLCR.FahrerHinzufuegen("Cal", "Crutchlow", "Suzuki");
            MotoGP.TeilnehmendeTeams.Add(TLCR);

            // Strecke  + Datum
            List<Tuple<Tuple<string, string>, Tuple<int, int, int, int>>> StreckeDatum = new List<Tuple<Tuple<string, string>, Tuple<int, int, int, int>>>();
            StreckeDatum.Add(new Tuple<Tuple<string, string>, Tuple<int, int, int, int>>(
                new Tuple<string, string>("Losail", "Katar"), 
                new Tuple<int, int, int, int>(20, 3, 2016, 19)));
            StreckeDatum.Add(new Tuple<Tuple<string, string>, Tuple<int, int, int, int>>(
                new Tuple<string, string>("Termas de Río Hondo", "Argentinien"), 
                new Tuple<int, int, int, int>(3, 4, 2016, 21)));
            StreckeDatum.Add(new Tuple<Tuple<string, string>, Tuple<int, int, int, int>>(
                new Tuple<string, string>("Austin", "Amerika"), 
                new Tuple<int, int, int, int>(10, 4, 2016, 21)));
            StreckeDatum.Add(new Tuple<Tuple<string, string>, Tuple<int, int, int, int>>(
                new Tuple<string, string>("Jerez de la Frontera", "Spanien"), 
                new Tuple<int, int, int, int>(24, 4, 2016, 14)));
            StreckeDatum.Add(new Tuple<Tuple<string, string>, Tuple<int, int, int, int>>(
                new Tuple<string, string>("Le Mans", "Frankreich"), 
                new Tuple<int, int, int, int>(8, 5, 2016, 14)));
            StreckeDatum.Add(new Tuple<Tuple<string, string>, Tuple<int, int, int, int>>(
                new Tuple<string, string>("Mugello", "Italien"), 
                new Tuple<int, int, int, int>(22, 5, 2016, 14)));
            StreckeDatum.Add(new Tuple<Tuple<string, string>, Tuple<int, int, int, int>>(
                new Tuple<string, string>("Barcelona", "Spanien"), 
                new Tuple<int, int, int, int>(5, 6, 2016, 14)));
            StreckeDatum.Add(new Tuple<Tuple<string, string>, Tuple<int, int, int, int>>(
                new Tuple<string, string>("Assen", "Niederlande"), 
                new Tuple<int, int, int, int>(26, 6, 2016, 14)));
            StreckeDatum.Add(new Tuple<Tuple<string, string>, Tuple<int, int, int, int>>(
                new Tuple<string, string>("Hohenstein-Ernstthal", "Deutschland"), 
                new Tuple<int, int, int, int>(17, 7, 2016, 14)));
            StreckeDatum.Add(new Tuple<Tuple<string, string>, Tuple<int, int, int, int>>(
                new Tuple<string, string>("Spielberg", "Österreich"), 
                new Tuple<int, int, int, int>(14, 8, 2016, 14)));
            StreckeDatum.Add(new Tuple<Tuple<string, string>, Tuple<int, int, int, int>>(
                new Tuple<string, string>("Brünn", "Tschechien"), 
                new Tuple<int, int, int, int>(21, 8, 2016, 14)));
            StreckeDatum.Add(new Tuple<Tuple<string, string>, Tuple<int, int, int, int>>(
                new Tuple<string, string>("Silverstone", "Großbritanien"), 
                new Tuple<int, int, int, int>(4, 9, 2016, 14)));
            StreckeDatum.Add(new Tuple<Tuple<string, string>, Tuple<int, int, int, int>>(
                new Tuple<string, string>("Misano Adriatico", "Italien"), 
                new Tuple<int, int, int, int>(11, 9, 2016, 14)));
            StreckeDatum.Add(new Tuple<Tuple<string, string>, Tuple<int, int, int, int>>(
                new Tuple<string, string>("Alcaniz", "Spanien"), 
                new Tuple<int, int, int, int>(25, 9, 2016, 14)));
            StreckeDatum.Add(new Tuple<Tuple<string, string>, Tuple<int, int, int, int>>(
                new Tuple<string, string>("Motegi", "Japan"), 
                new Tuple<int, int, int, int>(16, 10, 2016, 7)));
            StreckeDatum.Add(new Tuple<Tuple<string, string>, Tuple<int, int, int, int>>(
                new Tuple<string, string>("Phillip Island", "Australien"), 
                new Tuple<int, int, int, int>(23, 10, 2016, 7)));
            StreckeDatum.Add(new Tuple<Tuple<string, string>, Tuple<int, int, int, int>>(
                new Tuple<string, string>("Sepang", "Malaysia"), 
                new Tuple<int, int, int, int>(30, 10, 2016, 8)));
            StreckeDatum.Add(new Tuple<Tuple<string, string>, Tuple<int, int, int, int>>(
                new Tuple<string, string>("Valencia", "Spanien"), 
                new Tuple<int, int, int, int>(13, 11, 2016, 14)));

            // Initialisieren
            MotoGP.RennenHinzufuegen(StreckeDatum);
            MotoGP.FahrerHinzufuegen();


            Console.Clear();
            Tuple<Liga, Punktetabelle> ZuUebergeben = new Tuple<Liga, Punktetabelle>(MotoGP, PunkteTab);
            return ZuUebergeben;
        }

        public static void Close()
        {
        }
    }
}
