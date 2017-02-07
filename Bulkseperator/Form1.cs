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

            if (tank.liquidHH)
            {
                liquidHH.BackColor = Color.Red;
            }
            else
            {
                liquidHH.BackColor = Color.Transparent;
            }
            if (tank.presureHH)
            {
                presureHH.BackColor = Color.Red;
            }
            else
            {
                presureHH.BackColor = Color.Transparent;
            }
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
                MessageBox.Show(inBuffer[0].ToString() +" ,"+ inBuffer[1].ToString() + " ," + inBuffer[2].ToString() + " ," + inBuffer[3].ToString());
            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tank.oilInflow = 1000;
            tank.waterInflow = 500;
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
