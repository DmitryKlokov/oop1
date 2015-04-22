using System;
using System.Collections.Generic;
using log4net;
using log4net.Config;


namespace oop
{
    class Program
    { 

        static private void LoadCassete(ATM atm)
        {
            CassetesLoader cl = new CassetesLoader();
            cl.Load("Money.txt");
            if (cl.state == State.AllOK)
            {
                atm.listCassete = cl.LoadingCassete();
                atm.state = State.AllOK;
            }
            else
            {
                atm.state = State.NoCassete;
            } 
        }

        public static readonly ILog log = LogManager.GetLogger(typeof(CassetesLoader));

        static private void InputSum(Out oUt,ref uint sum)
        {
            while (true)
            {
                oUt.ShowString("Input sum: ");
                try
                {
                    sum = uint.Parse(oUt.ReadStr());
                    log.Debug("Input sum: " + sum);
                    break;
                }
                catch
                {
                    oUt.ShowString("Incorrect input\n\n");
                    log.Warn("Incorrect input");
                }
            }
        }        

        static void Main(string[] args)
        {
            log4net.Config.DOMConfigurator.Configure();
            log.Info("<<Begin program>>");
            try
            {
                ATM atm = new ATM();
                Out oUt = new Out();

                LoadCassete(atm);
                uint sum = 0;
                while (true)
                {
                    InputSum(oUt, ref sum);
                    atm.outMoney(sum);
                    if (atm.state == State.AllOK)
                    {
                        oUt.ShowListOnConsole(atm.decomposition);
                    }
                    else
                    {
                        oUt.ShowString(atm.state.ToString());
                    }
                    oUt.ShowString("\n");
                }
            }
            catch (Exception e)
            {
                log.Fatal(e.Message);
            }
        }
    }
}
