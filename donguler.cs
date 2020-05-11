using System;
using System.Diagnostics;

namespace karar_yapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            //örnek1
            //int i; Console.Write("Lühfen bir değer giriniz: "); i = Convert.ToInt16(Console.ReadLine());
            //for (i=1; i <= 10; i++) {  Console.WriteLine("deneme"); } 
            //örnek2
            // int i;
            //for (i=1; i<=10; i++)  { Console.WriteLine(i); }
            //örnek 3
            //int i; for (i = 0; i<=58; i+=4)   {  Console.WriteLine(i);    }

            int i;
            int toplam = 0;

            for (i = 1; i <= 10; i+=2) { toplam = toplam + i; }
            Console.WriteLine("Toplam: "+toplam);

             Console.ReadLine();



                
            
            









            Console.ReadLine();
        }

    }
}



