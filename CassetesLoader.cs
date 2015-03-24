using System;
using System.Collections.Generic;
using System.IO;

namespace oop
{
    public class CassetesLoader
    {
        private List<Cassete> list_money;

        public stateLoad state;

        public CassetesLoader (string Cassete)
        {
            list_money = new List<Cassete>();
            try
            {
                StreamReader sr = new StreamReader(Cassete);
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    string[] split = line.Split(new char[] { ' ', '\t' });
                    Cassete m = new Cassete(uint.Parse(split[0]), uint.Parse(split[1]));
                    list_money.Add(m);
                }
                if (list_money.Count == 0) { state = stateLoad.NoCassete; }
                else state = stateLoad.AllOK;
            }
            catch (Exception e) { Console.WriteLine(e.ToString()); state = stateLoad.Error; }
        }
        public List<Cassete> LoadingCassete()
        {
            return list_money;
        }
    }
}
