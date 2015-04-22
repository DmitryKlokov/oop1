using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class DecompositionAlgorithm
    {
        private List<Cassete> decomposition =  new List<Cassete>();
        private List<Cassete> listCassete;
        private uint sum;
        public State state;

        public void StartAlgorithm(List<Cassete> listCassete, uint sum)
        {
            this.listCassete = listCassete;
            this.sum = sum;
            Algorithm(decomposition, 0, 0); 
        }

        private void Algorithm(List<Cassete> decomposition,uint ourSum,int i)
        {
            for (; i < listCassete.Count; i++)
            {
                if (sum - ourSum >= listCassete[i].nominal && listCassete[i].Count != 0 && state != State.AllOK)
                {
                    recAlgorithm(decomposition,ourSum,i);
                }                
            }
            if (decomposition.Count == 0) state = State.CombinationFailed;
        }
        private void recAlgorithm(List<Cassete> decomposition, uint ourSum,int i)
        {
            int a=0;
            for (; i < listCassete.Count; i++)
            {
                if (sum - ourSum >= listCassete[i].nominal && listCassete[i].Count != 0)
                {
                    int fi = decomposition.FindIndex(m=>m.nominal==listCassete[i].nominal);
                    if (fi > 0 && (decomposition[fi].Count != listCassete[i].Count))
                    {
                        decomposition[fi].Count++;
                        ourSum += listCassete[i].nominal;
                    }
                    else
                    {
                        decomposition.Add(new Cassete(listCassete[i].nominal, 1));
                        ourSum += listCassete[i].nominal;
                    }
                    

                    a = i;
                    if (sum == ourSum) { state = State.AllOK; }
                    else recAlgorithm(decomposition, ourSum,i);
                    if (state == State.AllOK) break;

                    i = a;

                    decomposition[decomposition.Count - 1].Count--;
                    if (decomposition[decomposition.Count - 1].Count == 0)
                    {
                        decomposition.RemoveAt(decomposition.Count - 1);
                    }
                    ourSum -= listCassete[i].nominal;
                }
            }
            
            return;
        }

        public List<Cassete> OutMoney()
        {
            return decomposition;
        }
    }
}
