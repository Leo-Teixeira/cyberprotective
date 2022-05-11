namespace TP4_POO_Bilan_Classes_Objet_Collection
{
    partial class Afficher
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
            this.dgvImmo = new System.Windows.Forms.DataGridView();
            this.cbAfficher = new System.Windows.Forms.ComboBox();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImmo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImmo
            // 
            this.dgvImmo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImmo.Location = new System.Drawing.Point(32, 162);
            this.dgvImmo.Name = "dgvImmo";
            this.dgvImmo.RowHeadersWidth = 51;
            this.dgvImmo.RowTemplate.Height = 24;
            this.dgvImmo.Size = new System.Drawing.Size(710, 150);
            this.dgvImmo.TabIndex = 0;
            this.dgvImmo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImmo_CellContentClick);
            // 
            // cbAfficher
            // 
            this.cbAfficher.FormattingEnabled = true;
            this.cbAfficher.Location = new System.Drawing.Point(259, 103);
            this.cbAfficher.Name = "cbAfficher";
            this.cbAfficher.Size = new System.Drawing.Size(240, 24);
            this.cbAfficher.TabIndex = 1;
            this.cbAfficher.SelectedIndexChanged += new System.EventHandler(this.cbAfficher_SelectedIndexChanged);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(336, 340);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 2;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // Afficher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.cbAfficher);
            this.Controls.Add(this.dgvImmo);
            this.Name = "Afficher";
            this.Text = "Afficher";
            this.Load += new System.EventHandler(this.Afficher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImmo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImmo;
        private System.Windows.Forms.ComboBox cbAfficher;
        private System.Windows.Forms.Button btnFermer;
    }
}