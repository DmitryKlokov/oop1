using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_1
{
    public class Money : IComparable<Money>
    {
       public uint nominal=0;
       public uint Count=0;
       public Money(uint nominal1, uint Count1)
       {
           this.nominal = nominal1;
           this.Count = Count1;
       }
       public int CompareTo(Money item)
       {
           return item.Count.CompareTo(this.Count);
       }
    }
}
