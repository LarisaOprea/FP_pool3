using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///1.Calculati suma elementelor unui vector de n numere citite de la tastatura. 
            ///Rezultatul se va afisa pe ecran.
            int n, s = 0;
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                s = s + v[i];
                Console.WriteLine(s);
            }

            Console.ReadKey();      
        }
    }
}
