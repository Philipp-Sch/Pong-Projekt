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
            this.PlayLabel.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayLabel.ForeColor = System.Drawing.Color.White;
            this.PlayLabel.Location = new System.Drawing.Point(440, 154);
            this.PlayLabel.Name = "PlayLabel";
            this.PlayLabel.Size = new System.Drawing.Size(92, 64);
            this.PlayLabel.TabIndex = 0;
            this.PlayLabel.Text = "Play";
            this.PlayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayLabel.UseMnemonic = false;
            this.PlayLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.ForeColor = System.Drawing.Color.White;
            this.SettingsLabel.Location = new System.Drawing.Point(414, 254);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(146, 64);
            this.SettingsLabel.TabIndex = 1;
            this.SettingsLabel.Text = "Settings";
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.White;
            this.ExitLabel.Location = new System.Drawing.Point(448, 354);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(84, 64);
            this.ExitLabel.TabIndex = 2;
            this.ExitLabel.Text = "Exit";
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.SettingsLabel);
            this.Controls.Add(this.PlayLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
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

