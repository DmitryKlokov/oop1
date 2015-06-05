using System;
using System.Collections.Generic;
using System.IO;

namespace oop.Input
{
    class ReaderCsv:IReader
    {
        public List<Cassete> Read(string box)
        {
            string line;
            List<Cassete> cassete = new List<Cassete>();
            StreamReader sr = File.OpenText(box);
            while ((line = sr.ReadLine()) != null)
            {
                string[] arr = line.Split(';');
                Cassete c = new Cassete()
                {
                    Nominal = Convert.ToUInt32(arr[0]),
                    Count = Convert.ToUInt32(arr[1])
                };
                cassete.Add(c);
            }
            return cassete;
        }
    }
}
