using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());

            //N kullanıcı tarafından girilecek bir değer
            //N sayı aralığı 1 ile 100 arasında olmalı
            //N eğer sayı tek ise weird yazdırılması gerekli
            //N eğer sayı çift ise not weird yazdırılması gerekli
            //ALT KOŞULLAR
            //sayı 2 ile 5 arasında ve çift ise not weird
            //sayı 6 ile 20 arasında ve çift ise weird
            //sayı 20'den büyük ve çift ise not weird
            //1 ile 100 dışında başka bir sayı girilirse kullanıcı uyarılsın

            if (N >= 1 && N <= 100)
            {

                if (N % 2 != 0)
                {
                    Console.WriteLine("Weird");
                }
                if (N % 2 == 0 && N >= 2 && N <= 5)
                {
                    Console.WriteLine("Not Weird");
                }
                if (N % 2 == 0 && N >= 6 && N <= 20)
                {
                    Console.WriteLine("Weird");
                }
                if (N % 2 == 0 && N >= 21)
                {
                    Console.WriteLine("Not Weird");
                }
            }
            else
            {
                Console.WriteLine("Input data between 1 and 100");
            }


        }
    }
}
