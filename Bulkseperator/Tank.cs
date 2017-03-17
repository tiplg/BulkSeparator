using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulkseperator
{
    public class Tank
    {
        SerialPort serialport1;

        bool manualControl { get; set; }
        bool forcePresureHH { get; set; }
        bool forceLiquidHH { get; set; }

        // capacity of each tank segment in m3
        public double gasCapacity { get; private set; }
        public double mixedCapacity { get; private set; }
        public double oilCapacity { get; private set; }  

        public double gasContent { get; private set; }
        public double waterContent { get; private set; }
        public double oilMixContent { get; private set; }
        public double oilSepContent { get; private set; }

        // liter per sec 
        public double waterInflow { get; set; }
        public double oilInflow { get; set; }
        public double gasInflow { get; set; }

        // liter per sec
        public double waterOutflow { get; set; }
        public double oilOutflow { get; set; }
        public double gasOutflow { get; set; }

        //noodklep
        public bool noodKlep { get; set; }

        // alarm sensors
        public bool presureHH { get; set; }
        public bool liquidHH { get; set; }

        // incomming alarms
        public bool pic1HA { get; set; }
        public bool pic1LA { get; set; }
        public bool lic1HA { get; set; }
        public bool lic1LA { get; set; }
        public bool lic2HA { get; set; }
        public bool lic2LA { get; set; }

        public Tank(SerialPort serialport1, double gasCapacity, double mixedCapacity, double oilCapacity)
        {
            manualControl = false;

            this.serialport1 = serialport1;
            this.gasCapacity = gasCapacity;
            this.mixedCapacity = mixedCapacity;
            this.oilCapacity = oilCapacity;

            gasContent = 0;
            waterContent = 0;
            oilMixContent = 0;
            oilSepContent = 0;

            waterInflow = 0;
            oilInflow = 0;
            gasInflow = 0;

            noodKlep = false;

            presureHH = false;
            liquidHH = false;

            pic1HA = false;
            pic1LA = false;
            lic1HA = false;
            lic1LA = false; //false;
            lic2HA = false;
            lic2LA = false;
        }

        public bool CalculateFlows(int updatesPerSecond)
        {
            

            if (manualControl)
            {
                liquidHH = forceLiquidHH | oilSepContent / oilCapacity > 0.95d;
                presureHH = forcePresureHH;
     
                return true;
            }

            liquidHH = ((oilSepContent / oilCapacity) > 0.95d);
            presureHH = ((gasContent / gasCapacity) > 0.95d);

            waterContent += (waterInflow - waterOutflow) / updatesPerSecond / 1000;
            oilMixContent += oilInflow / updatesPerSecond / 1000;
            gasContent += (gasInflow - gasOutflow) / updatesPerSecond / 1000;

            double mixedTotal = waterContent + oilMixContent;

            if (mixedTotal > mixedCapacity)
            {
                Console.WriteLine("overflow");

                double overflow = mixedTotal - mixedCapacity;

                if (oilMixContent > overflow)
                {
                    oilMixContent -= overflow;
                    oilSepContent += overflow;
                }
                else
                {
                    oilSepContent += oilMixContent;
                    oilMixContent = 0;
                }
            }

            oilSepContent -= oilOutflow;

            if ((oilSepContent > oilCapacity) || (gasContent > gasCapacity) || (waterContent > mixedCapacity))
            {
                Console.WriteLine("BIEM");
                return false;
            }

            return true;
        }

        public bool UpdatePLC()
        {
            if (serialport1.IsOpen)
            {
                byte[] outBuffer = new byte[4];
                outBuffer[0] = (byte)(gasContent / gasCapacity * 255);
                outBuffer[1] = (byte)(waterContent / mixedCapacity * 255);
                outBuffer[2] = (byte)(oilSepContent / oilCapacity * 255);
                outBuffer[3] = (byte)((liquidHH ? 1 : 0) << 1 | (presureHH ? 1 : 0));
                serialport1.Write(outBuffer, 0, 4);
            }
            
            return true;
        }

        public bool SetManuel(double gasPercent, double waterPercent, double oilPercent, bool forcePresureHH, bool forceLiquidHH)
        {
            manualControl = true;
            this.forceLiquidHH = forceLiquidHH;
            this.forcePresureHH = forcePresureHH;

            waterContent = waterPercent * mixedCapacity;
            oilMixContent = (1 - waterPercent) * mixedCapacity;
            oilSepContent = oilPercent * oilCapacity;
            gasContent = gasPercent * gasCapacity;

            //Console.WriteLine(gasPercent);
            //Console.WriteLine(gasContent);

            return true;
        }

        public void ResetManuel()
        {
            manualControl = false;
            forceLiquidHH = false;
            forcePresureHH = false;

            presureHH = false;
            liquidHH = false;

            gasContent = 0;
            waterContent = 0;
            oilMixContent = 0;
            oilSepContent = 0;

            waterInflow = 0;
            oilInflow = 0;
            gasInflow = 0;

        }

    }
}
