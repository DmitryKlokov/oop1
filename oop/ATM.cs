using System.Collections.Generic;
using System.Linq;
using log4net;

namespace oop
{
    public class Atm
    {
        public List<Cassete> ListCassete;
        public List<Cassete> Decomposition;
        public State State;
        public static readonly ILog Log = LogManager.GetLogger(typeof(Atm));
        public uint TotalSum 
        {
            get
            {
                return ListCassete.Aggregate<Cassete, uint>(0, (current, c) => current + c.Nominal*c.Count);
            }
        }

        private List<Cassete> DifferenceList(List<Cassete> a, List<Cassete> b)
        {
            foreach (Cassete m in b)
            {
                var index = a.FindIndex(l => l.Nominal == m.Nominal);
                a[index].Count -= m.Count;
            }
            return a;
        }
        public void OutMoney(uint sum)
        {
            State = State.AllOk;
            Log.Debug("Try otput " + sum.ToString());
            if (sum <= TotalSum)
            {
                DecompositionAlgorithm da = new DecompositionAlgorithm();

                da.StartAlgorithm(ListCassete, sum);
                if (da.State == State.AllOk)
                {
                    DifferenceList(ListCassete, da.OutMoney());
                    Decomposition = new List<Cassete>(da.OutMoney());
                    Log.Info(da.State);
                    Log.Info("ATM balance: "+TotalSum);
                }
                else 
                {
                    State = da.State; 
                    Log.Warn(State);
                    Log.Warn("ATM balance: " + TotalSum);
                }
            }
            else
            {
                State = State.CombinationFailed;
                Log.Warn("Sum"+sum.ToString()+"> Total Sum");
            }
        }

    }
}
