using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///3.Sa se determine pozitiile dintr-un vector 
            ///pe care apar cel mai mic si cel mai mare element al vectorului.
            int n, maxim, minim, pozmaxim = 0, pozminim = 0;
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            v[0] = int.Parse(Console.ReadLine());
            maxim = v[0];
            minim = v[0];
            for (int i = 1; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] > maxim)
                {
                    maxim = v[i];
                    pozmaxim = i;
                }
                else if (v[i] < minim)
                {
                    minim = v[i];
                    pozminim = i;
                }
            }
            Console.WriteLine("Maximul este " + maxim + " pe pozitia " + pozmaxim + ", iar minimul este " + minim + " pe pozitia " + pozminim);
            Console.ReadKey();
        }
    }
}
