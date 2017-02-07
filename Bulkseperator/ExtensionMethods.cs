using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Bulkseperator
{
    public static class ExtensionMethods
    {
        public static bool ForceValue(this ProgressBar p, int value)
        {
            if (value > p.Maximum) return false;
            if (value < p.Minimum) return false;

            p.Value = value;
            if(value != p.Minimum) p.Value = value - 1;
            p.Value = value;
           
            return true;
        }
    }
}
