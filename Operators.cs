using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve İşlemli Operatorlar
            int x = 3;
            int y = 5;
            y = y+2;
            //+-/*
            //Mantıksal O.
            // || && !
            
            bool isSUccess = true;
            bool isCompleted = false;
            if(isSUccess && isCompleted)
                Console.WriteLine("Perfect");
            if(isSUccess || isCompleted)
                Console.WriteLine("Great");
            if(isSUccess && isCompleted)
                Console.WriteLine("Fine");


            //İlişkisel Operatörler
            // <> >= <= == !=

            int a = 3;
            int b = 4;
            bool sonuc = a<b;
            //vs...
            //Aritmetik Operatörler
            // / * + -

            int sayi = 10;
            int sayi1 = 5;
            int sonuc2 = sayi/sayi1;
            sonuc2 = sayi1 ++;

            // % : Mod alır
            int sonuc3 = 20%3; //3e bölümünden kalanı bulur.
            



            
        }
        
    }
}

