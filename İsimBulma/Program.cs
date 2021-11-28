using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İsimBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[5]
            {
                "Robert DeNiro",
                "Jennifer Lopez",
                "Robert Downey Jr.",
                "Al Pacino",
                "Kate Beckinsale",
            };
            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}
            //int j = 0;
            //while(j < isimler.Length)
            //{
            //    Console.WriteLine(isimler[j]);
            //    j++;
            //}

            Console.Write("İsim: ");
            string giris = Console.ReadLine();
            bool bulundu = false;
            foreach (string isim in isimler)
            {
                if (isim.ToUpper().Contains(giris.ToUpper()))
                {
                    bulundu = true;
                    break;
                }
            }
            if (bulundu)
            {
                Console.WriteLine(giris + " bulundu.");
            }
            else
            {
                Console.WriteLine(giris + " bulunamadı. ");
            }
            

            Console.ReadLine();
        }
    }
}
