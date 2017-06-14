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
    }
}
