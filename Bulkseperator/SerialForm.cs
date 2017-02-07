using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulkseperator
{
    public partial class SerialForm : Form
    {
        SerialPort serialport1;

        public SerialForm(SerialPort serialport)
        {
            InitializeComponent();
            serialport1 = serialport;
        }

        private void SerialForm_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cboPorts.Items.AddRange(ports);
            btnDisconnect.Enabled = false;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            cboPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cboPorts.Items.AddRange(ports);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            cboPorts.Enabled = false;
            btnScan.Enabled = false;

            try
            {
                serialport1.PortName = cboPorts.Text;
                serialport1.Open();
                Hide();
            }
            catch (Exception ex)
            {
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                cboPorts.Enabled = true;
                MessageBox.Show(ex.Message, "Not so helpful error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            cboPorts.Enabled = true;
            btnScan.Enabled = true;

            try
            {
                serialport1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Not so helpful error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SerialForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
