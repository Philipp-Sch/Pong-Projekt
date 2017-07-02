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
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(278, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "PONG";
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.SettingsLabel);
            this.Controls.Add(this.PlayLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label label1;
    }
}

