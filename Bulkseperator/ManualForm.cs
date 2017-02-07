using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulkseperator
{
    public partial class ManualForm : Form
    {
        Tank tank1;

        Timer updateTimer;

        public ManualForm(Tank tank)
        {
            InitializeComponent();
            InitTimer();
            tank1 = tank;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox1.Enabled = true;
                updateTimer.Start();
            }
            else
            {
                groupBox1.Enabled = false;
                updateTimer.Stop();
                tank1.ResetManuel();
            }
        }

        private void ManualForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        public void InitTimer()
        {
            updateTimer = new Timer();
            updateTimer.Tick += new EventHandler(pushManualSettings);
            updateTimer.Interval = 50;
        }

        private void pushManualSettings(object sender, EventArgs e)
        {
            //Console.WriteLine((double)pic1trackbar.Value / 100);
            tank1.SetManuel((double)pic1trackbar.Value, (double)lic1trackbar.Value / 100, (double)lic2trackbar.Value / 100, chkLiquid.Checked, chkLiquid.Checked);
        }
    }
}
