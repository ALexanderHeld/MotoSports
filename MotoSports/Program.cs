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
            Init();
            while (true)
            {
                string eingabe = Console.ReadLine();
                if (eingabe == "exit")
                    break;
            }
            Close();
        }

        public static void Init()
        {
            Liga MotoGP = new Liga();
            MotoGP.LigaTyp = Liga.League.MotoGP;

            // Aprilia Racing Team Gresini
            Team TApriliaRacing = new Team("Aprilia Racing Team Gresini");
            TApriliaRacing.FahrerHinzufuegen("Stefan", "Bradel", "Aprilia");
            TApriliaRacing.FahrerHinzufuegen("Alvaro", "Bautista", "Aprilia");
            MotoGP.TeilnehmendeTeams.Add(TApriliaRacing);

            // Movistar Yamaha MotoGP
            Team TMoviStar = new Team("Movistar Yamaha MotoGP");
            TMoviStar.FahrerHinzufuegen("Valentino", "Rossi", "Yamaha");
            TMoviStar.FahrerHinzufuegen("Jorge", "Lorenzo", "Yamaha");
            MotoGP.TeilnehmendeTeams.Add(TMoviStar);

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

            // Team SUZUKI ECSTAR
            Team TEstrella = new Team("Estrella Galicia 0,0 Marc VDS");
            TEstrella.FahrerHinzufuegen("Jack", "Miller", "Honda");
            TEstrella.FahrerHinzufuegen("Tito", "Rabat", "Honda");
            MotoGP.TeilnehmendeTeams.Add(TEstrella);

            MotoGP.StreckeHinzufuegen("Losail", "Katar", 20, 3, 2016, 19, 0);
            MotoGP.StreckeHinzufuegen("Termas de Río Hondo", "Argentinien", 3, 4, 2016, 21, 0);
            MotoGP.StreckeHinzufuegen("Austin", "Amerika", 10, 4, 2016, 21, 0);
            MotoGP.StreckeHinzufuegen("Jerez de la Frontera", "Spanien", 24, 4, 2016, 14, 0);
            MotoGP.StreckeHinzufuegen("Le Mans", "Frankreich", 8, 5, 2016, 14, 0);
            MotoGP.StreckeHinzufuegen("Mugello", "Italien", 22, 5, 2016, 14, 0);
            MotoGP.StreckeHinzufuegen("Barcelona", "Spanien", 5, 6, 2016, 14, 0);
            MotoGP.StreckeHinzufuegen("Assen", "Niederlande", 26, 6, 2016, 14, 0);
            MotoGP.StreckeHinzufuegen("Hohenstein-Ernstthal", "Deutschland", 17, 7, 2016, 14, 0);
            MotoGP.StreckeHinzufuegen("Spielberg", "Österreich", 14, 8, 2016, 14, 0);
            MotoGP.StreckeHinzufuegen("Brünn", "Tschechien", 21, 8, 2016, 14, 0);
            MotoGP.StreckeHinzufuegen("Silverstone", "Großbritanien", 4, 9, 2016, 14, 0);
            MotoGP.StreckeHinzufuegen("Misano Adriatico", "Italien", 11, 9, 2016, 14, 0);
            MotoGP.StreckeHinzufuegen("Alcaniz", "Spanien", 25, 9, 2016, 14, 0);
            MotoGP.StreckeHinzufuegen("Motegi", "Japan", 16, 10, 2016, 7, 0);
            MotoGP.StreckeHinzufuegen("Phillip Island", "Australien", 23, 10, 2016, 7, 0);
            MotoGP.StreckeHinzufuegen("Sepang", "Malaysia", 30, 10, 2016, 8, 0);
            MotoGP.StreckeHinzufuegen("Valencia", "Spanien", 13, 11, 2016, 14, 0);

            Console.Clear();
        }

        public static void Close()
        {
        }
    }
}
