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
        #region Variablen mit Get, Set
        //public string PlayerAName
        //{
        //    get { return PlayerAName; }
        //    set { PlayerAName = value; }
        //}

        //public string PlayerBName
        //{
        //    get { return PlayerBName; }
        //    set { PlayerBName = value; }
        //}

        //public int Runden
        //{
        //    get { return Runden; }
        //    set { Runden = RoundComboBox.SelectedIndex; }
        //}

        //public int Tore
        //{
        //    get { return Tore; }
        //    set { Tore = value; }
        //}
        #endregion


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
    }
}
