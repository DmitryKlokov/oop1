using System;
using System.Collections.Generic;
using log4net;

namespace oop
{
    class ATM
    {
        public List<Cassete> listCassete;
        public List<Cassete> decomposition;
        public State state;
        public static readonly ILog log = LogManager.GetLogger(typeof(ATM));
        private uint TotalSum 
        {
            get
            {
                uint sum = 0;
                foreach (Cassete c in listCassete) { sum += c.nominal * c.Count; }         
                return sum;
            }
        }

        public List<Cassete> DifferenceList(List<Cassete> A, List<Cassete> B)
        {
            int index;
            foreach (Cassete m in B)
            {
                index = A.FindIndex(l => l.nominal == m.nominal);
                A[index].Count -= m.Count;
            }
            return A;
        }
        public void outMoney(uint sum)
        {
            state = State.AllOK;
            log.Debug("Try otput " + sum.ToString());
            if (sum <= TotalSum)
            {
                DecompositionAlgorithm da = new DecompositionAlgorithm();

                da.StartAlgorithm(listCassete, sum);
                if (da.state == State.AllOK)
                {
                    DifferenceList(listCassete, da.OutMoney());
                    decomposition = new List<Cassete>(da.OutMoney());
                    log.Info(da.state);
                    log.Info("ATM balance: "+TotalSum);
                }
                else 
                {
                    state = da.state; 
                    log.Warn(state);
                    log.Warn("ATM balance: " + TotalSum);
                }
            }
            else
            {
                state = State.CombinationFailed;
                log.Warn("Sum"+sum.ToString()+"> Total Sum");
            }
        }

    }
}
