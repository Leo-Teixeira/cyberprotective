namespace Projet_AP
{
    partial class SupprAdherent
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbAdherent = new System.Windows.Forms.ListBox();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.mainMenuStrip1 = new Projet_AP.Control.MainMenuStrip();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(389, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suppression Adherent";
            // 
            // lbAdherent
            // 
            this.lbAdherent.FormattingEnabled = true;
            this.lbAdherent.ItemHeight = 16;
            this.lbAdherent.Location = new System.Drawing.Point(447, 156);
            this.lbAdherent.Margin = new System.Windows.Forms.Padding(4);
            this.lbAdherent.Name = "lbAdherent";
            this.lbAdherent.Size = new System.Drawing.Size(159, 116);
            this.lbAdherent.TabIndex = 2;
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(447, 343);
            this.btnSuppr.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(160, 54);
            this.btnSuppr.TabIndex = 3;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.BtnSuppr_Click);
            // 
            // mainMenuStrip1
            // 
            this.mainMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip1.Name = "mainMenuStrip1";
            this.mainMenuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.mainMenuStrip1.TabIndex = 4;
            this.mainMenuStrip1.Text = "mainMenuStrip1";
            // 
            // SupprAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.lbAdherent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenuStrip1);
            this.MainMenuStrip = this.mainMenuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SupprAdherent";
            this.Text = "SupprAdherent";
            this.Load += new System.EventHandler(this.SupprAdherent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAdherent;
        private System.Windows.Forms.Button btnSuppr;
        private Control.MainMenuStrip mainMenuStrip1;
    }
}