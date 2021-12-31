using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Ahmet Güçkol";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Engin Demirog";
            kurs2.IzlenmeOrani = 50;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Elin Musk";
            kurs3.IzlenmeOrani = 100;

            /// Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var xxx in kurslar)
            {
                Console.WriteLine(xxx.KursAdi + ":  " + xxx.Egitmen + " / " + xxx.IzlenmeOrani);
            }

        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set;}
        public int IzlenmeOrani { get; set; }
    }
}
