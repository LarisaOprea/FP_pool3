using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            ///4.Deteminati printr-o singura parcurgere, 
            ///cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.
            int n, maxim, nrmaxim = 0, minim, nrminim;
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            v[0] = int.Parse(Console.ReadLine());
            maxim = v[0];
            minim = v[0];
            nrmaxim = 1;
            nrminim = 1;
            for (int i = 1; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] > maxim)
                {
                    maxim = v[i];
                    nrmaxim = 1;
                }
                else if (v[i] == maxim) nrmaxim++;

                if (v[i] < minim)
                {
                    minim = v[i];
                    nrminim = 1;
                }
                else if (v[i] == minim) nrminim++;
            }
            Console.WriteLine("Maximul este " + maxim + " si apare de " + nrmaxim + " ori.");
            Console.WriteLine("Minimul este " + minim + " si apare de " + nrminim + " ori.");

            Console.ReadKey();
;        }
    }
}
