namespace MysqlAppModel
{
    partial class Win_Bienvenue
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Win_Bienvenue));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_Database = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Connecter = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Deconnecter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_ParamBDD = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Infos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Tables = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ClientListe = new System.Windows.Forms.ToolStripMenuItem();
            this.Lab_InfoCnx = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Database,
            this.TSMI_Tables});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Database
            // 
            this.TSMI_Database.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Connecter,
            this.TSMI_Deconnecter,
            this.toolStripSeparator1,
            this.TSMI_ParamBDD,
            this.TSMI_Infos,
            this.toolStripSeparator2,
            this.TSMI_Quitter});
            this.TSMI_Database.Name = "TSMI_Database";
            this.TSMI_Database.Size = new System.Drawing.Size(107, 20);
            this.TSMI_Database.Text = "Base de données";

            // 
            // TSMI_Connecter
            // 
            this.TSMI_Connecter.Name = "TSMI_Connecter";
            this.TSMI_Connecter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.TSMI_Connecter.Size = new System.Drawing.Size(186, 22);
            this.TSMI_Connecter.Text = "Connexion";
            this.TSMI_Connecter.Click += new System.EventHandler(this.TSMI_Connecter_Click);
            // 
            // TSMI_Deconnecter
            // 
            this.TSMI_Deconnecter.Enabled = false;
            this.TSMI_Deconnecter.Name = "TSMI_Deconnecter";
            this.TSMI_Deconnecter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.TSMI_Deconnecter.Size = new System.Drawing.Size(186, 22);
            this.TSMI_Deconnecter.Text = "Déconnexion";
            this.TSMI_Deconnecter.Click += new System.EventHandler(this.TSMI_Deconnecter_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // TSMI_ParamBDD
            // 
            this.TSMI_ParamBDD.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_ParamBDD.Image")));
            this.TSMI_ParamBDD.Name = "TSMI_ParamBDD";
            this.TSMI_ParamBDD.Size = new System.Drawing.Size(186, 22);
            this.TSMI_ParamBDD.Text = "Parametres";
            this.TSMI_ParamBDD.Click += new System.EventHandler(this.TSMI_ParamBDD_Click);
            // 
            // TSMI_Infos
            // 
            this.TSMI_Infos.Name = "TSMI_Infos";
            this.TSMI_Infos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.TSMI_Infos.Size = new System.Drawing.Size(186, 22);
            this.TSMI_Infos.Text = "Informations";
            this.TSMI_Infos.Click += new System.EventHandler(this.TSMI_Infos_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // TSMI_Quitter
            // 
            this.TSMI_Quitter.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Quitter.Image")));
            this.TSMI_Quitter.Name = "TSMI_Quitter";
            this.TSMI_Quitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.TSMI_Quitter.Size = new System.Drawing.Size(186, 22);
            this.TSMI_Quitter.Text = "Quitter";
            this.TSMI_Quitter.Click += new System.EventHandler(this.TSMI_Quitter_Click);
            // 
            // TSMI_Tables
            // 
            this.TSMI_Tables.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ClientListe});
            this.TSMI_Tables.Enabled = false;
            this.TSMI_Tables.Name = "TSMI_Tables";
            this.TSMI_Tables.Size = new System.Drawing.Size(51, 20);
            this.TSMI_Tables.Text = "Tables";
            // 
            // TSMI_ClientListe
            // 
            this.TSMI_ClientListe.Name = "TSMI_ClientListe";
            this.TSMI_ClientListe.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad1)));
            this.TSMI_ClientListe.Size = new System.Drawing.Size(197, 22);
            this.TSMI_ClientListe.Text = "Clients";
            this.TSMI_ClientListe.Click += new System.EventHandler(this.TSMI_ClientListe_Click);
            // 
            // Lab_InfoCnx
            // 
            this.Lab_InfoCnx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_InfoCnx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lab_InfoCnx.Location = new System.Drawing.Point(13, 178);
            this.Lab_InfoCnx.Name = "Lab_InfoCnx";
            this.Lab_InfoCnx.Size = new System.Drawing.Size(539, 16);
            this.Lab_InfoCnx.TabIndex = 1;
            this.Lab_InfoCnx.Text = "Vous n\'êtes pas connecté.";
            // 
            // Win_Bienvenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 203);
            this.Controls.Add(this.Lab_InfoCnx);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Win_Bienvenue";
            this.Text = "Application model mysql";
            this.Load += new System.EventHandler(this.Win_Bienvenue_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Database;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Connecter;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Deconnecter;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Infos;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Tables;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ClientListe;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Quitter;
        private System.Windows.Forms.Label Lab_InfoCnx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ParamBDD;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

