using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Out
    {
        public void ShowListOnConsole(List<Cassete> list)
        {
            foreach (Cassete m in list)
            {
                Console.WriteLine("Номинал: " + m.nominal + " кол " + m.Count);
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
