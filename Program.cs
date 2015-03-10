using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace oop_1
{
    public class Program
    {
        public static int max_nominals=10;
        public static List<Money> list_money;
        public static void InputMoney()
        {
            list_money = new List<Money>();
            StreamReader sr = new StreamReader("Money.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] split = line.Split(new char[] {' ','\t'});
                Money m = new Money(uint.Parse(split[0]), uint.Parse(split[1]));
                list_money.Add(m);
            }
        }
        public static void OutputMoney_on_console()
        {
            foreach (Money m in list_money)
            {
                Console.WriteLine("Номинал: " + m.nominal + " Количество: " + m.Count);
            }
        }
        public static void ADD_Money(Money a)
        {
            list_money[list_money.FindIndex(m => m.nominal == a.nominal)].Count++;
        }
        public static void return_money(List<Money> abc)
        {
            foreach (Money m in abc)
            {
                ADD_Money(m);
            } 
        }
        public static void delete_money(ref List<Money> abc,ref uint a)
        {
             ADD_Money(abc[abc.Count - 1]);//вернули валюту
             a -= abc[abc.Count - 1].nominal;//отняли от нашей суммы
             abc.RemoveAt(abc.Count - 1);//удалили из суммы  
        }

        public static List<Money> get_Nominals(uint money)
        {
            uint a = 0; 
            int i = 0;
            int c = 1;
            List<Money> abc =  new List<Money>();
            while (money != a)
            {
                if ((money - a) >= list_money[i].nominal && list_money[i].Count > 0)
                {
                     a += list_money[i].nominal;
                     abc.Add(new Money(list_money[i].nominal, 1));
                     list_money[i].Count -= 1;
                }
                else
                {
                    i++;
                    if (i == list_money.Count)
                    {
                        if (abc[abc.Count - 1].nominal == list_money[list_money.Count - 1].nominal)
                        {
                            int b = abc.Count;
                            for (int j = b - c; j < b; j++)
                            {
                                i = list_money.FindIndex(m => m.nominal == abc[abc.Count - 1].nominal) + 1;//нашли индекс 
                                delete_money(ref abc, ref a);
                            }
                            c++;
                            if (abc.Count == 0) c = 1;
                            if (i == list_money.Count) i -= 1;
                        }
                        else 
                        {
                            i = list_money.FindIndex(m => m.nominal == abc[abc.Count - 1].nominal) + 1;//нашли индекс 
                            delete_money(ref abc, ref a);
                        }
                    }
                }
            }
            if (abc.Count > max_nominals)
            {
                Console.WriteLine("Много купюр");
                return_money(abc);
                abc.Clear();
            }
            return abc;
        }
        static void Main(string[] args)
        {
            
                InputMoney();
                list_money.Sort((A, B) => B.nominal.CompareTo(A.nominal));
                while (true)
                {
                OutputMoney_on_console();
                Console.WriteLine("Введите сумму: ");
                uint sum = uint.Parse(Console.ReadLine());
                List<Money> a = get_Nominals(sum);
                foreach (Money m in a)
                {
                    Console.WriteLine(m.nominal);
                }
            }
            
        }
    }
}
