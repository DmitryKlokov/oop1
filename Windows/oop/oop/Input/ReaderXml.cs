using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace oop.Input
{
    public class ReaderXml:IReader
    {
        public List<Cassete> Read(string address)
        {
            List<Cassete> list;
            using (var reader = new StreamReader(address))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Cassete>), new XmlRootAttribute("xml"));
                list = (List<Cassete>)deserializer.Deserialize(reader);
            }
            return list;
        }
    }
}
