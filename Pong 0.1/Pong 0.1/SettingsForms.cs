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
    public partial class SettingsForms : Form
    {
        
        public SettingsForms()
        {
            InitializeComponent();
        }

        private void GoalLabel_Click(object sender, EventArgs e)
        {

        }

        private void SaveLabel_Click(object sender, EventArgs e)
        {

        }

        private void StopLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Schrift Effekt
        private void StopLabel_MouseEnter(object sender, EventArgs e)
        {
            StopLabel.Font = new Font("Niagara Solid", 40);
        }

        private void StopLabel_MouseLeave(object sender, EventArgs e)
        {
            StopLabel.Font = new Font("Niagara Solid", 36);
        }

        private void SaveLabel_MouseEnter(object sender, EventArgs e)
        {
            SaveLabel.Font = new Font("Niagara Solid", 40);
        }

        private void SaveLabel_MouseLeave(object sender, EventArgs e)
        {
            SaveLabel.Font = new Font("Niagara Solid", 36);
        }
        #endregion

        private void SettingsForms_Load(object sender, EventArgs e)
        {

        }

        private void RoundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GoalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(500, 250, 200, 20));//Balken Design
            e.Graphics.FillEllipse(Brushes.Yellow, new Rectangle(500, 200, 50, 50));//Ball Design

            base.OnPaint(e);
        }
    }
}
