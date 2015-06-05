using System.Collections.Generic;
using System.IO;
using log4net;

namespace oop.Input
{
    public class CassetesLoader
    {
        private List<Cassete> _listCassete;        

        public State State;

        public static readonly ILog Log = LogManager.GetLogger(typeof(CassetesLoader));

        public void Load(string address)
        {
            Log.Info("Try load cassetes"); 
            State = State.Error;
                switch (Path.GetExtension(address))
                {
                    case ".txt":
                    {
                        IReader rt = new ReaderTxt();
                        _listCassete = rt.Read(address);
                        break;
                    }
                    case ".csv":
                    {

                        IReader rt = new ReaderCsv();
                        _listCassete = rt.Read(address);
                        break;
                    }
                    case ".xml":
                    {
                        IReader rt = new ReaderXml();
                        _listCassete = rt.Read(address);
                        break;
                    }
                    case ".json":
                    {
                        IReader rt = new ReaderJson();
                        _listCassete = rt.Read(address);
                        break;
                    }
                }
                if (_listCassete.Count == 0) 
                { 
                    State = State.NoCassete;
                    Log.Error(State);
                }
                else 
                { 
                    State = State.AllOk;
                    Log.Info(State); 
                }
                
            }

        



        public List<Cassete> LoadingCassete()
        {
            _listCassete.Sort((a, b) => b.Nominal.CompareTo(a.Nominal));
            return _listCassete;
        }
    }
}
