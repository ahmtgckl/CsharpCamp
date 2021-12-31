using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SeperManager
    {
        // metot public voide ile yapılır. phytonda def ile yapılır. (Fonksiyon = Metot)
        public void Ekle(Product x)
        {
            Console.WriteLine("Sepete Eklendi :)" + x.Adi + " " + x.Fiyati + " " + "stok adedi: " + x.StokAdedi);

        }

    }
}
