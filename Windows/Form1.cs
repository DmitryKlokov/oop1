using System;
using System.Windows.Forms;
using log4net;
using oop;
using System.Reflection;
using System.Globalization;
using System.Linq;
using System.Resources;

namespace Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
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

        public static readonly ILog Log = LogManager.GetLogger(typeof(Form1));

        readonly Atm _atm = new Atm();
        private Statistic _stat;
        private uint _sum;
        private void Form1_Load(object sender, EventArgs e)
        {
            log4net.Config.DOMConfigurator.Configure();
            Log.Info("<<Begin program>>");
            try
            {
                LoadCassete(_atm);
                _stat = new Statistic {CountMoneyLoad = _atm.TotalSum};
            }
            catch (Exception exp)
            {
                Log.Fatal(exp.Message);
            }
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            _sum = Convert.ToUInt32(textBox_InputSum.Text);
            _atm.OutMoney(_sum);
            richTextBox1.Text = String.Empty;
            if (_atm.State == State.AllOk)
            {
                foreach (Cassete m in _atm.Decomposition)
                {
                    richTextBox1.Text += @"Номинал: " + m.Nominal + @" кол " + m.Count+ @"
";
                }
            }
            else
            {
                richTextBox1.Text += _atm.State.ToString();
            }
            textBox_InputSum.Text = String.Empty;
        }


        private void GetName(CultureInfo c)
        {
            Assembly ass = Assembly.Load("Windows");
            ResourceManager rm = new ResourceManager("Windows.Lang.Lang",ass);
            button_Enter.Text = rm.GetString("Enter", c);
            button_Correction.Text = rm.GetString("Correction", c);
            button_Cancel.Text = rm.GetString("Cancel", c);
            button_Clear.Text = rm.GetString("Clear", c);
            button_Back.Text = rm.GetString("Back", c);
            button_stat.Text = rm.GetString("Statistics", c);
            label_stat.Text = rm.GetString("LabelStat", c);
            label_load.Text = rm.GetString("LabelLoaded", c);
            label_unloaded.Text = rm.GetString("LabelUnloaded", c);
        }

        private void buttonLangEn_Click(object sender, EventArgs e)
        {
            CultureInfo c = new CultureInfo("en-US");
            GetName(c);
        }

        private void buttonLangRu_Click(object sender, EventArgs e)
        {
            CultureInfo c = new CultureInfo("ru-RU");
            GetName(c);
        }

        private void button_stat_Click(object sender, EventArgs e)
        {
            switch (panel1.Visible)
            {
                case true:
                {
                    panel1.Visible = false;
                    break;
                }
                case false:
                {
                    _stat.CountMoneyOut = _stat.CountMoneyLoad - _atm.TotalSum;
                    textBox_Load.Text = _stat.CountMoneyLoad.ToString();
                    textBox_Out.Text = _stat.CountMoneyOut.ToString();
                    panel1.Visible = true;
                    break;
                }
            }
        }

        private void button_Num1_Click(object sender, EventArgs e)
        {
            textBox_InputSum.Text += @"1";
        }
        private void button_Num2_Click(object sender, EventArgs e)
        {
            textBox_InputSum.Text += @"2";
        }
        private void button_Num3_Click(object sender, EventArgs e)
        {
            textBox_InputSum.Text += @"3";
        }
        private void button_Num4_Click(object sender, EventArgs e)
        {
            textBox_InputSum.Text += @"4";
        }
        private void button_Num5_Click(object sender, EventArgs e)
        {
            textBox_InputSum.Text += @"5";
        }
        private void button_Num6_Click(object sender, EventArgs e)
        {
            textBox_InputSum.Text += @"6";
        }
        private void button_Num7_Click(object sender, EventArgs e)
        {
            textBox_InputSum.Text += @"7";
        }
        private void button_Num8_Click(object sender, EventArgs e)
        {
            textBox_InputSum.Text += @"8";
        }
        private void button_Num9_Click(object sender, EventArgs e)
        {
            textBox_InputSum.Text += @"9";
        }
        private void button_Num0_Click(object sender, EventArgs e)
        {
            textBox_InputSum.Text += @"0";
        }

        private void button_Correction_Click(object sender, EventArgs e)
        {
            if (textBox_InputSum.Text.Count() != 0)
            {
                textBox_InputSum.Text = textBox_InputSum.Text.Remove(textBox_InputSum.Text.Count() - 1, 1);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            textBox_InputSum.Text = String.Empty;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = String.Empty;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
