using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakZaPonavljanje4
{
    class Program
    {
        static void Main(string[] args)
        {
            var broj = new Random();
            List<int> brojevi = new List<int>();
            string[] igraci = new string[32];
            for (int i = 0; i < 32; i++)
            {
                igraci[i] = "Tenisač " + (i+1);
            }
            for (int i = 0, j = 0; i < 16; i++)
            {
                Console.WriteLine("Runda broj " + (i + 1) + ": " + igraci[j] + " je protiv " + igraci[j + 1]);
                j = j + 2;
            }
            Console.ReadKey();
        }
    }
}
