namespace Pong_0._1
{
    partial class SettingsForms
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
            this.SettLabel = new System.Windows.Forms.Label();
            this.GoalLabel = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RoundComboBox = new System.Windows.Forms.ComboBox();
            this.GoalComboBox = new System.Windows.Forms.ComboBox();
            this.StopLabel = new System.Windows.Forms.Label();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SettLabel
            // 
            this.SettLabel.AutoSize = true;
            this.SettLabel.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SettLabel.Location = new System.Drawing.Point(279, 21);
            this.SettLabel.Name = "SettLabel";
            this.SettLabel.Size = new System.Drawing.Size(185, 51);
            this.SettLabel.TabIndex = 0;
            this.SettLabel.Text = "Einstellungen";
            // 
            // GoalLabel
            // 
            this.GoalLabel.AutoSize = true;
            this.GoalLabel.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GoalLabel.Location = new System.Drawing.Point(110, 234);
            this.GoalLabel.Name = "GoalLabel";
            this.GoalLabel.Size = new System.Drawing.Size(217, 51);
            this.GoalLabel.TabIndex = 1;
            this.GoalLabel.Text = "Anzahl der Tore";
            this.GoalLabel.Click += new System.EventHandler(this.GoalLabel_Click);
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RoundLabel.Location = new System.Drawing.Point(110, 168);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(244, 51);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Anzahl der Runden";
            // 
            // RoundComboBox
            // 
            this.RoundComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoundComboBox.Font = new System.Drawing.Font("Niagara Engraved", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundComboBox.FormattingEnabled = true;
            this.RoundComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.RoundComboBox.Location = new System.Drawing.Point(510, 177);
            this.RoundComboBox.Name = "RoundComboBox";
            this.RoundComboBox.Size = new System.Drawing.Size(74, 42);
            this.RoundComboBox.TabIndex = 3;
            // 
            // GoalComboBox
            // 
            this.GoalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GoalComboBox.Font = new System.Drawing.Font("Niagara Engraved", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalComboBox.FormattingEnabled = true;
            this.GoalComboBox.ItemHeight = 34;
            this.GoalComboBox.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.GoalComboBox.Location = new System.Drawing.Point(510, 243);
            this.GoalComboBox.Name = "GoalComboBox";
            this.GoalComboBox.Size = new System.Drawing.Size(74, 42);
            this.GoalComboBox.TabIndex = 4;
            // 
            // StopLabel
            // 
            this.StopLabel.AutoSize = true;
            this.StopLabel.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StopLabel.Location = new System.Drawing.Point(41, 386);
            this.StopLabel.Name = "StopLabel";
            this.StopLabel.Size = new System.Drawing.Size(150, 51);
            this.StopLabel.TabIndex = 5;
            this.StopLabel.Text = "Abbrechen";
            this.StopLabel.Click += new System.EventHandler(this.StopLabel_Click);
            this.StopLabel.MouseEnter += new System.EventHandler(this.StopLabel_MouseEnter);
            this.StopLabel.MouseLeave += new System.EventHandler(this.StopLabel_MouseLeave);
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveLabel.Location = new System.Drawing.Point(534, 386);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(144, 51);
            this.SaveLabel.TabIndex = 6;
            this.SaveLabel.Text = "Speichern";
            this.SaveLabel.Click += new System.EventHandler(this.SaveLabel_Click);
            this.SaveLabel.MouseEnter += new System.EventHandler(this.SaveLabel_MouseEnter);
            this.SaveLabel.MouseLeave += new System.EventHandler(this.SaveLabel_MouseLeave);
            // 
            // SettingsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.SaveLabel);
            this.Controls.Add(this.StopLabel);
            this.Controls.Add(this.GoalComboBox);
            this.Controls.Add(this.RoundComboBox);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.GoalLabel);
            this.Controls.Add(this.SettLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForms";
            this.Text = "Einstellungen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SettLabel;
        private System.Windows.Forms.Label GoalLabel;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox RoundComboBox;
        private System.Windows.Forms.ComboBox GoalComboBox;
        private System.Windows.Forms.Label StopLabel;
        private System.Windows.Forms.Label SaveLabel;
    }
}