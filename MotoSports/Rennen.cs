using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSports
{
    class Rennen
    {
        public Rennen(Strecke strecke, int tag, int monat, int jahr, int stunde)
        {
            AustragungsOrt = strecke;
            Datum = new DateTime(jahr, monat, tag, stunde, 0, 0);
            RanglisteNachBeendigung = new List<Fahrer>();
        }

        public Strecke AustragungsOrt { get; set; }
        public DateTime Datum { get; set; }
        public List<Fahrer> RanglisteNachBeendigung { get; set; }

        public List<Fahrer> GeneriereRennergebnis(List<Fahrer> input)
        {
            Random rnd = new Random();
            List<Fahrer> output = input;
            var result = output.OrderBy(item => rnd.Next());
            RanglisteNachBeendigung = result.ToList();

            Console.Clear();
            Console.WriteLine($"Wir sind in {AustragungsOrt.Land} auf der {AustragungsOrt.Streckenname} - Strecke.\nDas Wetter ist gut " +
            "und das Rennen geht gleich los!");

            animateProgressBar();
            return result.ToList();
        }

        private void animateProgressBar() // fehler
        {
            int top = Console.CursorTop;
            int left = Console.CursorLeft;
            int milisekunden = 5;

            Console.WriteLine(".................... 0%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("=................... 5%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("==.................. 10%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("===................. 15%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("====................ 20%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("=====............... 25%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("======.............. 30%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("=======............. 35%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("========............ 40%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("=========........... 45%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("==========.......... 50%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("===========......... 55%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("============........ 60%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("=============....... 65%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("==============...... 70%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("===============..... 75%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("================.... 80%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("=================... 85%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("==================.. 90%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("===================. 95%");
            System.Threading.Thread.Sleep(milisekunden);
            Console.SetCursorPosition(left, top);
            Console.WriteLine("==================== 100%\n\n");
        }
    }
}
