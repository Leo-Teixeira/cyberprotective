namespace Projet_AP.article.Theme
{
    partial class CreaTheme
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
            this.mainMenuStrip1 = new Projet_AP.Control.MainMenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTheme = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenuStrip1
            // 
            this.mainMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip1.Name = "mainMenuStrip1";
            this.mainMenuStrip1.Size = new System.Drawing.Size(800, 28);
            this.mainMenuStrip1.TabIndex = 0;
            this.mainMenuStrip1.Text = "mainMenuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom du Thème";
            // 
            // tbTheme
            // 
            this.tbTheme.Location = new System.Drawing.Point(363, 160);
            this.tbTheme.Name = "tbTheme";
            this.tbTheme.Size = new System.Drawing.Size(100, 22);
            this.tbTheme.TabIndex = 2;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(244, 249);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(388, 249);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(278, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Création d\'un Thème";
            // 
            // CreaTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tbTheme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenuStrip1);
            this.MainMenuStrip = this.mainMenuStrip1;
            this.Name = "CreaTheme";
            this.Text = "CreaTheme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.MainMenuStrip mainMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTheme;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label label2;
    }
}