﻿using System;
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
        int Rounds = 1;
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
            settingsPanel.Hide();
            //cancelLabel.Font = new FontManager().CreateFont(36);
            //cancelLabel.Font = new FontManager().CreateFont(36);
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayLabel_MouseEnter(object sender, EventArgs e)
        {
            PlayLabel.Font = new FontManager().CreateFont(40);
        }

        private void PlayLabel_MouseLeave(object sender, EventArgs e)
        {
            PlayLabel.Font = new FontManager().CreateFont(36);
        }

        private void ExitLabel_MouseEnter(object sender, EventArgs e)
        {
            ExitLabel.Font = new FontManager().CreateFont(40);
        }

        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            ExitLabel.Font = new FontManager().CreateFont(36);
        }

        private void roundsTrackBar_Scroll(object sender, EventArgs e)
        {
            roundsLabel.Text = roundsTrackBar.Value.ToString();
        }

        private void settings2Label_MouseClick(object sender, MouseEventArgs e)
        {
            settingsPanel.Show();
            settings2Label.Hide(); //hier müsste der fehler irgendwo liegen
        }

        private void cancelLabel_MouseClick(object sender, MouseEventArgs e)
        {
            settingsPanel.Hide();
            settings2Label.Show();
        }

        private void saveLabel_MouseClick(object sender, MouseEventArgs e)
        {
            Rounds = roundsTrackBar.Value;
            Goals = goalsTrackBar.Value;
            settingsPanel.Hide();
            settings2Label.Show();
        }

        private void goalsTrackBar_Scroll(object sender, EventArgs e)
        {
            goalsLabel.Text = goalsTrackBar.Value.ToString();
        }

        private void cancelLabel_MouseEnter(object sender, EventArgs e)
        {
            cancelLabel.Font = new FontManager().CreateFont(40);
        }

        private void cancelLabel_MouseLeave(object sender, EventArgs e)
        {
            cancelLabel.Font = new FontManager().CreateFont(36);
        }

        private void saveLabel_MouseEnter(object sender, EventArgs e)
        {
            saveLabel.Font = new FontManager().CreateFont(40);
        }

        private void saveLabel_MouseLeave(object sender, EventArgs e)
        {
            saveLabel.Font = new FontManager().CreateFont(36);
        }

        private void settings2Label_MouseEnter(object sender, EventArgs e)
        {
            settings2Label.Font = new FontManager().CreateFont(40);
        }
        
        private void settings2Label_MouseLeave(object sender, EventArgs e)
        {
            settings2Label.Font = new FontManager().CreateFont(36);
        }

        private void settingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
