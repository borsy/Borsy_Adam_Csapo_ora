using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp20240502
{
    class Program
    {

       static List<Epulet> epuletek = new List<Epulet>();

        static void Main(string[] args)
        {
            beolvasas();

            Console.WriteLine("Program vége!");
            Console.ReadLine();
        }

        private static void beolvasas()
        {
            using (StreamReader olvaso = new StreamReader("100_tallest_javitott.csv"))
            {
                olvaso.ReadLine(); // --fejléc kihagyása, nem kell
                while (!olvaso.EndOfStream)
                {
                    string[] sor = olvaso.ReadLine().Replace('"', ' ').Split(',');
                    Epulet epulet = new Epulet(int.Parse(sor[0].Trim()), sor[1].Trim(), sor[2].Trim(), int.Parse(sor[3].Trim()), int.Parse(sor[4].Trim()), int.Parse(sor[5].Trim()), int.Parse(sor[6].Trim()), sor[7].Trim(), sor[8].Trim());
                    epuletek.Add(epulet);
                }
            }
        }
    }
}
