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
           try{
           Console.Write("Bir Sayı Giriniz: ");
           int sayi = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Girmiş Olduğunuz Sayı: " + sayi);
           } 
           catch(Exception ex)
           {
               Console.WriteLine("Hata: " + ex.Message.ToString());
           }
           finally
           {
               Console.WriteLine("İşlem Tamamlandı.");
           }

        try
        {
            //int a = int.Parse(null);
            //int a = int.Parse("test");
            int a =  int.Parse("-20000000000000");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Yanlış veri tipi.");
            Console.WriteLine(ex);
        }
        catch(OverflowException ex)
        {
            Console.WriteLine("Çok küçük veya büyük bir değer girdiniz.");
            Console.WriteLine(ex);
        }
        }
        
    }
}

