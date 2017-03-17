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
using Bulkseperator;

namespace Bulkseperator
{
    public partial class Form1 : Form
    {
        int updatesPerSecond = 10;

        Tank tank;

        SerialForm serialForm1;
        ManualForm manualForm1;

        private Timer mainTimer;

        public Form1()
        {
            InitializeComponent();
            InitTimer();

            // declare new tank with total of 20m3 capacity
            tank = new Tank(serialPort1, 6d, 10d, 4d);

            //set the inputs to the tank in liter/s
            tank.waterInflow = 0;
            tank.oilInflow = 0;
            tank.gasInflow = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            serialForm1 = new SerialForm(serialPort1);
            manualForm1 = new ManualForm(tank);

            DoubleBuffered = true;
            
            oilMixedRect.Text = "";
            oilMixedRect.Size = new Size(0,0);
            oilMixedRect.Location = new Point(0, 0);
            oilMixedRect.BackColor = Color.FromArgb(100, 100, 100, 100);

            oilSeperatedRect.Text = "";
            oilSeperatedRect.Size = new Size(0, 0);
            oilSeperatedRect.Location = new Point(0, 0);
            oilSeperatedRect.BackColor = Color.FromArgb(100, 100, 100, 100);

            waterRect.Text = "";
            waterRect.Size = new Size(0, 0);
            waterRect.Location = new Point(0, 0);
            waterRect.BackColor = Color.FromArgb(100, 40, 40, 250);

        }

        private void mainLoop(object sender, EventArgs e)
        {
            if (!tank.CalculateFlows(updatesPerSecond))
            {
                mainTimer.Stop();
                MessageBox.Show("Biem!");
            }
            tank.UpdatePLC();
            UpdateControls(tank);
            UpdateRectangles(tank);
        }

        public void UpdateRectangles(Tank tank)
        {
            

            int oilMixedPixels = Convert.ToInt32(tank.oilMixContent / tank.mixedCapacity * 203);
            int waterPixels = Convert.ToInt32(tank.waterContent / tank.mixedCapacity * 203);
            int oilSepPixels = Convert.ToInt32(tank.oilSepContent / tank.oilCapacity * 203);

            waterRect.Size = new Size(409, waterPixels);
            waterRect.Location = new Point(149, 258 + (203 - waterPixels));
            waterRect.Invalidate();

            oilMixedRect.Size = new Size(409, oilMixedPixels);
            oilMixedRect.Location = new Point(149, 258 + (203 - oilMixedPixels - waterPixels));
            oilMixedRect.Invalidate();

            oilSeperatedRect.Size = new Size(110, oilSepPixels);
            oilSeperatedRect.Location = new Point(558, 258 + (203 - oilSepPixels));
            oilSeperatedRect.Invalidate();
        }

        public void UpdateControls(Tank tank)
        {

            lic1Bar.ForceValue((int)(tank.waterContent / tank.mixedCapacity * 100));
            lic2Bar.ForceValue((int)(tank.oilSepContent / tank.oilCapacity * 100));
            pic1Bar.ForceValue((int)(tank.gasContent / tank.gasCapacity * 100));

            gasValve.ForceValue((int)(tank.gasOutflow / 255 / 4 * 100));
            waterValve.ForceValue((int)(tank.waterOutflow / 255 / 4 * 100));
            oilValve.ForceValue((int)(tank.oilOutflow / 255 / 4 * 100));
            

            // r/softwaregore
            if (tank.noodKlep) { inputValve.BackColor = Color.Red; } else { inputValve.BackColor = Color.Transparent; }

            if (tank.liquidHH){ liquidHH.BackColor = Color.Red; } else { liquidHH.BackColor = Color.Transparent; }
            if (tank.presureHH){ presureHH.BackColor = Color.Red; } else { presureHH.BackColor = Color.Transparent; }

            if (tank.pic1HA) { pic1HA.BackColor = Color.DarkOrange; } else { pic1HA.BackColor = Color.Transparent; }
            if (tank.pic1LA) { pic1LA.BackColor = Color.DarkOrange; } else { pic1LA.BackColor = Color.Transparent; }
            if (tank.lic1HA) { lic1HA.BackColor = Color.DarkOrange; } else { lic1HA.BackColor = Color.Transparent; }
            if (tank.lic1LA) { lic1LA.BackColor = Color.DarkOrange; } else { lic1LA.BackColor = Color.Transparent; }
            if (tank.lic2HA) { lic2HA.BackColor = Color.DarkOrange; } else { lic2HA.BackColor = Color.Transparent; }
            if (tank.lic2LA) { lic2LA.BackColor = Color.DarkOrange; } else { lic2LA.BackColor = Color.Transparent; }
        }

        public void InitTimer()
        {
            mainTimer = new Timer();
            mainTimer.Tick += new EventHandler(mainLoop);
            mainTimer.Interval = 1000/ updatesPerSecond;
            mainTimer.Start();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] inBuffer = new byte[4];
            if (serialPort1.BytesToRead > 3)
            {
                serialPort1.Read(inBuffer, 0, 4);
                //MessageBox.Show(inBuffer[0].ToString() +" ,"+ inBuffer[1].ToString() + " ," + inBuffer[2].ToString() + " ," + inBuffer[3].ToString());

                //Console.WriteLine(inBuffer[1]);

                tank.gasOutflow = inBuffer[0] * 4;
                tank.oilOutflow = inBuffer[1] * 4;
                tank.waterOutflow = inBuffer[2] * 4;
          

                //Console.WriteLine(tank.oilOutflow);
                tank.noodKlep = Convert.ToBoolean((inBuffer[3] >> 6) & 0x01);
                tank.pic1HA = Convert.ToBoolean((inBuffer[3] >> 5) & 0x01);
                tank.pic1LA = Convert.ToBoolean((inBuffer[3] >> 4) & 0x01);
                tank.lic1HA = Convert.ToBoolean((inBuffer[3] >> 3) & 0x01);
                tank.lic1LA = Convert.ToBoolean((inBuffer[3] >> 2) & 0x01);
                tank.lic2HA = Convert.ToBoolean((inBuffer[3] >> 1) & 0x01);
                tank.lic2LA = Convert.ToBoolean(inBuffer[3] & 0x01);
            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tank.oilInflow = 120;
            tank.waterInflow = 250;
            tank.gasInflow = 0;

        }

        private void cOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialForm1.Show();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            serialForm1.Show();
            manualForm1.Show();
        }

        private void manualControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manualForm1.Show();
        }
    }
}
