namespace Projet_AP.Entreprise
{
    partial class SupprEntreprise
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
            this.lbSuppr = new System.Windows.Forms.ListBox();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.mainMenuStrip1 = new Projet_AP.Control.MainMenuStrip();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(232, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suppression d\'une entreprise";
            // 
            // lbSuppr
            // 
            this.lbSuppr.AccessibleName = "lbSuppr";
            this.lbSuppr.FormattingEnabled = true;
            this.lbSuppr.ItemHeight = 16;
            this.lbSuppr.Location = new System.Drawing.Point(347, 86);
            this.lbSuppr.Name = "lbSuppr";
            this.lbSuppr.Size = new System.Drawing.Size(120, 84);
            this.lbSuppr.TabIndex = 1;
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(347, 195);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(105, 23);
            this.btnSuppr.TabIndex = 2;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.BtnSuppr_Click);
            // 
            // mainMenuStrip1
            // 
            this.mainMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip1.Name = "mainMenuStrip1";
            this.mainMenuStrip1.Size = new System.Drawing.Size(800, 28);
            this.mainMenuStrip1.TabIndex = 3;
            this.mainMenuStrip1.Text = "mainMenuStrip1";
            // 
            // SupprEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.lbSuppr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenuStrip1);
            this.MainMenuStrip = this.mainMenuStrip1;
            this.Name = "SupprEntreprise";
            this.Text = "SupprEntreprise";
            this.Load += new System.EventHandler(this.SupprEntreprise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbSuppr;
        private System.Windows.Forms.Button btnSuppr;
        private Control.MainMenuStrip mainMenuStrip1;
    }
}