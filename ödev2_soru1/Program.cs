using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev2_soru1
{
    class Program
    { 
        static string soru1cozum( string cumle1)
        {
            char harf, yeniHarf;
            Console.WriteLine("Değiştirilecek harfi giriniz:");
            harf = char.Parse(Console.ReadLine());
            Console.WriteLine("Harfin yeni değerini giriniz:");
            yeniHarf = char.Parse(Console.ReadLine());
            for (int i = 0; i < cumle1.Length; i++)
            {
                if (cumle1[i] == harf)
                {
                    cumle1 = cumle1.Replace(harf, yeniHarf);

                }

            }
            return cumle1;
        }
        static void Main(string[] args)
        {
            String cumle = "";
            Console.Write("Cümleyi giriniz: ");
            cumle = Console.ReadLine();
            cumle=soru1cozum(cumle);
            Console.WriteLine(" " + cumle);
            Console.ReadKey();


        }
    }
}
