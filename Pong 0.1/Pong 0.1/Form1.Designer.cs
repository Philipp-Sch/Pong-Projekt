namespace Pong_0._1
{
    partial class Pong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayLabel = new System.Windows.Forms.Label();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.rounds2Label = new System.Windows.Forms.Label();
            this.roundsLabel = new System.Windows.Forms.Label();
            this.roundsTrackBar = new System.Windows.Forms.TrackBar();
            this.cancelLabel = new System.Windows.Forms.Label();
            this.saveLabel = new System.Windows.Forms.Label();
            this.settings2Label = new System.Windows.Forms.Label();
            this.goals2Label = new System.Windows.Forms.Label();
            this.goalsLabel = new System.Windows.Forms.Label();
            this.goalsTrackBar = new System.Windows.Forms.TrackBar();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundsTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalsTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayLabel
            // 
            this.PlayLabel.AutoSize = true;
            this.PlayLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayLabel.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayLabel.ForeColor = System.Drawing.Color.White;
            this.PlayLabel.Location = new System.Drawing.Point(340, 144);
            this.PlayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayLabel.Name = "PlayLabel";
            this.PlayLabel.Size = new System.Drawing.Size(71, 51);
            this.PlayLabel.TabIndex = 0;
            this.PlayLabel.Text = "Play";
            this.PlayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayLabel.UseMnemonic = false;
            this.PlayLabel.Click += new System.EventHandler(this.label1_Click);
            this.PlayLabel.MouseEnter += new System.EventHandler(this.PlayLabel_MouseEnter);
            this.PlayLabel.MouseLeave += new System.EventHandler(this.PlayLabel_MouseLeave);
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.Location = new System.Drawing.Point(0, 0);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(100, 23);
            this.SettingsLabel.TabIndex = 4;
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.White;
            this.ExitLabel.Location = new System.Drawing.Point(342, 307);
            this.ExitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(67, 51);
            this.ExitLabel.TabIndex = 2;
            this.ExitLabel.Text = "Exit";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            this.ExitLabel.MouseEnter += new System.EventHandler(this.ExitLabel_MouseEnter);
            this.ExitLabel.MouseLeave += new System.EventHandler(this.ExitLabel_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 50F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(321, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "PONG";
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.goals2Label);
            this.settingsPanel.Controls.Add(this.goalsLabel);
            this.settingsPanel.Controls.Add(this.goalsTrackBar);
            this.settingsPanel.Controls.Add(this.rounds2Label);
            this.settingsPanel.Controls.Add(this.roundsLabel);
            this.settingsPanel.Controls.Add(this.roundsTrackBar);
            this.settingsPanel.Controls.Add(this.cancelLabel);
            this.settingsPanel.Controls.Add(this.saveLabel);
            this.settingsPanel.Location = new System.Drawing.Point(12, 12);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(709, 436);
            this.settingsPanel.TabIndex = 5;
            // 
            // rounds2Label
            // 
            this.rounds2Label.AutoSize = true;
            this.rounds2Label.BackColor = System.Drawing.Color.Black;
            this.rounds2Label.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold);
            this.rounds2Label.ForeColor = System.Drawing.SystemColors.Window;
            this.rounds2Label.Location = new System.Drawing.Point(215, 159);
            this.rounds2Label.Name = "rounds2Label";
            this.rounds2Label.Size = new System.Drawing.Size(239, 51);
            this.rounds2Label.TabIndex = 6;
            this.rounds2Label.Text = "Anzahl der Runden";
            // 
            // roundsLabel
            // 
            this.roundsLabel.AutoSize = true;
            this.roundsLabel.BackColor = System.Drawing.Color.Black;
            this.roundsLabel.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold);
            this.roundsLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.roundsLabel.Location = new System.Drawing.Point(511, 195);
            this.roundsLabel.Name = "roundsLabel";
            this.roundsLabel.Size = new System.Drawing.Size(31, 51);
            this.roundsLabel.TabIndex = 5;
            this.roundsLabel.Text = "1";
            // 
            // roundsTrackBar
            // 
            this.roundsTrackBar.Location = new System.Drawing.Point(215, 216);
            this.roundsTrackBar.Maximum = 100;
            this.roundsTrackBar.Minimum = 1;
            this.roundsTrackBar.Name = "roundsTrackBar";
            this.roundsTrackBar.Size = new System.Drawing.Size(290, 45);
            this.roundsTrackBar.TabIndex = 4;
            this.roundsTrackBar.Value = 1;
            this.roundsTrackBar.Scroll += new System.EventHandler(this.roundsTrackBar_Scroll);
            // 
            // cancelLabel
            // 
            this.cancelLabel.AutoSize = true;
            this.cancelLabel.BackColor = System.Drawing.Color.Black;
            this.cancelLabel.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold);
            this.cancelLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.cancelLabel.Location = new System.Drawing.Point(26, 359);
            this.cancelLabel.Name = "cancelLabel";
            this.cancelLabel.Size = new System.Drawing.Size(148, 51);
            this.cancelLabel.TabIndex = 3;
            this.cancelLabel.Text = "Abbrechen";
            this.cancelLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cancelLabel_MouseClick);
            this.cancelLabel.MouseEnter += new System.EventHandler(this.cancelLabel_MouseEnter);
            this.cancelLabel.MouseLeave += new System.EventHandler(this.cancelLabel_MouseLeave);
            // 
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.saveLabel.BackColor = System.Drawing.Color.Black;
            this.saveLabel.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold);
            this.saveLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.saveLabel.Location = new System.Drawing.Point(539, 359);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(142, 51);
            this.saveLabel.TabIndex = 2;
            this.saveLabel.Text = "Speichern";
            this.saveLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveLabel_MouseClick);
            this.saveLabel.MouseEnter += new System.EventHandler(this.saveLabel_MouseEnter);
            this.saveLabel.MouseLeave += new System.EventHandler(this.saveLabel_MouseLeave);
            // 
            // settings2Label
            // 
            this.settings2Label.AutoSize = true;
            this.settings2Label.BackColor = System.Drawing.Color.Transparent;
            this.settings2Label.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings2Label.ForeColor = System.Drawing.Color.White;
            this.settings2Label.Location = new System.Drawing.Point(317, 221);
            this.settings2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.settings2Label.Name = "settings2Label";
            this.settings2Label.Size = new System.Drawing.Size(118, 51);
            this.settings2Label.TabIndex = 6;
            this.settings2Label.Text = "Settings";
            this.settings2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settings2Label.UseMnemonic = false;
            this.settings2Label.MouseClick += new System.Windows.Forms.MouseEventHandler(this.settings2Label_MouseClick);
            this.settings2Label.MouseEnter += new System.EventHandler(this.settings2Label_MouseEnter);
            this.settings2Label.MouseLeave += new System.EventHandler(this.settings2Label_MouseLeave);
            // 
            // goals2Label
            // 
            this.goals2Label.AutoSize = true;
            this.goals2Label.BackColor = System.Drawing.Color.Black;
            this.goals2Label.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold);
            this.goals2Label.ForeColor = System.Drawing.SystemColors.Window;
            this.goals2Label.Location = new System.Drawing.Point(215, 38);
            this.goals2Label.Name = "goals2Label";
            this.goals2Label.Size = new System.Drawing.Size(214, 51);
            this.goals2Label.TabIndex = 9;
            this.goals2Label.Text = "Anzahl der Tore";
            // 
            // goalsLabel
            // 
            this.goalsLabel.AutoSize = true;
            this.goalsLabel.BackColor = System.Drawing.Color.Black;
            this.goalsLabel.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold);
            this.goalsLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.goalsLabel.Location = new System.Drawing.Point(511, 74);
            this.goalsLabel.Name = "goalsLabel";
            this.goalsLabel.Size = new System.Drawing.Size(31, 51);
            this.goalsLabel.TabIndex = 8;
            this.goalsLabel.Text = "1";
            // 
            // goalsTrackBar
            // 
            this.goalsTrackBar.Location = new System.Drawing.Point(215, 92);
            this.goalsTrackBar.Minimum = 1;
            this.goalsTrackBar.Name = "goalsTrackBar";
            this.goalsTrackBar.Size = new System.Drawing.Size(290, 45);
            this.goalsTrackBar.TabIndex = 7;
            this.goalsTrackBar.Value = 1;
            this.goalsTrackBar.Scroll += new System.EventHandler(this.goalsTrackBar_Scroll);
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.settings2Label);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.SettingsLabel);
            this.Controls.Add(this.PlayLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pong";
            this.Text = "PONG";
            this.Load += new System.EventHandler(this.Pong_Load);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundsTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalsTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayLabel;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label rounds2Label;
        private System.Windows.Forms.Label roundsLabel;
        private System.Windows.Forms.TrackBar roundsTrackBar;
        private System.Windows.Forms.Label cancelLabel;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.Label settings2Label;
        private System.Windows.Forms.Label goals2Label;
        private System.Windows.Forms.Label goalsLabel;
        private System.Windows.Forms.TrackBar goalsTrackBar;
    }
}

