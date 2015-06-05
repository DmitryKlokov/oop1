using System;
using System.Collections.Generic;

namespace oop.Output
{
    public class Out
    {
        public void ShowListOnConsole(List<Cassete> list)
        {
            foreach (Cassete m in list)
            {
                Console.WriteLine("Номинал: " + m.Nominal + " кол " + m.Count);
            }
        }
        public void ShowString(string str)
        {
            Console.WriteLine(str);
        }
        public string ReadStr()
        {
            return Console.ReadLine(); 
        }
    }
}