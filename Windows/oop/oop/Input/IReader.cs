using System.Collections.Generic;

namespace oop.Input
{
    public interface IReader
    {
        List<Cassete> Read(string address);
    }
}
