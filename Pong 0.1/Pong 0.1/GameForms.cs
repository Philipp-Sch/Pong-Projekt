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
        Collider myCollider = new Collider();
        Timer myTimer;

        int Alarm = 0;
        int BallX;
        int Bally;
        int Ballradius;

        int Ballspeed;

        int BalkenAX;
        int BalkenAY;

        int BalkenBX;
        int BalkenBY;

        int BalkenHeight;
        int BalkenWidth;


        int Rechts = 0;
        int Links = 0;
        string Punktzahl;
        int MaxPunktzahl = 5;
        int MaxRunden;
        int RundenLinks;
        int RundenRechts;
        string Rundenanzahl;


        bool BalkenAHoch = false;
        bool BalkenARunter = false;
        bool BalkenBHoch = false;
        bool BalkenBRunter = false;

        bool RechtsLinks = true;
        bool ObenUnten = true;

        bool Collisionrechts = false;
        bool Collisionlinks = false;
        bool Collision = false;
        public GameForms()
        {
            DoubleBuffered = true;
            InitializeComponent();
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 1;
            myTimer.Start();
            Ballspeed = 5;
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Stop();
            if (Alarm == 1)
            {
                //System.Threading.Thread.Sleep(1000);
            }
            if (Alarm == 0)
            {
                Punktzahl = Links.ToString();
                //LinkerSpielerLabel.Text = "";
                //LinkerSpielerLabel.Text = Punktzahl;


                //Punktzahl = Rechts.ToString();
                //RechterSpielerLabel.Text = "";
                //RechterSpielerLabel.Text = Punktzahl;


                //RundenLinksLabel.Text = "";
                //RundenLinksLabel.Text = RundenLinks.ToString();


                //RundenRechtsLabel.Text = "";
                //RundenRechtsLabel.Text = RundenRechts.ToString();


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

            BallBalkenCollision();//Guckt ob Collision am Linken Balken oder Rechtem Balken stattfindet

            if (RechtsLinks == true)
            {
                BallX = BallX + Ballspeed;
            }
            if (RechtsLinks == false)
            {
                BallX = BallX - Ballspeed;
            }
            if (ObenUnten == true)
            {
                Bally = Bally + Ballspeed;
            }
            if (ObenUnten == false)
            {
                Bally = Bally - Ballspeed;
            }
            if (Bally <= 0)
            {
                ObenUnten = true;
            }
            if (BallX == Width - Ballradius)
            {
                Links++;
                RechtsLinks = false;
                Alarm = 0;
            }
            if (Bally >= 440)
            {
                ObenUnten = false;
            }
            if (BallX <= 0)
            {
                Rechts++;
                RechtsLinks = true;
                Alarm = 0;
            }
            if (Links == MaxPunktzahl)
            {
                Alarm = 0;
                Links = 0;
                Rechts = 0;
                RundenLinks++;
            }
            if (Rechts == MaxPunktzahl)
            {
                Alarm = 0;
                Links = 0;
                Rechts = 0;
                RundenRechts++;

            }

            if (RundenRechts == MaxRunden)
            {


            }
            if (Links == MaxPunktzahl)
            {
                Alarm = 0;
                Links = 0;
                Rechts = 0;
                RundenLinks++;
            }
            if (Rechts == MaxPunktzahl)
            {
                Alarm = 0;
                Links = 0;
                Rechts = 0;
                RundenRechts++;

            }
            Balkenbewegung();//Bei Buttonklick balken änderung
            Invalidate();
            myTimer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(BalkenAX, BalkenAY, BalkenWidth, BalkenHeight));//BalkenA
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(BalkenBX, BalkenBY, BalkenWidth, BalkenHeight));//BalkenB
            e.Graphics.FillEllipse(Brushes.Yellow, new Rectangle(BallX, Bally, Ballradius, Ballradius));//Ball

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
                if (BalkenAY - 10 >= 0)
                {
                    BalkenAY -= 10;
                }
            }

            else if (BalkenARunter == true)
            {
                if (BalkenAY + 140 + 10 <= this.Height)
                {
                    BalkenAY += 10;
                }
            }

            if (BalkenBHoch == true)
            {
                if (BalkenBY - 10 >= 0)
                {
                    BalkenBY -= 10;
                }
            }

            else if (BalkenBRunter == true)
            {
                if (BalkenBY + 140 + 10 <= this.Height)
                {
                    BalkenBY += 10;
                }
            }
        }

        public void BallBalkenCollision()
        {
            //Linker Balken Collesion überprüfen
            Collisionlinks = myCollider.Collision(BallX, BallX + 2 * Ballradius, Bally, Bally + 2 * Ballradius, BalkenAX, BalkenAX + BalkenWidth, BalkenAY, BalkenAY + BalkenHeight);
            //Rechter Balken Collesion überprüfen
            Collisionrechts = myCollider.Collision(BallX, BallX + 2 * Ballradius, Bally, Bally + 2 * Ballradius, BalkenBX, BalkenBX + BalkenWidth, BalkenBY, BalkenBY + BalkenHeight);

            if (Collisionlinks == true)
                Ballspieglung();
            if (Collisionrechts == true)
                Ballspieglung();
        }

        private void Ballspieglung()
        {
            if (ObenUnten == true)
                ObenUnten = false;
            else if (ObenUnten == false)
                ObenUnten = true;

            if (RechtsLinks == true)
                RechtsLinks = false;
            else if (RechtsLinks == false)
                RechtsLinks = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
