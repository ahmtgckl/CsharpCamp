using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// ilk yöntem
            
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 5;
            product1.ProductName = "Masa";
            product1.UnitePrice = 500;
            product1.UnitsInStock = 3;


            /// ikinci yöntem
            
            Product product2 = new Product {Id = 2, CategoryId = 5, UnitsInStock = 6, ProductName = "Kalem", UnitePrice = 35 };
            


            /// PascalCase = büyük harf class   -    /// camelCase = değişken küçük harf

            ProductManager productManager = new ProductManager();  /// productManager yerine x konulabilir.
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


        }
    }
}

/// int,double,bool.... sayısal değerler, değer tipidir. (sayıyı verdik, tek sefer değişti bitti.)
/// diziler, class, abstracat class, interface.... referans tipidir. ( sürekli güncelleme yapar, değişir)