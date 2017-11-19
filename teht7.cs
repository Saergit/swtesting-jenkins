using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jenkinstest
{
    class Program
    {
        static void Main(string[] args)
        {
            double brutto = 0;
            int lapset = 0;

            Console.WriteLine("Syötä lapsien lukumäärä: ");
            lapset = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä bruttotulo: ");
            brutto = double.Parse(Console.ReadLine());

            double vahennykset = 330 + ((double)lapset * 16);

            double ennenveroja = bruttotulo - vahennykset;

            double verot = 0;
            double netto = 0;

            if (ennenveroja > 20000)
            {
                verot = 0.3 * ennenveroja;
            }
            else
            {
                verot = 0.2 * ennenveroja;
            }
            netto = ennenveroja - verot;

            Console.WriteLine("Bruttotulosi on: ");
            Console.WriteLine("Vähennyksien määrä: ");
            Console.WriteLine("Verojen osuus: ");
            Console.WriteLine("Nettotulosi on: ");
        }
    }
}
