using System.Collections.Generic;

namespace oop
{
    public interface IDecompositionAlgorithm
    {
        void StartAlgorithm(List<Cassete> listCassete, uint sum);
        List<Cassete> OutMoney();
        State State { get; }
    }
}
