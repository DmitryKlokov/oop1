using System;
using System.Collections.Generic;


namespace oop
{
    class Program
    {
        

        static void Main(string[] args)
        {
            ATM b = new ATM();   
            uint sum = 0;
            while (true)
            {
                Console.WriteLine("Input sum: ");
                try
                {
                     sum= uint.Parse(Console.ReadLine());
                }
                catch { sum = 0; Console.WriteLine("Некорректный ввод "); }
                b.outMoney(sum);
                Console.WriteLine("\n\n\n");
            }
        }
    }
}
