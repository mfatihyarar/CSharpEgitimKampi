using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for döngüsü

            //For(x;y;z)
            //x:başlangıç
            //y: bitiş
            //z:artış-azalış

            //int i;

            //for (i=1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# eğitim kampı");
            //}

            //for (int i = 0; i <= 20; i++) 
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("lütfen ekrana yazılmasını istediginiz adedi giriniz: ");
            //int finishvalue = int.Parse(Console.ReadLine());

            //for (int i = 0; i < finishvalue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet! ");
            //}

            #endregion

            #region For döngüsü ile karar yayapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine(totalValue);

            //int count = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if(i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //int bakteri = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i + ". saat sounda: " + bakteri);
            //}

            #endregion

            #region while döngüsü

            //While(şart)
            //{
            //işlemler
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("merhaba döngüler");
            //    i++;
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0) 
            //    {
            //        Console.WriteLine(i);               
            //    }
            //    i++;
            //}

            //int i = 1;
            //int result = 0;

            //while (i <= 10)
            //{
            //    result += i;
            //    i++;
            //}

            //Console.WriteLine(result);

            #endregion

            #region örnek sınav sorusu

            //klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            Console.Write("Sayi giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;
            sum = ones + tens + hundreds;

            Console.WriteLine("ones: " + ones + " - tens: " + tens + " - hundreds: " + hundreds);
            Console.WriteLine("basamakların toplamı: " + sum);


            #endregion

            Console.Read();
        }
    }
}
