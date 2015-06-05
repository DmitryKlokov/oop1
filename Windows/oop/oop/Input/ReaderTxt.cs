using System.Collections.Generic;
using System.IO;

namespace oop.Input
{
    public class ReaderTxt : IReader
    {
        public List<Cassete> Read(string address)
        {
            List<Cassete> list= new List<Cassete>();
            StreamReader sr = new StreamReader(address);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] split = line.Split(' ', '\t');
                Cassete m = new Cassete();
                m.Nominal = uint.Parse(split[0]);
                m.Count = uint.Parse(split[1]);
                list.Add(m);
            }
            return list;
        }
    }
}
