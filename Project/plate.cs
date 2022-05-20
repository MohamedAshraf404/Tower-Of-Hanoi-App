using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace towers_of_hanoi
{
    class plate : Button
    {
        Boolean Down;
        public int norange;
        public Tower T;
        public Tower[] Towers;
        int CurrentTower, NewTower;
        int InitialpositionX, InitialpositionY;
        int baseposition1, baseposition2, baseposition3;
        int widthplates;
        int widthbases, BaselocationY;
        Label txtcounter;
        int noplates;
        int minmovements;

        public plate(int width, int hight, int norange, int B1, int B2, int B3, int widthplates, Tower[] TowersarrAngment, int widthbases, int posY, Label txtcounter, int noplates)
        {
            this.Width = width;
            this.Height = hight;
            color(norange);

            baseposition1 = B1;
            baseposition2 = B2;
            baseposition3 = B3;
            Towers = TowersarrAngment;
            CurrentTower = 0;
            minmovements = (int)Math.Pow(2, noplates) - 1;
            NewTower = 0;
            this.norange = norange;
            this.widthbases = widthbases;
            this.BaselocationY = posY;
            this.noplates = noplates;
            this.txtcounter = txtcounter;
            this.MouseDown += new MouseEventHandler(EventToDown);
            this.MouseUp += new MouseEventHandler(EventToUp);
            this.MouseMove += new MouseEventHandler(EventToMover);
            this.widthplates = widthplates;
            Down = false;
        }
        void color(int norange)
        {
            switch (norange)
            {
                case 1:
                    this.BackColor = Color.Red;
                    break;
                case 2:
                    this.BackColor = Color.Orange;
                    break;
                case 3:
                    this.BackColor = Color.Yellow;
                    break;
                case 4:
                    this.BackColor = Color.Blue;
                    break;
                case 5:
                    this.BackColor = Color.Yellow;
                    break;
                case 6:
                    this.BackColor = Color.Lime;
                    break;
                case 7:
                    this.BackColor = Color.Cyan;
                    break;
                case 8:
                    this.BackColor = Color.AliceBlue;
                    break;
                case 9:
                    this.BackColor = Color.OrangeRed;
                    break;
                case 10:
                    this.BackColor = Color.LightBlue;
                    break;
                default:
                    this.BackColor = Color.Chocolate;
                    break;


            }
        }
        public void AddTower(Tower New)
        {
            T = New;
        }
        public void changetower(Tower New, Tower old)
        {
            T = New;
            New.AddPlate(old.removeplate());


        }

        void EventToDown(object sender, EventArgs e)
        {
            Down = true;
            InitialpositionX = this.Left;
            InitialpositionY = this.Top;

        }
        void EventToUp(object sender, EventArgs e)
        {
            Down = false;
            if (!FindOut())
            {
                this.Left = InitialpositionX;
                this.Top = InitialpositionY;
            }
            else
            {
                if (CurrentTower == 0)
                {
                    this.Left = baseposition1 + widthbases / 2 - this.Width / 2;
                    this.Top = BaselocationY - (Towers[CurrentTower].noelementes * this.Height);
                }
                if (CurrentTower == 1)
                {
                    this.Left = baseposition2 + widthbases / 2 - this.Width / 2;
                    this.Top = BaselocationY - (Towers[CurrentTower].noelementes * this.Height);
                }
                if (CurrentTower == 2)
                {
                    this.Left = baseposition3 + widthbases / 2 - this.Width / 2;
                    this.Top = BaselocationY - (Towers[CurrentTower].noelementes * this.Height);
                }
                this.txtcounter.Text = (int.Parse(txtcounter.Text) + 1) + "";
                checkvictory();
                InitialpositionX = this.Left;
                InitialpositionY = this.Top;

            }
        }

        void checkvictory()
        {
            if (Towers[2].noelementes == noplates)
            {
                MessageBox.Show("You Win The Game");
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
        }


        void EventToMover(object sender, EventArgs e)
        {
            if (Down && T.lastestelement().Equals(this))
            {
                this.Top = MousePosition.Y - this.Height;
                this.Left = MousePosition.X - this.Width / 2;
            }

        }
        bool FindOut()
        {
            bool received = false;
            int nobase = 0;

            if ((this.Left > baseposition1 && this.Left < baseposition1 + widthplates))
            {
                NewTower = 0;

                if (Towers[NewTower].NoFainalRange() >= norange || Towers[NewTower].NoFainalRange() == 0)
                {
                    changetower(Towers[NewTower], T);
                    received = true;
                    CurrentTower = NewTower;
                }


            }

            if ((this.Left > baseposition2 && this.Left < baseposition2 + widthplates))
            {

                NewTower = 1;
                if (Towers[NewTower].NoFainalRange() >= norange || Towers[NewTower].NoFainalRange() == 0)
                {
                    changetower(Towers[NewTower], T);
                    received = true;
                    CurrentTower = NewTower;

                }
            }

            if ((this.Left > baseposition3 && this.Left < baseposition3 + widthplates))
            {


                NewTower = 2;
                if (Towers[NewTower].NoFainalRange() >= norange || Towers[NewTower].NoFainalRange() == 0)
                {
                    changetower(Towers[NewTower], T);
                    received = true;
                    CurrentTower = NewTower;
                }
            }

            return received;
        }



    }
}
