using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ftse_athex_calculator
{
    public partial class StockControl : UserControl
    {
        private bool ignoreSnapshotEvent;
        public StockControl()
        {
            InitializeComponent();
            Divisor = 124034530.629652;
            ignoreSnapshotEvent = false;
        }
        
        public void TakeSnapshot()
        {
            ignoreSnapshotEvent = true;
            tbSnapshot.Text = tbCurrent.Text;
            ignoreSnapshotEvent = false;
        }


        //porps
        [Category("Other")]
        [DefaultValue(124034530.629652)]
        public double Divisor { get; set; }
        [Category("Other")]
        public string StockName
        {
            get { return lbText.Text; }
            set { lbText.Text = value; }
        }
        [Category("Other")]
        public double Shares { get; set; }
        public double StockCurrentValue
        {
            get { return DoubleOrZero(tbCurrent.Text); }
            set { tbCurrent.Text = value.ToString(); }
        }
        public double StockSnapshotValue
        {
            get { return DoubleOrZero(tbSnapshot.Text); }
            set { tbSnapshot.Text = value.ToString(); }
        }
        public double CurrentIndexValue
        {
            get
            {
                return (DoubleOrZero(tbCurrent.Text) * Shares) / Divisor;
            }
        }
        public double SnapshotIndexValue
        {
            get
            {
                return (DoubleOrZero(tbSnapshot.Text) * Shares) / Divisor;
            }
        }

        [Category("Events")]
        public event Action<object, EventArgs> CurrentValueChange;
        [Category("Events")]
        public event Action<object, EventArgs> SnapshotValueChange;


        private double DoubleOrZero(string s)
        {
            double ret = 0;
            double.TryParse(s, out ret);
            return ret;
        }
        
        private void CalcIndexValueDiff()
        {
            tbIndexValueDiff.Text = (SnapshotIndexValue - CurrentIndexValue).ToString();
        }

        private void tbSnapshot_TextChanged(object sender, EventArgs e)
        {
            if (SnapshotValueChange != null
                && !ignoreSnapshotEvent)
                SnapshotValueChange(this, new EventArgs());
            CalcIndexValueDiff();
        }

        private void tbCurrent_TextChanged(object sender, EventArgs e)
        {
            if (CurrentValueChange != null)
                CurrentValueChange(this, new EventArgs());
            CalcIndexValueDiff();
        }
    }
}
