using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım 1", 
                "Yazılım 2", "Yazılım 3", 
                "Yazılım 4","Yazılım 5",
                "Yazılım 6","Yazılım 7" };


            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti....");
            foreach (string farketmez in kurslar)
            {
                Console.WriteLine(farketmez);
            }

            Console.WriteLine("Sayfa Sonu.");
        }
    }
}
