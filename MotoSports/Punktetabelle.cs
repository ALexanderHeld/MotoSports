using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSports
{
    class Punktetabelle
    {
        // Threadsicheres Singleton, da es nur eine Punktetabelle geben soll / darf
        private Punktetabelle PunkteSingleton = null;
        public Punktetabelle()
        {
            if (PunkteSingleton == null)
                PunkteSingleton = new Punktetabelle();
        }

        // Tatsaechliche Punktetabelle

        private Dictionary<Fahrer, int> Fahrerwertung { get; set; }
        private Dictionary<Team, int> Teamwertung { get; set; }

        // Funktionen um die Punkte zu manipulieren
            // Hinzufügen von Punkten
            // Strafpunkte

        // Funktionen um die Punkte anzeigen zu lassen
    }
}
