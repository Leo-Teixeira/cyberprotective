namespace MysqlAppModel
{
    partial class Win_CnxParam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Win_CnxParam));
            this.Text_ProgPassword = new System.Windows.Forms.TextBox();
            this.Lab_ProgPassword = new System.Windows.Forms.Label();
            this.Text_LoginProg = new System.Windows.Forms.TextBox();
            this.Lab_LoginProg = new System.Windows.Forms.Label();
            this.Text_MainDatabase = new System.Windows.Forms.TextBox();
            this.Lab_MainDatabase = new System.Windows.Forms.Label();
            this.Text_Port = new System.Windows.Forms.TextBox();
            this.Lab_Port = new System.Windows.Forms.Label();
            this.Text_AdresseIP = new System.Windows.Forms.TextBox();
            this.Lab_AdresseIP = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_ProgPassword
            // 
            this.Text_ProgPassword.Location = new System.Drawing.Point(170, 138);
            this.Text_ProgPassword.MaxLength = 128;
            this.Text_ProgPassword.Name = "Text_ProgPassword";
            this.Text_ProgPassword.Size = new System.Drawing.Size(194, 20);
            this.Text_ProgPassword.TabIndex = 32;
            this.Text_ProgPassword.UseSystemPasswordChar = true;
            // 
            // Lab_ProgPassword
            // 
            this.Lab_ProgPassword.AutoSize = true;
            this.Lab_ProgPassword.Location = new System.Drawing.Point(7, 145);
            this.Lab_ProgPassword.Name = "Lab_ProgPassword";
            this.Lab_ProgPassword.Size = new System.Drawing.Size(77, 13);
            this.Lab_ProgPassword.TabIndex = 31;
            this.Lab_ProgPassword.Text = "Mot de passe :";
            // 
            // Text_LoginProg
            // 
            this.Text_LoginProg.Location = new System.Drawing.Point(170, 111);
            this.Text_LoginProg.MaxLength = 128;
            this.Text_LoginProg.Name = "Text_LoginProg";
            this.Text_LoginProg.Size = new System.Drawing.Size(194, 20);
            this.Text_LoginProg.TabIndex = 30;
            // 
            // Lab_LoginProg
            // 
            this.Lab_LoginProg.AutoSize = true;
            this.Lab_LoginProg.Location = new System.Drawing.Point(7, 118);
            this.Lab_LoginProg.Name = "Lab_LoginProg";
            this.Lab_LoginProg.Size = new System.Drawing.Size(59, 13);
            this.Lab_LoginProg.TabIndex = 29;
            this.Lab_LoginProg.Text = "Identifiant :";
            // 
            // Text_MainDatabase
            // 
            this.Text_MainDatabase.Location = new System.Drawing.Point(170, 76);
            this.Text_MainDatabase.MaxLength = 128;
            this.Text_MainDatabase.Name = "Text_MainDatabase";
            this.Text_MainDatabase.Size = new System.Drawing.Size(194, 20);
            this.Text_MainDatabase.TabIndex = 28;
            // 
            // Lab_MainDatabase
            // 
            this.Lab_MainDatabase.AutoSize = true;
            this.Lab_MainDatabase.Location = new System.Drawing.Point(7, 83);
            this.Lab_MainDatabase.Name = "Lab_MainDatabase";
            this.Lab_MainDatabase.Size = new System.Drawing.Size(120, 13);
            this.Lab_MainDatabase.TabIndex = 27;
            this.Lab_MainDatabase.Text = "Nom base de données :";
            // 
            // Text_Port
            // 
            this.Text_Port.Location = new System.Drawing.Point(170, 38);
            this.Text_Port.MaxLength = 5;
            this.Text_Port.Name = "Text_Port";
            this.Text_Port.Size = new System.Drawing.Size(40, 20);
            this.Text_Port.TabIndex = 26;
            // 
            // Lab_Port
            // 
            this.Lab_Port.AutoSize = true;
            this.Lab_Port.Location = new System.Drawing.Point(7, 45);
            this.Lab_Port.Name = "Lab_Port";
            this.Lab_Port.Size = new System.Drawing.Size(32, 13);
            this.Lab_Port.TabIndex = 25;
            this.Lab_Port.Text = "Port :";
            // 
            // Text_AdresseIP
            // 
            this.Text_AdresseIP.Location = new System.Drawing.Point(170, 12);
            this.Text_AdresseIP.MaxLength = 256;
            this.Text_AdresseIP.Name = "Text_AdresseIP";
            this.Text_AdresseIP.Size = new System.Drawing.Size(194, 20);
            this.Text_AdresseIP.TabIndex = 24;
            // 
            // Lab_AdresseIP
            // 
            this.Lab_AdresseIP.AutoSize = true;
            this.Lab_AdresseIP.Location = new System.Drawing.Point(7, 19);
            this.Lab_AdresseIP.Name = "Lab_AdresseIP";
            this.Lab_AdresseIP.Size = new System.Drawing.Size(64, 13);
            this.Lab_AdresseIP.TabIndex = 23;
            this.Lab_AdresseIP.Text = "Adresse IP :";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(289, 178);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 22;
            this.Btn_Cancel.Text = "Annuler";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(208, 178);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 23);
            this.Btn_OK.TabIndex = 21;
            this.Btn_OK.Text = "OK";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Win_CnxParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 217);
            this.Controls.Add(this.Text_ProgPassword);
            this.Controls.Add(this.Lab_ProgPassword);
            this.Controls.Add(this.Text_LoginProg);
            this.Controls.Add(this.Lab_LoginProg);
            this.Controls.Add(this.Text_MainDatabase);
            this.Controls.Add(this.Lab_MainDatabase);
            this.Controls.Add(this.Text_Port);
            this.Controls.Add(this.Lab_Port);
            this.Controls.Add(this.Text_AdresseIP);
            this.Controls.Add(this.Lab_AdresseIP);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(395, 256);
            this.MinimumSize = new System.Drawing.Size(395, 256);
            this.Name = "Win_CnxParam";
            this.Text = "Parametres Base de données";
            this.Load += new System.EventHandler(this.Win_CnxParam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Text_ProgPassword;
        private System.Windows.Forms.Label Lab_ProgPassword;
        private System.Windows.Forms.TextBox Text_LoginProg;
        private System.Windows.Forms.Label Lab_LoginProg;
        private System.Windows.Forms.TextBox Text_MainDatabase;
        private System.Windows.Forms.Label Lab_MainDatabase;
        private System.Windows.Forms.TextBox Text_Port;
        private System.Windows.Forms.Label Lab_Port;
        private System.Windows.Forms.TextBox Text_AdresseIP;
        private System.Windows.Forms.Label Lab_AdresseIP;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
    }
}