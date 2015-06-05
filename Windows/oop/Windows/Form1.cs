using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using log4net;
using log4net.Config;
using oop;
using oop.Input;
using oop.Output;

namespace Windows
{
    public partial class GuiAtm : Form
    {
        public GuiAtm()
        {
            InitializeComponent();
            IDecompositionAlgorithm algorithm = new DecompositionAlgorithm();
            _atm = new Atm(algorithm);
        }
        private void LoadCassete(Atm atm)
        {
            CassetesLoader cl = new CassetesLoader();
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = @"Cassettes|*.txt;*.json;*.csv;*.xml|All files (*.*)|*.**"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String myStream;
                    if ((myStream = openFileDialog1.FileName) != null)
                    {

                        cl.Load(myStream);
                    }
                }
                catch
                {
                    MessageBox.Show(_rm.GetString("FailedInput", CultureInfo.CurrentCulture));
                }
            }
        
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

        public static readonly ILog Log = LogManager.GetLogger(typeof(GuiAtm));

        readonly Atm _atm;
        private uint _sum;
        private void Form1_Load(object sender, EventArgs e)
        {
            DOMConfigurator.Configure();
            Log.Info("<<Begin program>>");
            _atm.ReadState();
            textBox_maxsum.Text = _atm.TotalSum.ToString();
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            _sum = textBox_InputSum.Text.Length == 0 ? 0 : Convert.ToUInt32(textBox_InputSum.Text);
            _atm.OutMoney(_sum);
            dataGridView1.Rows.Clear();
            if (_atm.State == State.AllOk)
            {
                foreach (Cassete m in _atm.Decomposition)
                {
                    dataGridView1.Rows.Add(m.Nominal, m.Count);
                }
                textBox_maxsum.Text = _atm.TotalSum.ToString();
            }
            else
            {
                MessageBox.Show( _atm.State.ToString(),@"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox_InputSum.Text = String.Empty;
            dataGridView1.ClearSelection();
        }


        readonly ResourceManager _rm = new ResourceManager("Windows.Lang.Lang", Ass);
       static readonly Assembly Ass = Assembly.Load("Windows");
        private void GetName(CultureInfo c)
        {
            button_Enter.Text = _rm.GetString("Enter", c);
            button_Correction.Text = _rm.GetString("Correction", c);
            button_Cancel.Text = _rm.GetString("Cancel", c);
            button_Clear.Text = _rm.GetString("Clear", c);
            button_Back.Text = _rm.GetString("Back", c);
            button_stat.Text = _rm.GetString("Statistics", c);
            label_stat.Text = _rm.GetString("LabelStat", c);
            label_load.Text = _rm.GetString("LabelLoaded", c);
            label_unloaded.Text = _rm.GetString("LabelUnloaded", c);
            dataGridView1.Columns[0].HeaderText = _rm.GetString("Value", c);
            dataGridView1.Columns[1].HeaderText = _rm.GetString("Count", c);
            label_Dateload.Text = _rm.GetString("dateload", c);
            label_maxsum.Text = _rm.GetString("MaxSum", c);
            button_Load.Text = _rm.GetString("Load", c);
            dataGridView_sums.Columns[0].HeaderText = _rm.GetString("Sum", c);
            dataGridView_sums.Columns[1].HeaderText = _rm.GetString("Date", c);
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

            dataGridView_sums.Rows.Clear();
            _atm.Stat.CountMoneyOut = _atm.Stat.CountMoneyLoad - _atm.TotalSum;
            textBox_Load.Text = _atm.Stat.CountMoneyLoad.ToString();
            textBox_Out.Text = _atm.Stat.CountMoneyOut.ToString();
            textBox_dateload.Text = _atm.Stat.Date.ToString(CultureInfo.InvariantCulture);
            foreach (OutSum m in _atm.Stat.Sums)
            {
                dataGridView_sums.Rows.Add(m.Sum, m.Date);
            }
             panel1.Visible = true;
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
            dataGridView1.Rows.Clear();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        
        private void button_Load_Click(object sender, EventArgs e)
        {
            try
            {
                LoadCassete(_atm);
                _atm.Stat = new Statistic { CountMoneyLoad = _atm.TotalSum, Date = DateTime.Now };
                dataGridView_sums.Rows.Clear();
                textBox_maxsum.Text = _atm.TotalSum.ToString();
            }
            catch (Exception exp)
            {
                Log.Fatal(exp.Message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _atm.WriteStat();
        }

        private void button_Num1_Click_1(object sender, EventArgs e)
        {
            textBox_InputSum.Text += ((Button) sender).Text;
        }
    }
}
