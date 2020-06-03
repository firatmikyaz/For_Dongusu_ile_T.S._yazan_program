using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace D20_For_Dongusu_Ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilecek 6 adet sayının pozitif,negatif veya sıfır olarak tanımlanmasını sağlayalım//

            /*int sayi;
            for (int sayac = 1; sayac <= 6; sayac++)
            {
                Console.WriteLine("{0}.Sayıyı Giriniz?", sayac);
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi>0)
                {
                    Console.WriteLine("Pozitif");
                }
                else if (sayi<0)
                {
                    Console.WriteLine("Negatif");
                }
                else
                {
                    Console.WriteLine("Sıfır");
                }
            }
            Console.ReadKey();*/


            for (int i = 0; i <= 12; i=i+2)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("*");
            }
            

            for (int j = 1; j <= 5; j++)
            {
                Console.SetCursorPosition(6, j);
                Console.Write("*");
            }
            for (int k = 18; k <= 26; k=k+2)
            {
                Console.SetCursorPosition(k, 0);
                Console.Write("*");
            }
            for (int m = 1; m <= 2; m++)
            {
                Console.SetCursorPosition(18, m);
                Console.Write("*");
            }
            for (int n = 20; n <= 26; n=n+2)
            {
                Console.SetCursorPosition(n, 2);
                Console.Write("*");
            }
            for (int p = 2; p <= 5; p++)
            {
                Console.SetCursorPosition(26, p);
                Console.Write("*");
            }
            for (int r = 18; r <= 26; r=r+2)
            {
                Console.SetCursorPosition(r, 5);
                Console.Write("*");
            }
            Console.ReadKey();
        }
    }
}
