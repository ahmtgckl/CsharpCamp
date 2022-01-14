using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
        }
    }
}
/// int, decimal, float, double, bool = Değer tipi
/// array, class, interface = Referans tipidir.

/// değer tipi olanlar stack'de tanımlanır.
/// referans tipler ise heap'da tanımlanır.