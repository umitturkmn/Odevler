using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace degiskenler
{
    class Variables
    {
        static void Main(string[] args)
        {
            //Valıue Types - Veri Tipleri
            byte sayi0 = 0; // byte veri tipi (0 ile 255) arasını kapsar.
            short sayi1 = 32767; // short veri tipi (-32768 ile 32767) arasını kapsar.
            int sayi2 = 2147483647; // int veri tipi(-2147483648 ile 2147483647;) arasını kapsar.
            long sayi3 = 9223372036854775807; // long veri tipi(-9223372036854775808 ile 9223372036854775807;) arasını kapsar.
            double sayi4 = 52.52; // double veri tipi ondalıklı sayıları kapsar. 64 bit kapsar. virgülden sonra 15-16 karakter tutabilir.
            decimal sayi5 = 52.52m; // decimal veri tipi ondalıklı sayıları kapsar. 64 bit kapsar. virgülden sonra 26-27 karakter tutabilir. sonuna m koyulur.
            bool condition = true; // bool veri tipi -true,false- olabilir.
            char Chracter = 'A'; // char veri tipi harfleri kapsar.
            string City = "Ordu"; // string veri tipi harflerden oluşan dizeyi kapsar.
            //Days.Sunday Enum veri tipi tek tek string girmemizi engeller. Kolaydır.
            var degisken = 52; // bu ne atarsanız ona göre veri tipi olur. sonradan değiştirilmez.
           DateTime dt = new DateTime();
           dt = DateTime.Now;
           object o1 = "x";
           object o2 = 'y';
           object o3 = 3;
           object o4 = 4.3;
           //değer dönüşümleri
           string str = "20";
           int int20 = 20;
           string newvariable = str + int20.ToString(); //string yapma
           int int21 = int20 + Convert.ToInt32(str); //int yapma
           int int22 = int20 + int.Parse(str);
        }
        enum Days
        {
            Monday,Tuesday,Wednasday,Thursday,Friday,Saturday,Sunday
        }
    }
}

