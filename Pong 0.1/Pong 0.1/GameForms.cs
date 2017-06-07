﻿using System;
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

        public GameForms()
        {
            InitializeComponent();
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 50;
            BallX = this.Width / 2 + Ballradius;
            Bally = this.Height / 2 + Ballradius;
            BalkenAX = this.Width / 10;
            BalkenAY = this.Height / 2 - BalkenHeight;
            BalkenBX = (this.Width - this.Width / 10 + BalkenWidth) ;
            BalkenBY = this.Height / 2 - BalkenHeight;
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Stop();
            myTimer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void GameForms_Load(object sender, EventArgs e)
        {

        }
    }
}
