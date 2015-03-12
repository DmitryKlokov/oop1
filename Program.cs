using System;
using System.Collections.Generic;
using System.IO;

namespace oop
{
    class Program
    {
        public static int max_nominals = 10;
        public static List<Money> list_money;

        public static void InputMoney()
        {
            list_money = new List<Money>();
            try
            {
                StreamReader sr = new StreamReader("Money.txt");            
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    string[] split = line.Split(new char[] { ' ', '\t' });
                    Money m = new Money(uint.Parse(split[0]), uint.Parse(split[1]));
                    list_money.Add(m);
                }
            }
            catch (Exception e) { Console.WriteLine("Ошибка при чтении файла"); }
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
        public static void delete_money(ref List<Money> abc, ref uint a)
        {
            ADD_Money(abc[abc.Count - 1]);//вернули валюту
            a -= abc[abc.Count - 1].nominal;//отняли от нашей суммы
            abc.RemoveAt(abc.Count - 1);//удалили из суммы  
        }
        public static List<Money> get_Nominals(uint money)
        {
            uint sum = 0;
            int index = 0;
            List<Money> abc = new List<Money>();
            while (money != sum)
            {
                if ((money - sum) >= list_money[index].nominal && list_money[index].Count > 0)
                {
                    sum += list_money[index].nominal;
                    abc.Add(new Money(list_money[index].nominal, 1));
                    list_money[index].Count -= 1;
                }
                else
                {
                    if (index == list_money.Count - 1)
                    {
                        while (abc.Count != 0 && abc[abc.Count - 1].nominal == list_money[list_money.Count - 1].nominal)
                        {
                            delete_money(ref abc, ref sum);
                        }
                        if (abc.Count != 0)
                        {

                            index = list_money.FindIndex(m => m.nominal == abc[abc.Count - 1].nominal);//нашли индекс 
                            delete_money(ref abc, ref sum);
                        }
                        else
                        {
                            Console.WriteLine("не могу");
                            return_money(abc);
                            abc.Clear();
                            return abc;
                        }
                    }
                    index++;
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

        public static void Show_Money(List<Money> list)
        {
            foreach (Money m in list)
            {
                Console.WriteLine("Номинал: " + m.nominal + " Количество: " + m.Count);
            }
        }

        static void Main(string[] args)
        {
            InputMoney();
            list_money.Sort((A, B) => B.nominal.CompareTo(A.nominal));
            uint sum = 0;
            while (true)
            {
                Console.WriteLine("Input sum: ");
                try
                {
                     sum= uint.Parse(Console.ReadLine());
                }
                catch { sum = 0; Console.WriteLine("Некорректный ввод "); }
                List<Money> money = get_Nominals(sum);
                Show_Money(money);
                Console.WriteLine("\n\n\n");
            }
        }
    }
}
