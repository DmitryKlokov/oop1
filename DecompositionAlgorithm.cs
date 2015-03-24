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
        public stateAlgorithm state;

        private void Algorithm(List<Cassete> decomposition,uint ourSum,int i)
        {
            for (int k=0; k < listCassete.Count; k++)
            {
                if (sum - ourSum >= listCassete[k].nominal && listCassete[k].Count != 0 && state!=stateAlgorithm.AllOK)
                {
                    recAlgorithm(decomposition,ourSum,k);
                }                
            }
            if (decomposition.Count == 0) state = stateAlgorithm.ErrorSum;
        }

        private void recAlgorithm(List<Cassete> decomposition, uint ourSum,int i)
        {
            int a=0;
            for (; i < listCassete.Count; i++)
            {
                if (sum - ourSum >= listCassete[i].nominal && listCassete[i].Count != 0)
                {
                    decomposition.Add(new Cassete(listCassete[i].nominal, 1));
                    ourSum += listCassete[i].nominal;
                    listCassete[i].Count--;

                    a = i;
                    if (sum == ourSum) { state = stateAlgorithm.AllOK; }
                    else recAlgorithm(decomposition, ourSum,i);
                    if (state == stateAlgorithm.AllOK) break;

                    i = a;
                    decomposition.RemoveAt(decomposition.Count - 1);
                    ourSum -= listCassete[i].nominal;
                    listCassete[i].Count++;
                }
            }
            
            return;
        }

        public List<Cassete> OutMoney()
        {
            return decomposition;
        }
        public DecompositionAlgorithm(List<Cassete> listCassete, uint sum)
        {
            this.listCassete = listCassete;
            this.sum = sum;
            Algorithm(decomposition,0,0);
        }
    }
}
