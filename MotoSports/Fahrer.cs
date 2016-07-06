using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSports
{
    class Fahrer
    {
        // Alter, Name etc
        private string Name { get; set; }
        private int Alter { get; set; }
        private int Gewicht { get; set; }

        public void SetName(string name)
        {
            if (!String.IsNullOrEmpty(name))
                Name = name;
            else
                // Fehlerbearbeitung
                throw new NotImplementedException();
        }

        public string GetName()
        {
            if (!String.IsNullOrEmpty(Name))
                return Name;
            else
                throw new NotImplementedException();
                return null;
        }
    }
}
