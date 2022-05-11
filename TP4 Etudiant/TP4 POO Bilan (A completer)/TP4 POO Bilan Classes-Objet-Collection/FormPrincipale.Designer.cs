namespace TP4_POO_Bilan_Classes_Objet_Collection
{
    partial class FormPrincipale
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gERERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterModifierSupprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aFFICHERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUITTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gERERToolStripMenuItem,
            this.aFFICHERToolStripMenuItem,
            this.qUITTERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gERERToolStripMenuItem
            // 
            this.gERERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterModifierSupprimerToolStripMenuItem,
            this.vendreToolStripMenuItem});
            this.gERERToolStripMenuItem.Name = "gERERToolStripMenuItem";
            this.gERERToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.gERERToolStripMenuItem.Text = "GERER";
            // 
            // ajouterModifierSupprimerToolStripMenuItem
            // 
            this.ajouterModifierSupprimerToolStripMenuItem.Name = "ajouterModifierSupprimerToolStripMenuItem";
            this.ajouterModifierSupprimerToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.ajouterModifierSupprimerToolStripMenuItem.Text = "Ajouter/Modifier/Supprimer";
            this.ajouterModifierSupprimerToolStripMenuItem.Click += new System.EventHandler(this.AjouterModifierSupprimerToolStripMenuItem_Click);
            // 
            // vendreToolStripMenuItem
            // 
            this.vendreToolStripMenuItem.Name = "vendreToolStripMenuItem";
            this.vendreToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.vendreToolStripMenuItem.Text = "Vendre";
            // 
            // aFFICHERToolStripMenuItem
            // 
            this.aFFICHERToolStripMenuItem.Name = "aFFICHERToolStripMenuItem";
            this.aFFICHERToolStripMenuItem.Size = new System.Drawing.Size(88, 26);
            this.aFFICHERToolStripMenuItem.Text = "AFFICHER";
            this.aFFICHERToolStripMenuItem.Click += new System.EventHandler(this.AFFICHERToolStripMenuItem_Click);
            // 
            // qUITTERToolStripMenuItem
            // 
            this.qUITTERToolStripMenuItem.Name = "qUITTERToolStripMenuItem";
            this.qUITTERToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.qUITTERToolStripMenuItem.Text = "QUITTER";
            this.qUITTERToolStripMenuItem.Click += new System.EventHandler(this.QUITTERToolStripMenuItem_Click);
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipale";
            this.Text = "Gestion des biens immobiliers";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gERERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterModifierSupprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aFFICHERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUITTERToolStripMenuItem;
    }
}