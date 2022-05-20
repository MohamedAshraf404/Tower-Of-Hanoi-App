using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace towers_of_hanoi
{
    class sticks:Button
    {
        public sticks(int width ,int hight )
        {
            this.Width = width;
            this.Height = hight;
            this.Enabled = false;
            this.BackColor = Color.BlueViolet;
        }


    }
}
