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
            Reihenfolge = new SortedList<int, Fahrer>();
        }
        public SortedList<int, Fahrer> Reihenfolge { get; set; }
        

        // Methoden
        public void InitFahrer(params Fahrer[] args) 
        {
            foreach (Fahrer f in args)
            {
                Reihenfolge.Add(0, f);
            }
        }

        public void PunkteVergeben(params Fahrer[] args)
        {
            foreach (Fahrer f in args)
            {
                int temp = Reihenfolge.Keys[Reihenfolge.IndexOfValue(f)];
                Reihenfolge.Remove()

            }
        }
       
    }
}
