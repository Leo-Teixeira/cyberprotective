namespace Projet_AP.Entreprise
{
    partial class CreaEntreprise
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
            this.label2 = new System.Windows.Forms.Label();
            this.rbActEntreprise = new System.Windows.Forms.RadioButton();
            this.rbDesEntreprise = new System.Windows.Forms.RadioButton();
            this.tbNEntreprise = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.mainMenuStrip1 = new Projet_AP.Control.MainMenuStrip();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(263, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Création de l\'entreprise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de l\'entreprise: ";
            // 
            // rbActEntreprise
            // 
            this.rbActEntreprise.AutoSize = true;
            this.rbActEntreprise.Location = new System.Drawing.Point(204, 232);
            this.rbActEntreprise.Name = "rbActEntreprise";
            this.rbActEntreprise.Size = new System.Drawing.Size(90, 21);
            this.rbActEntreprise.TabIndex = 2;
            this.rbActEntreprise.TabStop = true;
            this.rbActEntreprise.Text = "Activation";
            this.rbActEntreprise.UseVisualStyleBackColor = true;
            // 
            // rbDesEntreprise
            // 
            this.rbDesEntreprise.AutoSize = true;
            this.rbDesEntreprise.Location = new System.Drawing.Point(360, 232);
            this.rbDesEntreprise.Name = "rbDesEntreprise";
            this.rbDesEntreprise.Size = new System.Drawing.Size(114, 21);
            this.rbDesEntreprise.TabIndex = 3;
            this.rbDesEntreprise.TabStop = true;
            this.rbDesEntreprise.Text = "Desactivation";
            this.rbDesEntreprise.UseVisualStyleBackColor = true;
            // 
            // tbNEntreprise
            // 
            this.tbNEntreprise.Location = new System.Drawing.Point(356, 144);
            this.tbNEntreprise.Name = "tbNEntreprise";
            this.tbNEntreprise.Size = new System.Drawing.Size(178, 22);
            this.tbNEntreprise.TabIndex = 4;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(204, 294);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(360, 294);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // mainMenuStrip1
            // 
            this.mainMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip1.Name = "mainMenuStrip1";
            this.mainMenuStrip1.Size = new System.Drawing.Size(800, 28);
            this.mainMenuStrip1.TabIndex = 7;
            this.mainMenuStrip1.Text = "mainMenuStrip1";
            // 
            // CreaEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tbNEntreprise);
            this.Controls.Add(this.rbDesEntreprise);
            this.Controls.Add(this.rbActEntreprise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenuStrip1);
            this.MainMenuStrip = this.mainMenuStrip1;
            this.Name = "CreaEntreprise";
            this.Text = "CreaEntreprise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbActEntreprise;
        private System.Windows.Forms.RadioButton rbDesEntreprise;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private Control.MainMenuStrip mainMenuStrip1;
        public System.Windows.Forms.TextBox tbNEntreprise;
    }
}