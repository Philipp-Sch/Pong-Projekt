using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_0._1
{
    public partial class GameForms : Form
    {
        Timer myTimer;
        int Alarm = 0;
        int BallX;
        int Bally;
        int Ballradius;
        int BalkenAX;
        int BalkenAY;
        int BalkenBX;
        int BalkenBY;
        int BalkenHeight;
        int BalkenWidth;

        bool BalkenAHoch = false;
        bool BalkenARunter = false;
        bool BalkenBHoch = false;
        bool BalkenBRunter = false;

        bool RechtsLinks = true;
        bool ObenUnten = true;
   
        public GameForms()
        {
            DoubleBuffered = true;
            InitializeComponent();
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 1;
            myTimer.Start();


            
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Stop();
            if (Alarm == 0)
            {
                Ballradius = 25;
                BalkenHeight = 100;
                BalkenWidth = 25;

                BallX = this.Width / 2 + Ballradius;
                Bally = this.Height / 2 + Ballradius;

                BalkenAX = this.Width / 10 - BalkenWidth;
                BalkenAY = this.Height / 2 - BalkenHeight;

                BalkenBX = (this.Width - this.Width / 10);
                BalkenBY = this.Height / 2 - BalkenHeight;

            }
            Alarm++;

            if (RechtsLinks == true)
            {
                BallX = BallX + 1;
            }
            if (RechtsLinks == false)
            {
                BallX = BallX - 1;
            }
            if (ObenUnten == true)
            {
                Bally = Bally + 1;
            }
            if (ObenUnten == false)
            {
                Bally = Bally - 1;
            }
            if (Bally == 0)
            {
                ObenUnten = false;
            }
            if (BallX == Width - Ballradius)
            {
                RechtsLinks = false;
            }
            if (Bally == Height - Ballradius)
            {
                ObenUnten = false;
            }

            Balkenbewegung();//Bei Buttonklick balken änderung
            Invalidate();
            myTimer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(BalkenAX,BalkenAY ,BalkenWidth, BalkenHeight));//BalkenA
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(BalkenBX, BalkenBY,BalkenWidth, BalkenHeight));//BalkenB
            e.Graphics.FillEllipse(Brushes.Yellow, new Rectangle(BallX,Bally,Ballradius,Ballradius));//Ball

            base.OnPaint(e);
        }
        private void GameForms_Load(object sender, EventArgs e)
        {

        }

        private void GameForms_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)

                BalkenBRunter = true;


            if (e.KeyCode == Keys.S)
                BalkenARunter = true;


            if (e.KeyCode == Keys.Up)
                BalkenBHoch = true;


            if (e.KeyCode == Keys.W)
                BalkenAHoch = true;

        }

        private void GameForms_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                BalkenBRunter = false;
            if (e.KeyCode == Keys.S)
                BalkenARunter = false;
            if (e.KeyCode == Keys.Up)
                BalkenBHoch = false;
            if (e.KeyCode == Keys.W)
                BalkenAHoch = false;
        }

        private void Balkenbewegung()
        {
            if (BalkenAHoch == true)
            {
                if(BalkenAY -10 >= 0)
                {
                    BalkenAY -= 10;
                }
            }

            else if (BalkenARunter == true)
            {
                if(BalkenAY +140 +10 <= this.Height)
                {
                    BalkenAY += 10;
                }
            }

            if (BalkenBHoch == true)
            {
                if(BalkenBY -10 >= 0)
                {
                    BalkenBY -= 10;
                }
            }

            else if(BalkenBRunter == true)
            {
                if(BalkenBY +140 +10 <= this.Height)
                {
                    BalkenBY += 10;
                }
            }


        }
    }
}
