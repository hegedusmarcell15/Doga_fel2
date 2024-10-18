using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga_fel2
{
    internal class Program
    {
        public static void szamok()
        {
            int pozitivszamok = 0;
            int negativszamok = 0;
            for (int i = 0; i < 10; i++) 
            {
                Console.Write("Kérlek add meg az egész számokat:");
                int szam = Convert.ToInt32 (Console.ReadLine());
                if (szam > 0)
                {
                    pozitivszamok += szam;
                
                }
                else if (szam < 0)
                {
                    negativszamok += szam;
                }
                else { Console.WriteLine("A szám nem adható hozzá");}
            }
            Console.WriteLine("A pozitív számok összege: {0}", pozitivszamok);
            Console.WriteLine("A negatív számok összege: {0}", negativszamok);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            szamok();
        }
    }
}
