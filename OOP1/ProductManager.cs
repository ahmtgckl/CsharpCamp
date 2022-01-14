using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product)   
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update (Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }
    }
}
/// public void methodu nedir ? = sadece işini yapıp bitirmek için kullanılır. 
/// public int metodu nedir ? = oluşan sonucu başka yerde kullanılacak ise int şeklinde kullanılır.
