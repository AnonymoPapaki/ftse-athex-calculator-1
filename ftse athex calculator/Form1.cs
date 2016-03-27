using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ftse_athex_calculator
{
    public partial class Form1 : Form
    {
        public readonly double Divisor = 124034530.629652;
        private List<FinMapNode> finmap;
        private Timer feedTimer;
        private List<StockControl> stockControls;

        public Form1()
        {
            feedTimer = new Timer { Interval = 30000, Enabled = false };
            InitializeComponent();
            InitializeStockComponent();
            InitializeFinMap();
            /*
            foreach (var fin in finmap)
            {
                fin.Current.TextChanged += CalcCurrent;
                fin.Target.TextChanged += CalcTarget;
            }
            */
            feedTimer.Tick += FeedTimer_Tick;

           

        }

        private void InitializeStockComponent()
        {
            stockControls = new List<StockControl>();
            stockControls.Add(new StockControl { StockName = "ΒΙΟ", Shares = 46654156.98 });
            stockControls.Add(new StockControl { StockName = "ΕΕΕ", Shares = 198796300.38 });
            stockControls.Add(new StockControl { StockName = "ΕΛΛΑΚΤΩΡ", Shares = 132750984.3283582 });
            stockControls.Add(new StockControl { StockName = "ΑΛΦΑ", Shares = 1367824267.894737, });
            stockControls.Add(new StockControl { StockName = "ΕΤΕ", Shares = 5488290912.663755 });
            stockControls.Add(new StockControl { StockName = "ΕΥΡΩΒ", Shares = 1770658998.704663 });
            stockControls.Add(new StockControl { StockName = "ΓΕΚΤΕΡΝΑ", Shares = 77358410.75949367 });
            stockControls.Add(new StockControl { StockName = "ΜΥΤΙΛ", Shares = 83010261.76470588 });
            stockControls.Add(new StockControl { StockName = "ΛΑΜΔΑ", Shares = 39063669.75 });
            stockControls.Add(new StockControl { StockName = "ΜΠΕΛΑ", Shares = 100684221.6363636 });
            stockControls.Add(new StockControl { StockName = "ΦΦΓΚΡΠ", Shares = 34143587.09302326 });
            stockControls.Add(new StockControl { StockName = "ΕΛΠΕ", Shares = 73352444.19191919 });
            stockControls.Add(new StockControl { StockName = "ΟΠΑΠ", Shares = 210540000 });
            stockControls.Add(new StockControl { StockName = "ΠΕΙΡ", Shares = 6462555622.093023 });
            stockControls.Add(new StockControl { StockName = "ΕΥΔΑΠ", Shares = 41535000 });
            stockControls.Add(new StockControl { StockName = "ΜΟΗ", Shares = 56499319.76987448 });
            stockControls.Add(new StockControl { StockName = "ΔΕΗ", Shares = 106720000 });
            stockControls.Add(new StockControl { StockName = "ΟΛΠ", Shares = 6500000 });
            stockControls.Add(new StockControl { StockName = "ΓΡΙΒ", Shares = 39491400 });
            stockControls.Add(new StockControl { StockName = "ΕΧΑΕ", Shares = 62100134.80769231 });
            stockControls.Add(new StockControl { StockName = "ΑΡΑΙΓ", Shares = 29281010.88082902 });
            stockControls.Add(new StockControl { StockName = "ΤΕΝΕΡΓ", Shares = 41539471.66666667 });
            stockControls.Add(new StockControl { StockName = "ΤΙΤΚ", Shares = 47008776.46464646 });
            stockControls.Add(new StockControl { StockName = "ΟΤΕ", Shares = 245075194.4029851 });
            stockControls.Add(new StockControl { StockName = "ΜΕΤΚ", Shares = 24416781.91330344 });

            flowLayoutPanel.Controls.AddRange(stockControls.ToArray());
            foreach (var ctrl in stockControls)
            {
                ctrl.SnapshotValueChange += CalcSnapshotIndex;
                //chart1.Series[0].Points.Add(new DataPoint { YValues = new double[] { 0 }, LegendText = ctrl.StockName });
            }
        }
        private void CalcSnapshotIndex(object sender, EventArgs e)
        {
            tbTarFTSE.Text = stockControls.Sum(x => x.SnapshotIndexValue).ToString();
        }

        private void CalcCurrent(object sender, EventArgs e)
        {
            try {
                tbCurFTSE.Text = finmap.Sum(x => (x.Shares * double.Parse(x.Current.Text)) / Divisor).ToString();
            }
            catch (Exception) { }
        }
        private void CalcTarget(object sender, EventArgs e)
        {
            try {
                tbTarFTSE.Text = finmap.Sum(x => (x.Shares * double.Parse(x.Target.Text)) / Divisor).ToString();
            }
            catch (Exception) { }
        }
        private async void FeedTimer_Tick(object sender, EventArgs e)
        {
          
            using (var wc = new WebClient())
            {
                try
                {
                    wc.Encoding = Encoding.UTF8;
                    var data = await wc.DownloadStringTaskAsync("http://www.naftemporiki.gr/finance/Data/GetTickerFeed.ashx");
                    foreach (var record in data.Split('|'))
                    {
                        var row = record.Split('~');
                        var elem = stockControls.Where(x => x.StockName == row[0]);
                        if (elem.Count() == 0)
                            continue;
                        elem.First().StockCurrentValue = double.Parse(row[2]);
                    }
                    //recalc index
                    tbCurFTSE.Text = stockControls.Sum(x => x.CurrentIndexValue).ToString();
                    //append pie

                    chart1.Series[0].Points.Clear();
                    foreach (var ctrl in stockControls)
                    {
                        if (ctrl.CurrentIndexValue > 3.0)
                            chart1.Series[0].Points.Add(new DataPoint { YValues = new double[] { ctrl.CurrentIndexValue }, LegendText = ctrl.StockName });
                    }
                    

                }
                catch (IndexOutOfRangeException)
                { }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void InitializeFinMap()
        {
            /*
            finmap = new List<FinMapNode>();
            finmap.Add(new FinMapNode { Name = "ΒΙΟ", Shares = 46654156.98, Current = tbCurVio, Target = tbTarVio });
            finmap.Add(new FinMapNode { Name = "ΕΕΕ", Shares = 198796300.38, Current = tbCurEEE, Target = tbTarEEE });
            finmap.Add(new FinMapNode { Name = "ΕΛΛΑΚΤΩΡ", Shares = 132750984.3283582, Current = tbCurELLAKTWR, Target = tbTarELLAKTWR });
            finmap.Add(new FinMapNode { Name = "ΑΛΦΑ", Shares = 1367824267.894737, Current = tbCurALPHA, Target = tbTarALPHA });
            finmap.Add(new FinMapNode { Name = "ΕΤΕ", Shares = 5488290912.663755, Current = tbCurETE, Target = tbTarETE });
            finmap.Add(new FinMapNode { Name = "ΕΥΡΩΒ", Shares = 1770658998.704663, Current = tbCurEUROB, Target = tbTarEUROB });
            finmap.Add(new FinMapNode { Name = "ΓΕΚΤΕΡΝΑ", Shares = 77358410.75949367, Current = tbCurGEKTERN, Target = tbTarGEKTERNA });
            finmap.Add(new FinMapNode { Name = "ΜΥΤΙΛ", Shares = 83010261.76470588, Current = tbCurMYTIL, Target = tbTarMYTIL });
            finmap.Add(new FinMapNode { Name = "ΛΑΜΔΑ", Shares = 39063669.75, Current = tbCurLAMDA, Target = tbTarLAMBDA });
            finmap.Add(new FinMapNode { Name = "ΜΠΕΛΑ", Shares = 100684221.6363636, Current = tbCurMPELA, Target = tbTarMPELA });
            finmap.Add(new FinMapNode { Name = "ΦΦΓΚΡΠ", Shares = 34143587.09302326, Current = tbCurFFGKRP, Target = tbTarFFGKRP });
            finmap.Add(new FinMapNode { Name = "ΕΛΠΕ", Shares = 73352444.19191919, Current = tbCurELPE, Target = tbTarELPE });
            finmap.Add(new FinMapNode { Name = "ΟΠΑΠ", Shares = 210540000, Current = tbCurOPAP, Target = tbTarOPAP });
            finmap.Add(new FinMapNode { Name = "ΠΕΙΡ", Shares = 6462555622.093023, Current = tbCurPEIR, Target = tbTarPEIR });
            finmap.Add(new FinMapNode { Name = "ΕΥΔΑΠ", Shares = 41535000, Current = tbCurEYDAP, Target = tbTarEYDAP });
            finmap.Add(new FinMapNode { Name = "ΜΟΗ", Shares = 56499319.76987448, Current = tbCurMOH, Target = tbTarMOH });
            finmap.Add(new FinMapNode { Name = "ΔΕΗ", Shares = 106720000, Current = tbCurDEH, Target = tbTarDEH });
            finmap.Add(new FinMapNode { Name = "ΟΛΠ", Shares = 6500000, Current = tbCurOLP, Target = tbTarOLP });
            finmap.Add(new FinMapNode { Name = "ΓΡΙΒ", Shares = 39491400, Current = tbCurGRIV, Target = tbTarGRIV });
            finmap.Add(new FinMapNode { Name = "ΕΧΑΕ", Shares = 62100134.80769231, Current = tbCurEXAE, Target = tbTarEXAE });
            finmap.Add(new FinMapNode { Name = "ΑΡΑΙΓ", Shares = 29281010.88082902, Current = tbCurARAIG, Target = tbTarARAIG });
            finmap.Add(new FinMapNode { Name = "ΤΕΝΕΡΓ", Shares = 41539471.66666667, Current = tbCurTENERG, Target = tbTarTENERG });
            finmap.Add(new FinMapNode { Name = "ΤΙΤΚ", Shares = 47008776.46464646, Current = tbCurTITK, Target = tbTarTITK });
            finmap.Add(new FinMapNode { Name = "ΟΤΕ", Shares = 245075194.4029851, Current = tbCurOTE, Target = tbTarOTE });
            finmap.Add(new FinMapNode { Name = "ΜΕΤΚ", Shares = 24416781.91330344, Current = tbCurMETK, Target = tbTarMETK });
            */
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            feedTimer.Enabled = checkBox1.Checked;
            if (feedTimer.Enabled)
                FeedTimer_Tick(this, new EventArgs());
        }

        private void btResetTarget_Click(object sender, EventArgs e)
        {
            foreach (var fin in finmap)
            {
                fin.Target.Text = fin.Current.Text;
            }
        }

        private void Banks_click(object sender, EventArgs e)
        {
            try
            {
                var val = double.Parse((sender as Button).Text.Replace('%',' ')) / 100;
                foreach( var obj in finmap.Where(x => new string[] { "ΕΤΕ", "ΕΥΡΩΒ", "ΠΕΙΡ", "ΑΛΦΑ" }.Contains(x.Name)))
                {
                    obj.Target.Text = (double.Parse(obj.Current.Text) + (double.Parse(obj.Current.Text) * val)).ToString();
                }
                
            }
            catch (Exception) { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTakeSnapshot_Click(object sender, EventArgs e)
        {
            stockControls.ForEach(x => x.TakeSnapshot());
            tbTarFTSE.Text = stockControls.Sum(x => x.SnapshotIndexValue).ToString();
        }
    }
    class FinMapNode
    {
        public string Name { get; set; }
        public double Shares { get; set; }
        public TextBox Current { get; set; }
        public TextBox Target { get; set; }
    }
}
