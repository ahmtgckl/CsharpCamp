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
            Console.WriteLine("Sepete Eklenen ürün: " + x.Adi + " Fiyatı: " + x.Fiyati + "TL" + " stok adedi: " + x.StokAdedi);

        }

    }
}
