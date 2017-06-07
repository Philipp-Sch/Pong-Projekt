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
        int BallX;
        int Bally;
        int Ballradius;
        int BalkenAX;
        int BalkenAY;
        int BalkenBX;
        int BalkenBY;
        int BalkenHeight;
        int BalkenWidth;

        bool RechtsLinks = true;
        bool ObenUnten = true;
        int xKoordinateBall = 300;
        int yKoordinateBall = 100;
        public GameForms()
        {
            InitializeComponent();
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 100;
            myTimer.Start();

            Ballradius = 25;
            BalkenHeight = 100;
            BalkenWidth = 25;

            BallX = this.Width / 2 + Ballradius;
            Bally = this.Height / 2 + Ballradius;

            BalkenAX = this.Width / 10 - BalkenWidth;
            BalkenAY = this.Height / 2 - BalkenHeight;

            BalkenBX = (this.Width - this.Width / 10) ;
            BalkenBY = this.Height / 2 - BalkenHeight;
            yKoordinateBall = Height / 2 - 100;
            xKoordinateBall = Width / 2 - 100;
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Stop();
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
    }
}
