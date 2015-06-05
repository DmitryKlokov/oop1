using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using log4net;
using oop.Output;

namespace oop
{
    public class Atm
    {
        public List<Cassete> ListCassete = new List<Cassete>();
        public List<Cassete> Decomposition;
        public State State;
        public Statistic  Stat =  new Statistic();
        public static readonly ILog Log = LogManager.GetLogger(typeof(Atm));
        public uint TotalSum 
        {
            get
            {
                return ListCassete.Aggregate<Cassete, uint>(0, (current, c) => current + c.Nominal*c.Count);
            }
        }

        private readonly IDecompositionAlgorithm _algorithm;
        public Atm(IDecompositionAlgorithm algorithm)
        {
            _algorithm = algorithm;
        }

        public void WriteStat()
        {
            using (var writer = new FileStream("Load.xml", FileMode.Create))
            {
                Stat.Ls = ListCassete;
                XmlSerializer ser = new XmlSerializer(typeof(Statistic), new XmlRootAttribute("Statistic"));
                ser.Serialize(writer, Stat);
            }
        }

        public void ReadState()
        {
            Stat.Sums = new List<OutSum>();
            using (var reader = new FileStream("Load.xml", FileMode.Open))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Statistic), new XmlRootAttribute("Statistic"));
                Stat = (Statistic)deserializer.Deserialize(reader);
                ListCassete = Stat.Ls;
            }
        }

        private void DifferenceList(List<Cassete> a, List<Cassete> b,uint sum)
        {
            foreach (Cassete m in b)
            {
                var index = a.FindIndex(l => l.Nominal == m.Nominal);
                a[index].Count -= m.Count;
            }
            OutSum os = new OutSum
            {
                Date = DateTime.Now,
                Sum = sum
            };
            Stat.Sums.Add(os);
        }

        public void OutMoney(uint sum)
        {
            State = State.AllOk;
            Log.Debug("Try otput " + sum.ToString());
            if (sum <= TotalSum)
            {


                _algorithm.StartAlgorithm(ListCassete, sum);
                if (_algorithm.State == State.AllOk)
                {
                    DifferenceList(ListCassete, _algorithm.OutMoney(), sum);
                    Decomposition = new List<Cassete>(_algorithm.OutMoney());
                    Log.Info(_algorithm.State);
                    Log.Info("ATM balance: "+TotalSum);
                }
                else 
                {
                    State = _algorithm.State; 
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
