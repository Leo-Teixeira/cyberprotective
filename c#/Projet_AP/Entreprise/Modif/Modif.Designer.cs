namespace Projet_AP.Entreprise.Modif
{
    partial class Modif
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
            this.lbModif = new System.Windows.Forms.ListBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.mainMenuStrip1 = new Projet_AP.Control.MainMenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.rbAct = new System.Windows.Forms.RadioButton();
            this.rbDesc = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modification d\'une entreprise";
            // 
            // lbModif
            // 
            this.lbModif.FormattingEnabled = true;
            this.lbModif.ItemHeight = 31;
            this.lbModif.Location = new System.Drawing.Point(180, 232);
            this.lbModif.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbModif.Name = "lbModif";
            this.lbModif.Size = new System.Drawing.Size(236, 159);
            this.lbModif.TabIndex = 1;
            this.lbModif.SelectedIndexChanged += new System.EventHandler(this.LbModif_SelectedIndexChanged);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(616, 542);
            this.btnModif.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(222, 99);
            this.btnModif.TabIndex = 2;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.BtnModif_Click);
            // 
            // mainMenuStrip1
            // 
            this.mainMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip1.Name = "mainMenuStrip1";
            this.mainMenuStrip1.Padding = new System.Windows.Forms.Padding(16, 4, 0, 4);
            this.mainMenuStrip1.Size = new System.Drawing.Size(1600, 32);
            this.mainMenuStrip1.TabIndex = 3;
            this.mainMenuStrip1.Text = "mainMenuStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(866, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom de l\'entreprise";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(1168, 227);
            this.tbNom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(196, 38);
            this.tbNom.TabIndex = 5;
            // 
            // rbAct
            // 
            this.rbAct.AutoSize = true;
            this.rbAct.Location = new System.Drawing.Point(872, 327);
            this.rbAct.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbAct.Name = "rbAct";
            this.rbAct.Size = new System.Drawing.Size(161, 36);
            this.rbAct.TabIndex = 6;
            this.rbAct.TabStop = true;
            this.rbAct.Text = "Activation";
            this.rbAct.UseVisualStyleBackColor = true;
            // 
            // rbDesc
            // 
            this.rbDesc.AutoSize = true;
            this.rbDesc.Location = new System.Drawing.Point(1148, 327);
            this.rbDesc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbDesc.Name = "rbDesc";
            this.rbDesc.Size = new System.Drawing.Size(208, 36);
            this.rbDesc.TabIndex = 7;
            this.rbDesc.TabStop = true;
            this.rbDesc.Text = "Desactivation";
            this.rbDesc.UseVisualStyleBackColor = true;
            // 
            // Modif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.rbDesc);
            this.Controls.Add(this.rbAct);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.lbModif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.mainMenuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Modif";
            this.Text = "Modif";
            this.Load += new System.EventHandler(this.Modif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbModif;
        private System.Windows.Forms.Button btnModif;
        private Control.MainMenuStrip mainMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.RadioButton rbAct;
        private System.Windows.Forms.RadioButton rbDesc;
    }
}