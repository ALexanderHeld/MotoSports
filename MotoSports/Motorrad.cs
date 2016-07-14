using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSports
{
    class Motorrad
    {
        private string TypenBezeichnung { get; set; }
        private string Marke { get; set; }
        private int TopSpeed { get; set; }

        private List<Reifen> ZugelasseneReifen { get; set; }
    }
}
