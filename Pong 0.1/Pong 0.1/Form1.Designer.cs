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
            this.SuspendLayout();
            // 
            // PlayLabel
            // 
            this.PlayLabel.AutoSize = true;
            this.PlayLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayLabel.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayLabel.ForeColor = System.Drawing.Color.White;
            this.PlayLabel.Location = new System.Drawing.Point(330, 125);
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
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.ForeColor = System.Drawing.Color.White;
            this.SettingsLabel.Location = new System.Drawing.Point(310, 206);
            this.SettingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(118, 51);
            this.SettingsLabel.TabIndex = 1;
            this.SettingsLabel.Text = "Settings";
            this.SettingsLabel.MouseEnter += new System.EventHandler(this.SettingsLabel_MouseEnter);
            this.SettingsLabel.MouseLeave += new System.EventHandler(this.SettingsLabel_MouseLeave);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.White;
            this.ExitLabel.Location = new System.Drawing.Point(336, 288);
            this.ExitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(67, 51);
            this.ExitLabel.TabIndex = 2;
            this.ExitLabel.Text = "Exit";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            this.ExitLabel.MouseEnter += new System.EventHandler(this.ExitLabel_MouseEnter);
            this.ExitLabel.MouseLeave += new System.EventHandler(this.ExitLabel_MouseLeave);
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.SettingsLabel);
            this.Controls.Add(this.PlayLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pong";
            this.Text = "PONG";
            this.Load += new System.EventHandler(this.Pong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayLabel;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.Label ExitLabel;
    }
}

