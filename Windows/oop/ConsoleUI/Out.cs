using System;
using System.Collections.Generic;
using oop;

namespace ConsoleUI
{
    public class Out
    {
        public void ShowListOnConsole(List<Cassete> list)
        {
            foreach (Cassete m in list)
            {
                Console.WriteLine(Program.Rm.GetString("Nom", Program.C) + ":" + m.Nominal + " " +Program.Rm.GetString("Count", Program.C) + ":" + m.Count);
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