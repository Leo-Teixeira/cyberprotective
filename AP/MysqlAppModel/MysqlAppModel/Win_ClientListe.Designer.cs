namespace MysqlAppModel
{
    partial class Win_ClientListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Win_ClientListe));
            this.TStrip_Main = new System.Windows.Forms.ToolStrip();
            this.TBtn_Tous = new System.Windows.Forms.ToolStripButton();
            this.TBtn_Cherche = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TBtn_Ajouter = new System.Windows.Forms.ToolStripButton();
            this.TBtn_Modifier = new System.Windows.Forms.ToolStripButton();
            this.TBtn_Suprimer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.GBox_Criteres = new System.Windows.Forms.GroupBox();
            this.Txt_NomClient = new System.Windows.Forms.TextBox();
            this.Lab_NomClient = new System.Windows.Forms.Label();
            this.GBox_Result = new System.Windows.Forms.GroupBox();
            this.DGrid_Result = new System.Windows.Forms.DataGridView();
            this.TStrip_Main.SuspendLayout();
            this.GBox_Criteres.SuspendLayout();
            this.GBox_Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGrid_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // TStrip_Main
            // 
            this.TStrip_Main.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.TStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TBtn_Tous,
            this.TBtn_Cherche,
            this.toolStripSeparator1,
            this.TBtn_Ajouter,
            this.TBtn_Modifier,
            this.TBtn_Suprimer,
            this.toolStripSeparator2});
            this.TStrip_Main.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.TStrip_Main.MinimumSize = new System.Drawing.Size(0, 61);
            this.TStrip_Main.Name = "TStrip_Main";
            this.TStrip_Main.Size = new System.Drawing.Size(684, 61);
            this.TStrip_Main.Stretch = true;
            this.TStrip_Main.TabIndex = 0;
            this.TStrip_Main.Text = "toolStrip1";
            // 
            // TBtn_Tous
            // 
            this.TBtn_Tous.Image = ((System.Drawing.Image)(resources.GetObject("TBtn_Tous.Image")));
            this.TBtn_Tous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtn_Tous.Name = "TBtn_Tous";
            this.TBtn_Tous.Size = new System.Drawing.Size(52, 58);
            this.TBtn_Tous.Tag = "Affiche tous les enregistrements";
            this.TBtn_Tous.Text = "Tous";
            this.TBtn_Tous.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TBtn_Tous.ToolTipText = "Tous";
            this.TBtn_Tous.Click += new System.EventHandler(this.TBtn_Tous_Click);
            // 
            // TBtn_Cherche
            // 
            this.TBtn_Cherche.Image = ((System.Drawing.Image)(resources.GetObject("TBtn_Cherche.Image")));
            this.TBtn_Cherche.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtn_Cherche.Name = "TBtn_Cherche";
            this.TBtn_Cherche.Size = new System.Drawing.Size(59, 58);
            this.TBtn_Cherche.Tag = "Chercher";
            this.TBtn_Cherche.Text = "Chercher";
            this.TBtn_Cherche.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TBtn_Cherche.Click += new System.EventHandler(this.TBtn_Cherche_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 61);
            // 
            // TBtn_Ajouter
            // 
            this.TBtn_Ajouter.AutoSize = false;
            this.TBtn_Ajouter.Image = ((System.Drawing.Image)(resources.GetObject("TBtn_Ajouter.Image")));
            this.TBtn_Ajouter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtn_Ajouter.Name = "TBtn_Ajouter";
            this.TBtn_Ajouter.Size = new System.Drawing.Size(66, 61);
            this.TBtn_Ajouter.Tag = "Ajouter un client";
            this.TBtn_Ajouter.Text = "Ajouter";
            this.TBtn_Ajouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TBtn_Ajouter.Click += new System.EventHandler(this.TBtn_Ajouter_Click);
            // 
            // TBtn_Modifier
            // 
            this.TBtn_Modifier.Image = ((System.Drawing.Image)(resources.GetObject("TBtn_Modifier.Image")));
            this.TBtn_Modifier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtn_Modifier.Name = "TBtn_Modifier";
            this.TBtn_Modifier.Size = new System.Drawing.Size(56, 58);
            this.TBtn_Modifier.Tag = "Modification";
            this.TBtn_Modifier.Text = "Modifier";
            this.TBtn_Modifier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TBtn_Modifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TBtn_Modifier.ToolTipText = "Modifier";
            this.TBtn_Modifier.Click += new System.EventHandler(this.TBtn_Modifier_Click);
            // 
            // TBtn_Suprimer
            // 
            this.TBtn_Suprimer.Image = ((System.Drawing.Image)(resources.GetObject("TBtn_Suprimer.Image")));
            this.TBtn_Suprimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtn_Suprimer.Name = "TBtn_Suprimer";
            this.TBtn_Suprimer.Size = new System.Drawing.Size(66, 58);
            this.TBtn_Suprimer.Tag = "Suppression";
            this.TBtn_Suprimer.Text = "Supprimer";
            this.TBtn_Suprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TBtn_Suprimer.Click += new System.EventHandler(this.TBtn_Suprimer_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 61);
            // 
            // GBox_Criteres
            // 
            this.GBox_Criteres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBox_Criteres.Controls.Add(this.Txt_NomClient);
            this.GBox_Criteres.Controls.Add(this.Lab_NomClient);
            this.GBox_Criteres.Location = new System.Drawing.Point(13, 67);
            this.GBox_Criteres.Name = "GBox_Criteres";
            this.GBox_Criteres.Size = new System.Drawing.Size(659, 51);
            this.GBox_Criteres.TabIndex = 1;
            this.GBox_Criteres.TabStop = false;
            this.GBox_Criteres.Text = "Critères de recherche";
            // 
            // Txt_NomClient
            // 
            this.Txt_NomClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomClient.Location = new System.Drawing.Point(70, 18);
            this.Txt_NomClient.MaxLength = 70;
            this.Txt_NomClient.Name = "Txt_NomClient";
            this.Txt_NomClient.Size = new System.Drawing.Size(583, 20);
            this.Txt_NomClient.TabIndex = 30;
            // 
            // Lab_NomClient
            // 
            this.Lab_NomClient.AutoSize = true;
            this.Lab_NomClient.Location = new System.Drawing.Point(6, 21);
            this.Lab_NomClient.Name = "Lab_NomClient";
            this.Lab_NomClient.Size = new System.Drawing.Size(58, 13);
            this.Lab_NomClient.TabIndex = 31;
            this.Lab_NomClient.Text = "Nom Client";
            this.Lab_NomClient.Click += new System.EventHandler(this.Lab_NomClient_Click);
            // 
            // GBox_Result
            // 
            this.GBox_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBox_Result.Controls.Add(this.DGrid_Result);
            this.GBox_Result.Location = new System.Drawing.Point(13, 124);
            this.GBox_Result.Name = "GBox_Result";
            this.GBox_Result.Size = new System.Drawing.Size(659, 355);
            this.GBox_Result.TabIndex = 2;
            this.GBox_Result.TabStop = false;
            this.GBox_Result.Text = "Résultats";
            // 
            // DGrid_Result
            // 
            this.DGrid_Result.AllowUserToAddRows = false;
            this.DGrid_Result.AllowUserToDeleteRows = false;
            this.DGrid_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGrid_Result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGrid_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGrid_Result.Location = new System.Drawing.Point(6, 19);
            this.DGrid_Result.MultiSelect = false;
            this.DGrid_Result.Name = "DGrid_Result";
            this.DGrid_Result.ReadOnly = true;
            this.DGrid_Result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGrid_Result.Size = new System.Drawing.Size(647, 330);
            this.DGrid_Result.TabIndex = 0;
            this.DGrid_Result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGrid_Result_CellContentClick);
            this.DGrid_Result.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGrid_Result_CellContentDoubleClick);
            this.DGrid_Result.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGrid_Result_RowHeaderMouseDoubleClick);
            this.DGrid_Result.SelectionChanged += new System.EventHandler(this.DGrid_Result_SelectionChanged);
            // 
            // Win_ClientListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 491);
            this.Controls.Add(this.GBox_Result);
            this.Controls.Add(this.GBox_Criteres);
            this.Controls.Add(this.TStrip_Main);
            this.MinimumSize = new System.Drawing.Size(700, 530);
            this.Name = "Win_ClientListe";
            this.Text = "Liste des clients";
            this.Load += new System.EventHandler(this.Win_ClientListe_Load);
            this.TStrip_Main.ResumeLayout(false);
            this.TStrip_Main.PerformLayout();
            this.GBox_Criteres.ResumeLayout(false);
            this.GBox_Criteres.PerformLayout();
            this.GBox_Result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGrid_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TStrip_Main;
        private System.Windows.Forms.ToolStripButton TBtn_Ajouter;
        private System.Windows.Forms.ToolStripButton TBtn_Tous;
        private System.Windows.Forms.ToolStripButton TBtn_Suprimer;
        private System.Windows.Forms.ToolStripButton TBtn_Modifier;
        private System.Windows.Forms.ToolStripButton TBtn_Cherche;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox GBox_Criteres;
        private System.Windows.Forms.GroupBox GBox_Result;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView DGrid_Result;
        private System.Windows.Forms.TextBox Txt_NomClient;
        private System.Windows.Forms.Label Lab_NomClient;
    }
}