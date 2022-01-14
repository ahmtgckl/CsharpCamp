using System;
using System.Collections.Generic;


namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////eşitliğin sol tarafı stack'da oluşur. sağ tarafı heap'da oluşur.

            //string[] isimler = new string[] { "engin", "fatih", "memet", "abuzittin" };
            //console.writeline(isimler[0]);
            //console.writeline(isimler[1]);
            //console.writeline(isimler[2]);
            //console.writeline(isimler[3]);
            //console.writeline(isimler[0]);

            //isimler = new string[5];
            //isimler[4] = "sebastian";
            //console.writeline(isimler[4]);
            //console.writeline(isimler[0]);
            //console.writeline(isimler[4]);


            List<string> isimler2 = new List<string> { "Engin", "Fatih" , "Bülent", "Ceren"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Sevda");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
