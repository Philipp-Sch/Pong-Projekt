using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Pong_0._1
{
    public partial class GameForms : Form
    {
        Collider myCollider = new Collider();
        static Random rnd = new Random();
        Rectangle PowerUp;
        Thread powerupthread = new Thread(() =>
        {
            while (true)
            {
                if (PowerUpzeigen == false)
                {
                    if (rnd.NextDouble() < 0.2)
                    {
                        PowerUpzeigen = true;
                    }
                }
                Thread.Sleep(1000);
            }
        });

        System.Windows.Forms.Timer myTimer;
        
        int Alarm = 0;
        int BallX;
        int Bally;
        int Ballradius;
        int BallPunktLinksX;
        int BallPunktLinksY;
        int BallPunktRechtsX;
        int BallPunktRechtsY;

        int Ballspeed;

        int BalkenAX;
        int BalkenAY;

        int PowerupX;
        int PowerupY;
        int PowerupHeight;
        int PowerupWidth;
        int collisionCounter;

        int BalkenBX;
        int BalkenBY;

        int BalkenHeight;
        int BalkenWidth;


        int Rechts = 0;
        int Links = 0;
        string Punktzahl;
        int MaxPunktzahl;
        int MaxRunden;
        int RundenLinks;
        int RundenRechts;
        string Rundenanzahl;
        string GewinnRechts = "Spieler B hat Gewonnen!";
        string GewinnLinks = "Spieler A hat Gewonnen!";

        bool BalkenAHoch = false;
        bool BalkenARunter = false;
        bool BalkenBHoch = false;
        bool BalkenBRunter = false;

        bool RechtsLinks = true;
        bool ObenUnten = true;
   
        bool Collisionrechtsoben = false;
        bool Collisionrechtsmitte = false;
        bool Collisionrechtsunten = false;

        bool Collisionlinksoben = false;
        bool Collisionlinksmitte = false;
        bool Collisionlinksunten = false;

   
        bool Collisionrechts = false;
        bool Collisionlinks = false;
        bool CollisionPowerUp = false;
        bool BallIstAmStarten = false;
        static bool PowerUpzeigen = false;

        int letzeteCollisionsseite;//0 = Keine 1 = rechts ,2 = links
        public GameForms(int Goals,int Rounds)
        {
            MaxRunden = Rounds;
            MaxPunktzahl = Goals;
            DoubleBuffered = true;
            InitializeComponent();
            powerupthread.Start();
            myTimer = new System.Windows.Forms.Timer();

            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 1;
            myTimer.Start();
            Ballspeed = 1;

            PowerupX = this.Width / 2;
            PowerupY = this.Height / 2;
            PowerupHeight = 50;
            PowerupWidth = 50;

            Ballradius = 25;
            BalkenHeight = 100;
            BalkenWidth = 25;
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Stop();
            if (Alarm == 1)
            {
                System.Threading.Thread.Sleep(1000);
            }
            if (Alarm == 0)
            {
               

                BallX = this.Width / 2 + Ballradius;
                Bally = this.Height / 2 + Ballradius;

                BalkenAX = this.Width / 10 - BalkenWidth;
                BalkenAY = this.Height / 2 - BalkenHeight;

                BalkenBX = (this.Width - this.Width / 10);
                BalkenBY = this.Height / 2 - BalkenHeight;
                BallIstAmStarten = true;


            }
            Alarm++;
                //Mittelpunkt des Balles an der linken/rechten Seite
                BallPunktRechtsX = BallX + Ballradius;
                BallPunktRechtsY = Bally + (Ballradius/2);
                BallPunktLinksX = BallX;
            BallPunktLinksY = Bally + (Ballradius / 2);

            BallBalkenCollision();//Guckt ob Collision am Linken Balken oder Rechtem Balken stattfindet
            Ballbewegung(); //Variabelen des Balles werden bearbeitet
            RandCollision(); //Guckt ob der Ball eine der Wände berÜhrt

            
            Balkenbewegung();//Bei Buttonklick balken änderung
            RundenAktuallisieren();           // hier werden die Runden abgeglichen
            FormWechseln(); //Hier wird die Form bei MaxRunden Geschlossen
            Invalidate();
            myTimer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(BalkenAX, BalkenAY, BalkenWidth, BalkenHeight));//BalkenA
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(BalkenBX, BalkenBY, BalkenWidth, BalkenHeight));//BalkenB
            e.Graphics.FillEllipse(Brushes.Yellow, new Rectangle(BallX, Bally, Ballradius, Ballradius));//Ball

            if (PowerUpzeigen == true)
            {
                e.Graphics.FillRectangle(Brushes.White, PowerupX, PowerupY, PowerupWidth, PowerupHeight);//PowerUp
            }


            base.OnPaint(e);
        }
        private void GameForms_Load(object sender, EventArgs e)
        {

        }

        private void GameForms_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                BalkenBRunter = true;

            else if (e.KeyCode == Keys.S)
                BalkenARunter = true;

            else if (e.KeyCode == Keys.Up)
                BalkenBHoch = true;

            else if (e.KeyCode == Keys.W)
                BalkenAHoch = true;
        }

        private void GameForms_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                BalkenBRunter = false;
            else if (e.KeyCode == Keys.S)
                BalkenARunter = false;
            else if (e.KeyCode == Keys.Up)
                BalkenBHoch = false;
            else if (e.KeyCode == Keys.W)
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

        private void FormWechseln()
        {
            if (RundenRechts == MaxRunden)
            {
                AnzeigeGewinner.Text = GewinnRechts;
                System.Threading.Thread.Sleep(3000);
                AnzeigeGewinner.Text = "";
                RundenRechts = 0;
                RundenLinks = 0;
                this.Visible = false;
                Pong Form = new Pong();
                Form.ShowDialog();
                this.Close();

            }
            if (RundenLinks == MaxRunden)
            {
                AnzeigeGewinner.Text = GewinnLinks;
                System.Threading.Thread.Sleep(3000);
                AnzeigeGewinner.Text = "";

                RundenLinks = 0;
                RundenRechts = 0;
                this.Visible = false;
                Pong Form = new Pong();
                Form.ShowDialog();
                this.Close();
            }
        }
        private void RundenAktuallisieren()
        {
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
            Punktzahl = Convert.ToString(Rechts);
            RechterSpielerLabel.Text = "";
            RechterSpielerLabel.Text = Punktzahl;
            Punktzahl = Convert.ToString(Links);
            LinkerSpielerLabel.Text = "";
            LinkerSpielerLabel.Text = Punktzahl;
            Rundenanzahl = Convert.ToString(RundenLinks);
            RundenLinksLabel.Text = "";
            RundenLinksLabel.Text = Rundenanzahl;
            Rundenanzahl = Convert.ToString(RundenRechts);
            RundenRechtsLabel.Text = "";
            RundenRechtsLabel.Text = Rundenanzahl;
        }

        private void BallBalkenCollision()
        {
            CollisionPowerUp = myCollider.Collision(BallX, BallX + Ballradius, Bally, Bally + Ballradius, PowerupX, PowerupX + PowerupWidth, PowerupY, PowerupY + PowerupHeight);

            //Neuer Collider mit 3 geteilten Balken 
            Collisionlinksoben = myCollider.PunktQuadratCollision(BallPunktLinksX, BallPunktLinksY, BalkenAX, BalkenAX + BalkenWidth, BalkenAY, BalkenAY + BalkenHeight / 3);
            Collisionlinksmitte = myCollider.PunktQuadratCollision(BallPunktLinksX, BallPunktLinksY, BalkenAX, BalkenAX + BalkenWidth, BalkenAY + BalkenHeight / 3, BalkenAY + 2 * (BalkenHeight/3));
            Collisionlinksunten = myCollider.PunktQuadratCollision(BallPunktLinksX, BallPunktLinksY, BalkenAX, BalkenAX + BalkenWidth, BalkenAY + 2 * (BalkenHeight / 3), BalkenAY + BalkenHeight);

            Collisionrechtsoben = myCollider.PunktQuadratCollision(BallPunktRechtsX, BallPunktRechtsY, BalkenBX, BalkenBX + BalkenWidth, BalkenBY, BalkenBY + (BalkenHeight / 3));
            Collisionrechtsmitte = myCollider.PunktQuadratCollision(BallPunktRechtsX, BallPunktRechtsY, BalkenBX, BalkenBX + BalkenWidth, BalkenBY + (BalkenHeight / 3), BalkenBY + 2 * (BalkenHeight / 3));
            Collisionrechtsunten = myCollider.PunktQuadratCollision(BallPunktRechtsX, BallPunktRechtsY, BalkenBX, BalkenBX + BalkenWidth, BalkenBY + 2* (BalkenHeight / 3), BalkenBY + BalkenHeight);

            if (Collisionlinksoben == true)
            {
                if (Collisionlinks == false)
                ObenBalkenCollision();
                Collisionlinks = true;
            }
            else if (Collisionlinksmitte == true )
            {
                if (Collisionlinks == false)
                    MitteBalkenCollision();
                Collisionlinks = true;
            }
            else if (Collisionlinksunten == true)
            {
                if (Collisionlinks == false)
                    UntenBalkenCollision();
                Collisionlinks = true;
            }
            else
            {
                Collisionlinks = false;
            }


            if (Collisionrechtsoben == true)
            {
                if (Collisionrechts == false)
                    ObenBalkenCollision();
                Collisionrechts = true;
            }
            else if (Collisionrechtsmitte == true)
            {
                if (Collisionrechts == false)
                    MitteBalkenCollision();
                Collisionrechts = true;
            }
            else if (Collisionrechtsunten == true)
            {
                if (Collisionrechts == false)
                    UntenBalkenCollision();
                Collisionrechts = true;
            }
            else
            {
                Collisionrechts = false;
            }

            if (Collisionlinks == true)
            {
                if (letzeteCollisionsseite == 1 || letzeteCollisionsseite == 0)
                {

                    Ballspeed++;
                    letzeteCollisionsseite = 2;
                }
            }
            else if (Collisionrechts == true)
            {
                if (letzeteCollisionsseite == 2 || letzeteCollisionsseite == 0)
                {
                    Ballspeed++;
                    letzeteCollisionsseite = 1;
                }
            }
            else if (PowerUpzeigen && CollisionPowerUp && BallIstAmStarten == false)
            {
                //
                //Was soll passieren wenn das Powerup aufgesammelt wurde
                //
                PowerUpzeigen = false;
                Invalidate();
            }
            else
            {

            }
        }

        private void Ballbewegung()
        {
            bool collisionPowerUp = myCollider.Collision(BallX, BallX + Ballradius, Bally, Bally + Ballradius, PowerupX, PowerupX + PowerupWidth, PowerupY, PowerupY + PowerupHeight);

            if (collisionPowerUp == false && BallIstAmStarten && PowerUpzeigen)
            {
                BallIstAmStarten = false;
            }

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
            {
                RechtsLinks = false;

            }

            else if (RechtsLinks == false)
            {
                RechtsLinks = true;
            }

        }

        private void RandCollision()
        {
            {
                if (BallX >= Width - Ballradius)//Colision mit dem Rechten Rand
            {
                Links++;
                RechtsLinks = false;
                Alarm = 0;
                Ballspeed = 1;

                PowerUpzeigen = false;
            }

                if (BallX <= 0)//Colision mit dem linken Rand 
            {
                Rechts++;
                RechtsLinks = true;
                Alarm = 0;
                Ballspeed = 1;
                PowerUpzeigen = false;
            }

                if (Bally + 2 * Ballradius + 10 >= this.Height) //Colision mit dem Unteren Rand
            {
                ObenUnten = false;
                letzeteCollisionsseite = 0;
            }
                if (Bally <= 0) //Colision mit dem Oberen Rand
            {
                ObenUnten = true;
                letzeteCollisionsseite = 0;
            }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void GameForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (powerupthread.IsAlive)
            {
                try
            {
                    powerupthread.Abort();
            }
                catch (Exception)
                {
                   
                }
              
            }
        }
    }
}
