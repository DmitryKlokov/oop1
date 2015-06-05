using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace oop.Input
{
    public class ReaderJson:IReader
    {
        public List<Cassete> Read(string address)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Cassete>));
            List<Cassete> ls;
            using (FileStream fs = new FileStream(address, FileMode.OpenOrCreate))
            {
                ls = (List<Cassete>) jsonFormatter.ReadObject(fs);
            }
            return ls;
        }
    }
}
