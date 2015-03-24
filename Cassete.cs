using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class Cassete
    {
        public uint nominal = 0;
        public uint Count = 0;
        public Cassete(uint nominal, uint Count)
        {
            this.nominal = nominal;
            this.Count = Count;
        }
    }
}
