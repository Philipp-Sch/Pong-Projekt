namespace Pong_0._1
{
    partial class GameForms
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
            this.PlayerAPunkte = new System.Windows.Forms.Label();
            this.PlayerBPunkte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayerAPunkte
            // 
            this.PlayerAPunkte.AutoSize = true;
            this.PlayerAPunkte.ForeColor = System.Drawing.Color.White;
            this.PlayerAPunkte.Location = new System.Drawing.Point(16, 11);
            this.PlayerAPunkte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerAPunkte.Name = "PlayerAPunkte";
            this.PlayerAPunkte.Size = new System.Drawing.Size(109, 17);
            this.PlayerAPunkte.TabIndex = 0;
            this.PlayerAPunkte.Text = "Player A Punkte";
            // 
            // PlayerBPunkte
            // 
            this.PlayerBPunkte.AutoSize = true;
            this.PlayerBPunkte.ForeColor = System.Drawing.Color.White;
            this.PlayerBPunkte.Location = new System.Drawing.Point(852, 11);
            this.PlayerBPunkte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerBPunkte.Name = "PlayerBPunkte";
            this.PlayerBPunkte.Size = new System.Drawing.Size(109, 17);
            this.PlayerBPunkte.TabIndex = 1;
            this.PlayerBPunkte.Text = "Player B Punkte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(979, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerBPunkte);
            this.Controls.Add(this.PlayerAPunkte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameForms";
            this.Text = "GameForms";
            this.Load += new System.EventHandler(this.GameForms_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForms_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForms_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerAPunkte;
        private System.Windows.Forms.Label PlayerBPunkte;
        private System.Windows.Forms.Label label1;
    }
}