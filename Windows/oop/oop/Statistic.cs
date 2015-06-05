using System;
using System.Collections.Generic;
using oop.Output;

namespace oop
{
    public class Statistic
    {
        public uint CountMoneyLoad;
        public uint CountMoneyOut;
        public DateTime Date;
        public List<OutSum> Sums =  new List<OutSum>();
        public List<Cassete> Ls = new List<Cassete>();
    }
}
