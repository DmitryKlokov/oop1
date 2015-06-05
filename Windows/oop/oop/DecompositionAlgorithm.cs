using System.Collections.Generic;

namespace oop
{
    public class DecompositionAlgorithm:IDecompositionAlgorithm
    {
        private readonly List<Cassete> _decomposition =  new List<Cassete>();
        private List<Cassete> _listCassete;
        private uint _sum;
        public State State { get; private set; }

        public void StartAlgorithm(List<Cassete> listCassete, uint sum)
        {
            _listCassete = listCassete;
            State = State.CombinationFailed;
            _decomposition.Clear();
            _sum = sum;
            Algorithm( 0, 0); 
        }

        private void Algorithm(uint ourSum,int i)
        {
            for (; i < _listCassete.Count; i++)
            {
                if (_sum - ourSum >= _listCassete[i].Nominal && _listCassete[i].Count != 0 && State != State.AllOk)
                {
                    RecAlgorithm(ourSum,i);
                }                
            }
            if (_decomposition.Count == 0) State = State.CombinationFailed;
        }
        private void RecAlgorithm( uint ourSum,int i)
        {
            for (; i < _listCassete.Count; i++)
            {
                int fi = _decomposition.FindIndex(m => m.Nominal == _listCassete[i].Nominal);
                if (fi < 0 || (_decomposition[fi].Count != _listCassete[i].Count))
                {
                    if (_sum - ourSum >= _listCassete[i].Nominal && _listCassete[i].Count != 0)
                    {
                        if (fi >= 0 && (_decomposition[fi].Count != _listCassete[i].Count))
                        {
                            _decomposition[fi].Count++;
                            ourSum += _listCassete[i].Nominal;
                        }
                        else
                        {
                            Cassete m = new Cassete();
                            m.Nominal = _listCassete[i].Nominal;
                            m.Count = 1;
                            _decomposition.Add(m);
                            ourSum += _listCassete[i].Nominal;
                        }


                        var a = i;
                        if (_sum == ourSum)
                        {
                            State = State.AllOk;
                        }
                        else RecAlgorithm(ourSum, i);
                        if (State == State.AllOk) break;

                        i = a;

                        _decomposition[_decomposition.Count - 1].Count--;
                        if (_decomposition[_decomposition.Count - 1].Count == 0)
                        {
                            _decomposition.RemoveAt(_decomposition.Count - 1);
                        }
                        ourSum -= _listCassete[i].Nominal;
                    }
                }
            }
        }

        public List<Cassete> OutMoney()
        {
            return _decomposition;
        }
    }
}
