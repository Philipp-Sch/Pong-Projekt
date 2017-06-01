using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animationen_mit_GDI_
{
    public partial class Form1 : Form
    {
        Timer myTimer;
        int alarmCounter = 0;
        int tiemrVorher = 0;
        int posX, posY;
        bool b = false;

        Random r;
        KnownColor[] farben = (KnownColor[])Enum.GetValues(typeof(KnownColor));

        public Form1()
        {
            InitializeComponent();
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 40;
            r = new Random();
   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                      
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(Brushes.Black, new Rectangle(posX, posY, 100, 100));
            if (alarmCounter != tiemrVorher)
            {
                //e.Graphics.FillRectangle(new SolidBrush(Color.FromKnownColor(farben[r.Next(farben.Length)])), new Rectangle(posX, posY, 100, 100));
                e.Graphics.FillRectangle((Brushes.Black), new Rectangle(posX, posY, 100, 100));
            }

        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Stop();
            posX += 5;
            posY += 5;

            Invalidate();
            alarmCounter += 1;
            timerLabel.Text = alarmCounter.ToString();
            myTimer.Start();

        }

        private void startenButton_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                b = true;
                myTimer.Start();
            }
            else if(b == true)
            {
                b = false;
                myTimer.Stop();

            }

        }
    }
}
