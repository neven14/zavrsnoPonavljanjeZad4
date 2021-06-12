using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsnoPonavljanjeZad4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] igraci = new string[32];
            for (int i = 0; i < 32; i++)
            {
                Console.Write("Upisite igraca broj " + (i + 1) + ": ");
                igraci[i] = Console.ReadLine();
            }
            for (int i = 0, j = 0; i < 16; i++)
            {
                Console.WriteLine("Par broj " + (i + 1) + ": " + igraci[j] + " vs " + igraci[j + 1]);
                j = j + 2;
            }
            Console.ReadKey();
        }
    }
}
