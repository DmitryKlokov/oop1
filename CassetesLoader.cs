using System;
using System.Collections.Generic;
using System.IO;
using log4net;

namespace oop
{
    public class CassetesLoader
    {
        private List<Cassete> listCassete;        

        public State state;

        public static readonly ILog log = LogManager.GetLogger(typeof(CassetesLoader));

        public void Load(string address)
        {
            log.Info("Try load cassetes"); 
            listCassete = new List<Cassete>();
            try
            {
                StreamReader sr = new StreamReader(address);
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    string[] split = line.Split(new char[] { ' ', '\t' });
                    Cassete m = new Cassete(uint.Parse(split[0]), uint.Parse(split[1]));
                    listCassete.Add(m);
                }
                if (listCassete.Count == 0) 
                { 
                    state = State.NoCassete;
                    log.Error(state);
                }
                else 
                { 
                    state = State.AllOK;
                    log.Info(state); 
                }
                
            }
            catch 
            {
                state = State.Error;
                log.Error(state);
            }
        }



        public List<Cassete> LoadingCassete()
        {
            listCassete.Sort((A, B) => B.nominal.CompareTo(A.nominal));
            return listCassete;
        }
    }
}
