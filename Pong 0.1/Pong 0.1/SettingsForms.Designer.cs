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
            this.GoalLabel.Location = new System.Drawing.Point(264, 229);
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
            this.RoundLabel.Location = new System.Drawing.Point(251, 163);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(244, 51);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Anzahl der Runden";
            // 
            // SettingsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(734, 461);
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
    }
}