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
            this.SuspendLayout();
            // 
            // PlayerAPunkte
            // 
            this.PlayerAPunkte.AutoSize = true;
            this.PlayerAPunkte.ForeColor = System.Drawing.Color.White;
            this.PlayerAPunkte.Location = new System.Drawing.Point(12, 9);
            this.PlayerAPunkte.Name = "PlayerAPunkte";
            this.PlayerAPunkte.Size = new System.Drawing.Size(83, 13);
            this.PlayerAPunkte.TabIndex = 0;
            this.PlayerAPunkte.Text = "Player A Punkte";
            // 
            // PlayerBPunkte
            // 
            this.PlayerBPunkte.AutoSize = true;
            this.PlayerBPunkte.ForeColor = System.Drawing.Color.White;
            this.PlayerBPunkte.Location = new System.Drawing.Point(639, 9);
            this.PlayerBPunkte.Name = "PlayerBPunkte";
            this.PlayerBPunkte.Size = new System.Drawing.Size(83, 13);
            this.PlayerBPunkte.TabIndex = 1;
            this.PlayerBPunkte.Text = "Player B Punkte";
            // 
            // GameForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.PlayerBPunkte);
            this.Controls.Add(this.PlayerAPunkte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}