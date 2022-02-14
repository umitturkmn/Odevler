//using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Threading;
//using System.Threading.Tasks;
//
//namespace degiskenler1
//{
//    internal class NewBaseType
//    {
//        static void Main(string[] args)
//        {
//            //Implicit Conversioın (Bilinçsiz Dönüşüm)
//
//            byte a = 5;
//            sbyte b = 30;
//            short c = 10;
//
//            int d = a + b + c;
//
//            string e = "ümit";
//            char f = 'ü';
//            object g = e + f + d;
//
//            //Explicit Conversion(Bilinçli Dönüşüm)
//            int x = 4;
//            byte y = (byte)x;
//
//            int z = 100;
//            byte t = (byte)z;
//
//            //To String Metodu
//            int xx = 52;
//            string yy = xx.ToString();
//
//            string zz = 12.5f.ToString();
//
//            //System. Convert
//            string s1 = "10", s2 = "20";
//            int say, say2;
//            int Toplam;
//            say = Convert.ToInt32(s1);
//            say2 = Convert.ToInt32(s2);
//
//            //Parse Metodu
//            string met1 = "10", met2 = "20";
//            int rakam;
//            double double1;
//            rakam = Int32.Parse(met1);
//            double1 = Double.Parse(met2);
//
//        }
//    }
//
//    class donusumler : NewBaseType
//    {
//    }
//}
//
//