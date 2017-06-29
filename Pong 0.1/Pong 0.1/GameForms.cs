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

        int Ballspeed;

        int BalkenAX;
        int BalkenAY;

        int BalkenBX;
        int BalkenBY;

        int BalkenHeight;
        int BalkenWidth;


        int RechtsPunkte = 0;
        int LinksPunkte = 0;
        string Punktzahl;
        int MaxPunktzahl ;
        int MaxRunden ;
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

        int letzeteCollisionsseite;//0 = Keine 1 = rechts ,2 = links
        public GameForms(int Goals,int Rounds)
        {
            MaxRunden = Rounds;
            MaxPunktzahl = Goals;
            DoubleBuffered = true;
            InitializeComponent();
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 1;
            myTimer.Start();
            Ballspeed = 3;
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
            TextAktuallisierung(); //Hier werden Informationen dem User gegeben
            Balkenbewegung();//Bei Buttonklick balken änderung
            RundenAktuallisieren();           // hier werden die Runden abgeglichen
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

        private void BallBalkenCollision()
        {
            //Alter Collider
            ////Linker Balken Collesion überprüfen
            //Collisionlinks = myCollider.Collision(BallX, BallX + 2 * Ballradius, Bally, Bally + 2 * Ballradius, BalkenAX, BalkenAX + BalkenWidth, BalkenAY, BalkenAY + BalkenHeight);
            ////Rechter Balken Collesion überprüfen
            //Collisionrechts = myCollider.Collision(BallX, BallX + 2 * Ballradius, Bally, Bally + 2 * Ballradius, BalkenBX, BalkenBX + BalkenWidth, BalkenBY, BalkenBY + BalkenHeight);
            //if (Collisionlinks == true)
            //    Ballspieglung();
            //if (Collisionrechts == true)
            //    Ballspieglung();

            //Neuer Collider mit 3 geteilten Balken 
            Collisionlinksoben = myCollider.PunktQuadratCollision(BallPunktLinksX, BallPunktLinksY, BalkenAX, BalkenAX + BalkenWidth, BalkenAY, BalkenAY + BalkenHeight / 3);
            Collisionlinksmitte = myCollider.PunktQuadratCollision(BallPunktLinksX, BallPunktLinksY, BalkenAX, BalkenAX + BalkenWidth, BalkenAY + BalkenHeight / 3, BalkenAY + 2 * (BalkenHeight/3));
            Collisionlinksunten = myCollider.PunktQuadratCollision(BallPunktLinksX, BallPunktLinksY, BalkenAX, BalkenAX + BalkenWidth, BalkenAY + 2 * (BalkenHeight / 3), BalkenAY + BalkenHeight);

            Collisionrechtsoben = myCollider.PunktQuadratCollision(BallPunktRechtsX, BallPunktRechtsY, BalkenBX, BalkenBX + BalkenWidth, BalkenBY, BalkenBY + (BalkenHeight / 3));
            Collisionrechtsmitte = myCollider.PunktQuadratCollision(BallPunktRechtsX, BallPunktRechtsY, BalkenBX, BalkenBX + BalkenWidth, BalkenBY + (BalkenHeight / 3), BalkenBY + 2 * (BalkenHeight / 3));
            Collisionrechtsunten = myCollider.PunktQuadratCollision(BallPunktRechtsX, BallPunktRechtsY, BalkenBX, BalkenBX + BalkenWidth, BalkenBY + 2* (BalkenHeight / 3), BalkenBY + BalkenHeight);

            if (Collisionlinksoben == true && Collisionlinks == false)
            {
                ObenBalkenCollision();
                Collisionlinks = true;
            }
            else if (Collisionlinksmitte == true && Collisionlinks == false)
            {
                MitteBalkenCollision();
                Collisionlinks = true;
            }
            else if (Collisionlinksunten == true && Collisionlinks == false)
            {
                UntenBalkenCollision();
                Collisionlinks = true;
            }
            else
            {
                Collisionlinks = false;
            }


            if (Collisionrechtsoben == true && Collisionrechts == false)
            {
                ObenBalkenCollision();
                Collisionrechts = true;
            }
            else if (Collisionrechtsmitte == true && Collisionrechts == false)
            {
                MitteBalkenCollision();
                Collisionrechts = true;
            }
            else if (Collisionrechtsunten == true && Collisionrechts == false)
            {
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
            if (Collisionrechts == true)
            {
                if (letzeteCollisionsseite == 2 || letzeteCollisionsseite == 0)
                {
                    Ballspeed++;
                    letzeteCollisionsseite = 1;
                }
            }
        }

        private void Ballbewegung()
        {
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
                    LinksPunkte++;
                    RechtsLinks = false;
                    Alarm = 0;
                    Ballspeed = 3;
                }

                if (BallX <= 0)//Colision mit dem linken Rand 
                {
                    RechtsPunkte++;
                    RechtsLinks = true;
                    Alarm = 0;
                    Ballspeed = 3;
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
        private void TextAktuallisierung()
        { 
            //Hier werden die Punkte in das Label übertragen.
            Punktzahl = LinksPunkte.ToString();
            LinkerSpielerLabel.Text = "";
            LinkerSpielerLabel.Text = Punktzahl;
            Punktzahl = RechtsPunkte.ToString();
            RechterSpielerLabel.Text = "";
            RechterSpielerLabel.Text = Punktzahl;

            //Hier Werden die Runden in das Label übertragen. 

            Rundenanzahl = RundenLinks.ToString();
            RundenLinksLabel.Text = "";
            RundenLinksLabel.Text = Rundenanzahl;

            Rundenanzahl = RundenRechts.ToString();
            RundenRechtsLabel.Text = "";
            RundenRechtsLabel.Text = Rundenanzahl;

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void RundenAktuallisieren()
        {
            if (LinksPunkte == MaxPunktzahl)
            {
                Alarm = 0;
                LinksPunkte = 0;
                RechtsPunkte = 0;
                RundenLinks++;
            }
            if (RechtsPunkte == MaxPunktzahl)
            {
                Alarm = 0;
                LinksPunkte = 0;
                RechtsPunkte = 0;
                RundenRechts++;
            }

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
    }
}
