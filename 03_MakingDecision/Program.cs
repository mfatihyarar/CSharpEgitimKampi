using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //string password;
            //Console.Write("Lütfen şifreyi giriniz: ");            
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();
            //if(capital=="ankara" & country=="türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");
            //}

            //int number;
            //Console.Write("Sayiyi giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if(number==5)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "hata!";

            //Console.Write("sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}

            #endregion

            #region Mod işlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Birinci sayiyi giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("İkinci sayiyi giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("1.sayının 2.sayıya bölümünden kalan: " + result);

            //Console.Write("lütsen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("sayı tektir");
            //}
            #endregion

            #region char değişkenler ile karar yapıları

            //char team;
            //Console.Write("lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'G' | team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'F' | team == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'B' | team == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            #endregion

            #region örnek proje uygulaması

            //Console.WriteLine("**** C# eğitim kampi restoran ****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------");
            //Console.WriteLine("1-Ana yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("detayını görmek istediginiz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if(menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----Ana yemekler----");
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-Fasulye pilav");
            //    Console.WriteLine("1-Fırında somon");
            //    Console.WriteLine("----------------------");
            //}
            //if(menuItem=="2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----Çorbalar----");
            //    Console.WriteLine("1-Mercimek çorbası");
            //    Console.WriteLine("2-Exogelin çorbası");
            //    Console.WriteLine("1-Tavuk çorbası");
            //    Console.WriteLine("----------------------");
            //}
            //if(menuItem=="3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----Pizzalar----");
            //    Console.WriteLine("1-Sucuksever pizza");
            //    Console.WriteLine("2-Tavuklu pizza");
            //    Console.WriteLine("3-Margaritha");
            //    Console.WriteLine("----------------------");
            //}
            //if(menuItem=="4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----İçecekler----");
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Fanta");
            //    Console.WriteLine("1-Ayran");
            //    Console.WriteLine("----------------------");
            //}
            //if(menuItem=="5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----Tatlılar----");
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Güllaç");
            //    Console.WriteLine("1-Kazandibi");
            //    Console.WriteLine("----------------------");
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int mountNumber = int.Parse(Console.ReadLine());

            //switch (mountNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı veri girişi"); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("lütfen yapmak  istediginiz işleme ait sembolü giriniz (+, -, *, /): ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("işlem sonucu: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("işlem sonucu: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("işlem sonucu: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("işlem sonucu: " + result);
            //        break;

            //    default:
            //        Console.WriteLine("Hatalı sembol girişi");
            //        break;
            //}

            #endregion

            Console.Read();
        }
    }
}
