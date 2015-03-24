using System;
using System.Collections.Generic;

namespace oop
{
    public class ATM
    {
        List<Cassete> listCassete;
        stateATM st;

        public ATM()
        {
            LoadCassete();
        }

        private void LoadCassete()
        {
            CassetesLoader c = new CassetesLoader("Money.txt");
            if (c.state == stateLoad.AllOK)
            {
                listCassete = c.LoadingCassete();
                st = stateATM.AllOK;
            }
            else
            {
                Console.WriteLine("Error: " + c.state.ToString());
                st = stateATM.NoMoney;
            }
        }
        public void outMoney(uint sum)
        {
            DecompositionAlgorithm da = new DecompositionAlgorithm(listCassete, sum);
            if (da.state == stateAlgorithm.AllOK)
            {
                Show_Money(da.OutMoney());
            }
            else
            {
                Console.WriteLine("Error " + da.state);
            }
        }

        private void Show_Money(List<Cassete> list)
        {
            foreach (Cassete m in list)
            {
                Console.WriteLine("Номинал: " + m.nominal);
            }
        }

    }
}
