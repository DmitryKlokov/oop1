using System;
using log4net;
using oop;

namespace ConsoleUI
{
    internal class Program
    {

        private static void LoadCassete(Atm atm)
        {
            CassetesLoader cl = new CassetesLoader();
            cl.Load("Money.txt");
            if (cl.State == State.AllOk)
            {
                atm.ListCassete = cl.LoadingCassete();
                atm.State = State.AllOk;
            }
            else
            {
                atm.State = State.NoCassete;
            }
        }

        public static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        private static void InputSum(Out oUt, ref uint sum)
        {
            while (true)
            {
                oUt.ShowString("Input sum: ");
                try
                {
                    sum = uint.Parse(oUt.ReadStr());
                    Log.Debug("Input sum: " + sum);
                    break;
                }
                catch
                {
                    oUt.ShowString("Incorrect input\n\n");
                    Log.Warn("Incorrect input");
                }
            }
        }

        private static void Main()
        {
            log4net.Config.DOMConfigurator.Configure();
            Log.Info("<<Begin program>>");
            try
            {
                Atm atm = new Atm();
                Out oUt = new Out();

                LoadCassete(atm);
                uint sum = 0;
                while (true)
                {
                    InputSum(oUt, ref sum);
                    atm.OutMoney(sum);
                    if (atm.State == State.AllOk)
                    {
                        oUt.ShowListOnConsole(atm.Decomposition);
                    }
                    else
                    {
                        oUt.ShowString(atm.State.ToString());
                    }
                    oUt.ShowString("\n");
                }
            }
            catch (Exception e)
            {
                Log.Fatal(e.Message);
            }
        }
    }
}
