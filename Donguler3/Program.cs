using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for dongusu ile klavyeden girilen sayinin tam bolenlerini bulma
            int sayi;
            int i;
            Console.WriteLine("Lutfen bir sayi giriniz : ");
            Console.WriteLine();
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.Read();
        }
    }
}
