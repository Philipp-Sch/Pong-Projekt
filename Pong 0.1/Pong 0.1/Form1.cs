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
    public partial class Pong : Form
    {
        int Goals = 7;
        int Rounds = 3;
        public Pong()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GameForms gameform = new GameForms(Goals,Rounds);
            gameform.ShowDialog();
            this.Close();
        }

        private void Pong_Load(object sender, EventArgs e)
        {

        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayLabel_MouseEnter(object sender, EventArgs e)
        {
            PlayLabel.Font = new Font("Niagara Solid", 40);
        }

        private void PlayLabel_MouseLeave(object sender, EventArgs e)
        {
            PlayLabel.Font = new Font("Niagara Solid", 36);
        }

        private void ExitLabel_MouseEnter(object sender, EventArgs e)
        {
            ExitLabel.Font = new Font("Niagara Solid", 40);
        }

        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            ExitLabel.Font = new Font("Niagara Solid", 36);
        }

        
    }
}
