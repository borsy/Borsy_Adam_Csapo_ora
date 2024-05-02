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
            using (StreamReader olvaso = new StreamReader("100_tallest_javitott4.csv"))
            {
                while (!olvaso.EndOfStream)
                {
                    string[] sor = olvaso.ReadLine().Split(';');
                    Epulet epulet = new Epulet(int.Parse(sor[0]), sor[1], sor[2], double.Parse(sor[3]), double.Parse(sor[4]), int.Parse(sor[5]), int.Parse(sor[6]));
                    epuletek.Add(epulet);
                }
            }
        }
    }
}
