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
        int BallPunktLinksX;
        int BallPunktLinksY;
        int BallPunktRechtsX;
        int BallPunktRechtsY;

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

        //bool Collisionrechts = false;
        //bool Collisionlinks = false;
        //bool Collision = false;

        bool Collisionrechtsoben = false;
        bool Collisionrechtsmitte = false;
        bool Collisionrechtsunten = false;

        bool Collisionlinksoben = false;
        bool Collisionlinksmitte = false;
        bool Collisionlinksunten = false;

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
                //Mittelpunkt des Balles an der linken/rechten Seite
                BallPunktRechtsX = BallX + Ballradius*2;
                BallPunktRechtsY = Bally + Ballradius;
                BallPunktLinksX = BallX;
                BallPunktLinksY = Bally + Ballradius;

            BallBalkenCollision();//Guckt ob Collision am Linken Balken oder Rechtem Balken stattfindet
            
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

            Balkenbewegung();//Bei Buttonklick Balkenänderung
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
                BalkenAY -= 10;
            else if (BalkenARunter == true)
                BalkenAY += 10;

            if (BalkenBHoch == true)
                BalkenBY -= 10;
            else if (BalkenBRunter == true)
                BalkenBY += 10;
        }

        private void BallBalkenCollision()
        {
            ////Linker Balken Collesion überprüfen
            //Collisionlinks = myCollider.Collision(BallX, BallX + 2 * Ballradius, Bally, Bally + 2 * Ballradius, BalkenAX, BalkenAX + BalkenWidth, BalkenAY, BalkenAY + BalkenHeight);
            ////Rechter Balken Collesion überprüfen
            //Collisionrechts = myCollider.Collision(BallX, BallX + 2 * Ballradius, Bally, Bally + 2 * Ballradius, BalkenBX, BalkenBX + BalkenWidth, BalkenBY, BalkenBY + BalkenHeight);
            //if (Collisionlinks == true)
            //    Ballspieglung();
            //if (Collisionrechts == true)
            //    Ballspieglung();

            Collisionlinksoben = myCollider.PunktQuadratCollision(BallPunktLinksX, BallPunktLinksY, BalkenAX, BalkenAX + BalkenWidth, BalkenAY, BalkenAY + 1 / 3 * BalkenHeight);
            Collisionlinksoben = myCollider.PunktQuadratCollision(BallPunktLinksX, BallPunktLinksY, BalkenAX, BalkenAX + BalkenWidth, BalkenAY + 1 / 3 * BalkenHeight, BalkenAY + 2 / 3 * BalkenHeight);
            Collisionlinksoben = myCollider.PunktQuadratCollision(BallPunktLinksX, BallPunktLinksY, BalkenAX, BalkenAX + BalkenWidth, BalkenAY + 2 / 3 * BalkenHeight, BalkenAY + BalkenHeight);

            Collisionrechtsoben = myCollider.PunktQuadratCollision(BallPunktRechtsX, BallPunktRechtsY, BalkenBX, BalkenBX + BalkenWidth, BalkenBY, BalkenBY + 1 / 3 * BalkenHeight);
            Collisionrechtsoben = myCollider.PunktQuadratCollision(BallPunktRechtsX, BallPunktRechtsY, BalkenBX, BalkenBX + BalkenWidth, BalkenBY + 1 / 3 * BalkenHeight, BalkenBY + 2 / 3 * BalkenHeight);
            Collisionrechtsoben = myCollider.PunktQuadratCollision(BallPunktRechtsX, BallPunktRechtsY, BalkenBX, BalkenBX + BalkenWidth, BalkenBY + 2 / 3 * BalkenHeight, BalkenBY + BalkenHeight);

            if (Collisionlinksoben == true)
                ObenBalkenCollision();
            if (Collisionlinksmitte == true)
                MitteBalkenCollision();
            if (Collisionlinksunten == true)
                UntenBalkenCollision();

            if (Collisionrechtsoben == true)
                ObenBalkenCollision();
            if (Collisionrechtsmitte == true)
                MitteBalkenCollision();
            if (Collisionrechtsunten == true)
                UntenBalkenCollision();

        }

        private void ObenBalkenCollision()
        {
            ObenUnten = false;

            if (RechtsLinks == true)
                RechtsLinks = false;
            else if (RechtsLinks == false)
                RechtsLinks = true;
        }

        private void UntenBalkenCollision()
        {
            ObenUnten = true;

            if (RechtsLinks == true)
                RechtsLinks = false;
            else if (RechtsLinks == false)
                RechtsLinks = true;
        }

        private void MitteBalkenCollision()
        {
            if (RechtsLinks == true)
                RechtsLinks = false;
            else if (RechtsLinks == false)
                RechtsLinks = true;
        }
    }
}
