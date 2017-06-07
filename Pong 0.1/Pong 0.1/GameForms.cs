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
        
        bool RechtsLinks = true;
        bool ObenUnten = true;
        int xKoordinateBall = 0;
        int yKoordinateBall = 0;
        public GameForms()
        {
            InitializeComponent();
            xKoordinateBall = Width / 2 - 100;
            yKoordinateBall = Height / 2 - 100;
        }

       
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(10,20 , 50, 100));
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(100, 20, 50, 100));
            e.Graphics.FillEllipse(Brushes.Yellow, new Rectangle(xKoordinateBall,yKoordinateBall, 50, 50));

            base.OnPaint(e);
        }
        private void GameForms_Load(object sender, EventArgs e)
        {

        }
    }
}
