using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f;
            Console.Write("Masukkan nilai a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan nilai b: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            d = a - b;
            e = a * b;
            f = a / b;

            Console.WriteLine("\nc = hasil pertambahan a + b = {0}", c);
            Console.WriteLine("\nc = hasil pertambahan a - b = {0}", d);
            Console.WriteLine("\nc = hasil pertambahan a * b = {0}", e);
            Console.WriteLine("\nc = hasil pertambahan a / b = {0}", f);

                bool CompareC1, CompareC2, CompareD1, CompareD2, CompareD3, CompareD4;
            CompareC1 = c < e;
            CompareC2 = c > e;
            CompareD1 = d <= f;
            CompareD2 = d >= f;
            CompareD3 = c == e;
            CompareD4 = d != f;

            Console.WriteLine("\nmaka c < e adalah {0}", CompareC1);
            Console.WriteLine("maka c > e adalah {0}", CompareC2);
            Console.WriteLine("maka d <= f adalah {0}", CompareD1);
            Console.WriteLine("maka d >= f adalah {0}", CompareD2);
            Console.WriteLine("maka c = e adalah {0}", CompareD3);
            Console.WriteLine("maka d != f adalah {0}", CompareD3);

        }
    }
}
