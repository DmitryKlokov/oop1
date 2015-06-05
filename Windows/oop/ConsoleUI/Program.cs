using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using log4net;
using log4net.Config;
using oop;
using oop.Input;
using oop.Output;

namespace ConsoleUI
{
    internal class Program
    {

        private static void LoadCassete()
        {
            CassetesLoader cl = new CassetesLoader();
            oUt.ShowString(Rm.GetString("FileName", C)+": ");
            cl.Load(oUt.ReadStr());
            if (cl.State == State.AllOk)
            {
                _atm.ListCassete = cl.LoadingCassete();
                _atm.State = State.AllOk;
            }
            else
            {
                _atm.State = State.NoCassete;
            }
            _atm.Stat = new Statistic { CountMoneyLoad = _atm.TotalSum, Date = DateTime.Now };
        }

        public static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        public static readonly Assembly Ass = Assembly.Load("ConsoleUI");

        public static readonly ResourceManager Rm = new ResourceManager("ConsoleUI.Lang.Lang", Ass);
        public static  CultureInfo C = new CultureInfo("en-US");

        private static void InputSum()
        {
            while (true)
            {
                oUt.ShowString(Rm.GetString("Input sum", C)+": ");
                try
                {
                    var str = oUt.ReadStr();
                    _sum = uint.Parse(str);
                    Log.Debug("Input sum: " + _sum);
                    break;
                }
                catch
                {
                    oUt.ShowString(Rm.GetString("Incorrect input", C));
                    Log.Warn("Incorrect input");
                }
            }
        }

        private static void ChangeLang()
        {
            oUt.ShowString("en,ru:");
            switch (oUt.ReadStr())
            {
                case"ru":
                {
                    C = new CultureInfo("ru-RU");
                    break;
                }
                case "en":
                {
                    C = new CultureInfo("en-US");
                    break;
                }
                default:
                {
                    oUt.ShowString(Rm.GetString("Incorrect input", C));
                    break;
                }
            }
        }

        delegate void Del();

        private static void TakeMoney()
        {
            InputSum();
            _atm.OutMoney(_sum);
            if (_atm.State == State.AllOk)
            {
                oUt.ShowListOnConsole(_atm.Decomposition);
            }
            else
            {
                oUt.ShowString(_atm.State.ToString());
            }
        }

        private static void Help()
        {
            oUt.ShowString("cl-"+ Rm.GetString("Change language", C) + "\n" + "tm-" + Rm.GetString("Take money", C) + "\n" + "lc-" +Rm.GetString("Load cassets", C) + "\n" + "hp-"+Rm.GetString("Help", C) + "\n" +"st-"+ Rm.GetString("Statistic", C) + "\n" +"ex-"+ Rm.GetString("Exit", C) );
        }

        private static void Statistic()
        {
            oUt.ShowString("                <<" + Rm.GetString("Statistic", C) + ">>");
            if (_atm.Stat != null)
            {
                oUt.ShowString("            " + Rm.GetString("Loaded", C) + ": " + _atm.Stat.CountMoneyLoad);
                oUt.ShowString("            " + Rm.GetString("Unloaded", C) + ": " + (_atm.Stat.CountMoneyLoad - _atm.TotalSum));
                oUt.ShowString("            " + Rm.GetString("dateload", C) + ": " + _atm.Stat.Date);
                foreach (OutSum os in _atm.Stat.Sums)
                {
                    oUt.ShowString("            " + os.Sum + ": " + os.Date);
                }
            }
            else
            {
                oUt.ShowString("Null");
            }
        }

        private static void Exit()
        {
            _atm.WriteStat();
            Environment.Exit(0);
        }

        private static void GetFunc(string str)
        {
            if(DC.ContainsKey(str))
            {
                DC[str].DynamicInvoke();
            }
            else
            {
                oUt.ShowString(Rm.GetString("Incorrect input", C) + " ->" + "hp-"+Rm.GetString("Help", C));
            }
        }

        private static Out oUt = new Out();
        private static uint _sum;

        private static Atm _atm;
        private static Dictionary<string,Delegate> DC = new Dictionary<string, Delegate>(); 
        private static void MakeDict()
        {
            DC.Add("tm", new Del(TakeMoney));
            DC.Add("hp", new Del(Help));
            DC.Add("st", new Del(Statistic));
            DC.Add("cl", new Del(ChangeLang));
            DC.Add("lc", new Del(LoadCassete));
            DC.Add("ex", new Del(Exit));
        }

        private static void Main()
        {
            MakeDict();
            DOMConfigurator.Configure();
            IDecompositionAlgorithm algorithm = new DecompositionAlgorithm();
            _atm = new Atm(algorithm);
            Log.Info("<<Begin program>>");
            try
            {
                _atm.ReadState();
                Help();
                oUt.ShowString("\n");
                while (true)
                {
                    string str = oUt.ReadStr();
                    GetFunc(str.ToLower());
                    
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
