using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fonksiyon_ile_toplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            Console.Write("Sayı Gir: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sayı Gir: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            var result = topla(sayi1,sayi2);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int topla(int s1, int s2)
        {
            return s1 + s2;
        }

    }
}
