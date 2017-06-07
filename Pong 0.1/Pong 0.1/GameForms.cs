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
        double BallX;
        double Bally;
        double Ballradius;
        double BalkenAX;
        double BalkenAY;
        double BalkenBX;
        double BalkenBY;
        double BalkenHeight;
        double BalkenWidth;

        bool RechtsLinks = true;
        bool ObenUnten = true;
        int xKoordinateBall = 0;
        int yKoordinateBall = 0;
        public GameForms()
        {
            DoubleBuffered = true;
            InitializeComponent();
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 1;
            BallX = this.Width / 2 + Ballradius;
            Bally = this.Height / 2 + Ballradius;
            BalkenAX = this.Width / 10;
            BalkenAY = this.Height / 2 - BalkenHeight;
            BalkenBX = (this.Width - this.Width / 10 + BalkenWidth) ;
            BalkenBY = this.Height / 2 - BalkenHeight;
            yKoordinateBall = Height / 2 - 100;
            xKoordinateBall = Width / 2 - 100;
            myTimer.Start();
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Stop();
            Invalidate();
            if(ObenUnten==true)
            {
                yKoordinateBall = yKoordinateBall - 1;
            }
           if(RechtsLinks==true)
           {
               xKoordinateBall = xKoordinateBall + 1;
           }
            myTimer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(10,20 , 50, 100));
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(100, 20, 50, 100));
            e.Graphics.FillEllipse(Brushes.Yellow, new Rectangle(xKoordinateBall, yKoordinateBall, 50, 50));

            base.OnPaint(e);
        }
        private void GameForms_Load(object sender, EventArgs e)
        {

        }
    }
}
