using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace towers_of_hanoi
{
    public partial class Form1 : Form
    {
        int XAbs, YAbs;
        int WidthPlates, heightplates, widthSticks, heightSticks;
        int nofromPlates;
        int decrementValue;
        sticks[] sticksTowers = new sticks[6];
        plate[] plates;
        Tower[] towers = new Tower[3];
        int stickslocation;
        plate platetmp;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
            
        }

        

        // initialize
        public Form1()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            XAbs = 85;
            YAbs = 400;
            WidthPlates = 400;
            widthSticks = WidthPlates;
            heightplates = 50;
            heightSticks = 49;
            nofromPlates = 3;
            decrementValue = 50;
            plates = new plate[nofromPlates];
            for (int i = 0; i < 3; i++)
            {
                towers[i] = new Tower(nofromPlates);
            }
            generateSticks();
            generatePlates();


        }

        void generateSticks()
        {
            stickslocation = YAbs - 45;
            for (int i = 0; i < 3; i++)
            {
                sticksTowers[i] = new sticks(widthSticks, heightSticks);
                this.Controls.Add(sticksTowers[i]);
                sticksTowers[i].Location = new Point(XAbs + (widthSticks + 100) * i, YAbs + (heightplates * nofromPlates + 50));


                sticksTowers[6 - i - 1] = new sticks(25, heightSticks * nofromPlates + 50);
                this.Controls.Add(sticksTowers[6 - i - 1]);
                sticksTowers[6 - i - 1].Location = new Point((XAbs + (widthSticks + 100) * i) + widthSticks / 2 - (25 / 2), YAbs + 15);
                sticksTowers[i].SendToBack();
                sticksTowers[6 - i - 1].SendToBack();

            }
        }
        void generatePlates()
        {
            for (int i = 0; i < nofromPlates; i++)
            {
               
                plates[i] = new plate(WidthPlates - (decrementValue * 2) * (nofromPlates - i), heightplates, i+1, sticksTowers[0].Left, sticksTowers[1].Left, sticksTowers[2].Left, WidthPlates,towers,widthSticks, YAbs + (heightplates * nofromPlates + 50),this.txtnoofmovements,nofromPlates);
                this.Controls.Add(plates[i]);
                plates[i].T = towers[0];
                plates[i].Location = new Point(XAbs + (decrementValue) * (nofromPlates - i), YAbs + ((i + 1) * heightplates));
                plates[i].BringToFront();

            }
            for (int i = 0; i < nofromPlates; i++)
            {
                towers[0].AddPlate(plates[nofromPlates - i - 1]);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            recursion(0,1,2,nofromPlates);
            MessageBox.Show(" END GAME ");
            Form1 frm2 = new Form1();
            frm2.ShowDialog();

        }
        void platesmover(int towerorigen,int towerdistination)
        {
            platetmp = towers[towerorigen].lastestelement();
            for (int i = platetmp.Top ; i > stickslocation ; i--)
            {
                platetmp.Top = i;
                platetmp.Refresh();
                sticksTowers[towerorigen+3].Refresh();
                sticksTowers[towerdistination + 3].Refresh();


            }
            if (towerorigen < towerdistination)
            {
                for (int i = platetmp.Left; i < ((XAbs + (widthSticks + 100) * towerdistination) + widthSticks / 2 - (platetmp.Width / 2)); i++)
                {
                    platetmp.Left = i;
                    platetmp.Refresh();
                }
            }
            else
            {
                for (int i = platetmp.Left; i > ((XAbs + (widthSticks + 100) * towerdistination) + widthSticks / 2 - (platetmp.Width / 2)); i--)
                {
                    platetmp.Left = i;
                    platetmp.Refresh();
                    
                }
            }
            
            for (int i = platetmp.Top; i < YAbs + (heightplates * (nofromPlates-towers[towerdistination].noelementes) + 1); i++)
            {
                platetmp.Top = i;
                platetmp.Refresh();
                sticksTowers[towerorigen + 3].Refresh();
                sticksTowers[towerdistination+3].Refresh();
            }
            platetmp.changetower(towers[towerdistination],towers[towerorigen]);
        }
        void recursion(int origen,int assistant,int distination, int amountofplates)
        {
            if (amountofplates == 1)
            {
                platesmover( origen, distination);
            }
            else
            {
                recursion(origen, distination, assistant, amountofplates - 1);
                platesmover( origen, distination);
                recursion(assistant, origen, distination, amountofplates - 1);
            }
        }

    }
}
