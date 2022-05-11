namespace Projet_AP.Adherent.Modif
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
            this.lbAdherent = new System.Windows.Forms.ListBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.mainMenuStrip1 = new Projet_AP.Control.MainMenuStrip();
            this.cbMedaille = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbListEntreprise = new System.Windows.Forms.ComboBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbDesc = new System.Windows.Forms.RadioButton();
            this.rbAct = new System.Windows.Forms.RadioButton();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPadherent = new System.Windows.Forms.TextBox();
            this.tbNadherent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(527, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifier un adherent";
            // 
            // lbAdherent
            // 
            this.lbAdherent.FormattingEnabled = true;
            this.lbAdherent.ItemHeight = 16;
            this.lbAdherent.Location = new System.Drawing.Point(398, 142);
            this.lbAdherent.Name = "lbAdherent";
            this.lbAdherent.Size = new System.Drawing.Size(120, 84);
            this.lbAdherent.TabIndex = 1;
            this.lbAdherent.SelectedIndexChanged += new System.EventHandler(this.LbAdherent_SelectedIndexChanged);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(530, 347);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(153, 47);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // mainMenuStrip1
            // 
            this.mainMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip1.Name = "mainMenuStrip1";
            this.mainMenuStrip1.Size = new System.Drawing.Size(1258, 30);
            this.mainMenuStrip1.TabIndex = 3;
            this.mainMenuStrip1.Text = "mainMenuStrip1";
            // 
            // cbMedaille
            // 
            this.cbMedaille.FormattingEnabled = true;
            this.cbMedaille.Location = new System.Drawing.Point(868, 253);
            this.cbMedaille.Name = "cbMedaille";
            this.cbMedaille.Size = new System.Drawing.Size(132, 24);
            this.cbMedaille.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(715, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "Medaille de l\'adherent";
            // 
            // cbListEntreprise
            // 
            this.cbListEntreprise.FormattingEnabled = true;
            this.cbListEntreprise.Location = new System.Drawing.Point(868, 157);
            this.cbListEntreprise.Name = "cbListEntreprise";
            this.cbListEntreprise.Size = new System.Drawing.Size(132, 24);
            this.cbListEntreprise.TabIndex = 53;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(868, 217);
            this.tbMail.Margin = new System.Windows.Forms.Padding(4);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(132, 22);
            this.tbMail.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(720, 221);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Email de l\'adherent";
            // 
            // rbDesc
            // 
            this.rbDesc.AutoSize = true;
            this.rbDesc.Location = new System.Drawing.Point(914, 282);
            this.rbDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbDesc.Name = "rbDesc";
            this.rbDesc.Size = new System.Drawing.Size(55, 21);
            this.rbDesc.TabIndex = 50;
            this.rbDesc.TabStop = true;
            this.rbDesc.Text = "Non";
            this.rbDesc.UseVisualStyleBackColor = true;
            // 
            // rbAct
            // 
            this.rbAct.AutoSize = true;
            this.rbAct.Location = new System.Drawing.Point(837, 282);
            this.rbAct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAct.Name = "rbAct";
            this.rbAct.Size = new System.Drawing.Size(51, 21);
            this.rbAct.TabIndex = 49;
            this.rbAct.TabStop = true;
            this.rbAct.Text = "Oui";
            this.rbAct.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(868, 186);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(132, 22);
            this.tbPassword.TabIndex = 48;
            // 
            // tbPadherent
            // 
            this.tbPadherent.Location = new System.Drawing.Point(868, 127);
            this.tbPadherent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPadherent.Name = "tbPadherent";
            this.tbPadherent.Size = new System.Drawing.Size(132, 22);
            this.tbPadherent.TabIndex = 47;
            // 
            // tbNadherent
            // 
            this.tbNadherent.Location = new System.Drawing.Point(868, 98);
            this.tbNadherent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNadherent.Name = "tbNadherent";
            this.tbNadherent.Size = new System.Drawing.Size(132, 22);
            this.tbNadherent.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(721, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Activation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(721, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(720, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Nom de l\'entreprise";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(721, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Prenom de l\'adherent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(725, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nom de l\'adherent";
            // 
            // Modif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1258, 450);
            this.Controls.Add(this.cbMedaille);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbListEntreprise);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbDesc);
            this.Controls.Add(this.rbAct);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbPadherent);
            this.Controls.Add(this.tbNadherent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lbAdherent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenuStrip1);
            this.MainMenuStrip = this.mainMenuStrip1;
            this.Name = "Modif";
            this.Text = "Modif";
            this.Load += new System.EventHandler(this.Modif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAdherent;
        private System.Windows.Forms.Button btnModifier;
        private Control.MainMenuStrip mainMenuStrip1;
        private System.Windows.Forms.ComboBox cbMedaille;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbListEntreprise;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbDesc;
        private System.Windows.Forms.RadioButton rbAct;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbPadherent;
        private System.Windows.Forms.TextBox tbNadherent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}