using System.Collections.Generic;
using System.IO;
using log4net;

namespace oop
{
    public class CassetesLoader
    {
        private List<Cassete> _listCassete;        

        public State State;

        public static readonly ILog Log = LogManager.GetLogger(typeof(CassetesLoader));

        public void Load(string address)
        {
            Log.Info("Try load cassetes"); 
            _listCassete = new List<Cassete>();
            try
            {
                StreamReader sr = new StreamReader(address);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] split = line.Split(' ', '\t');
                    Cassete m = new Cassete(uint.Parse(split[0]), uint.Parse(split[1]));
                    _listCassete.Add(m);
                }
                if (_listCassete.Count == 0) 
                { 
                    State = State.NoCassete;
                    Log.Error(State);
                }
                else 
                { 
                    State = State.AllOk;
                    Log.Info(State); 
                }
                
            }
            catch 
            {
                State = State.Error;
                Log.Error(State);
            }
        }



        public List<Cassete> LoadingCassete()
        {
            _listCassete.Sort((a, b) => b.Nominal.CompareTo(a.Nominal));
            return _listCassete;
        }
    }
}
