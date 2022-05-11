namespace MysqlAppModel
{
    partial class Win_Password
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
            this.Btn_AffPassword = new System.Windows.Forms.Button();
            this.Lab_Password = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Text_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_AffPassword
            // 
            this.Btn_AffPassword.Location = new System.Drawing.Point(335, 16);
            this.Btn_AffPassword.Name = "Btn_AffPassword";
            this.Btn_AffPassword.Size = new System.Drawing.Size(25, 23);
            this.Btn_AffPassword.TabIndex = 9;
            this.Btn_AffPassword.Text = "?";
            this.Btn_AffPassword.UseVisualStyleBackColor = true;
            this.Btn_AffPassword.Click += new System.EventHandler(this.Btn_AffPassword_Click);
            // 
            // Lab_Password
            // 
            this.Lab_Password.AutoSize = true;
            this.Lab_Password.Location = new System.Drawing.Point(12, 22);
            this.Lab_Password.Name = "Lab_Password";
            this.Lab_Password.Size = new System.Drawing.Size(77, 13);
            this.Lab_Password.TabIndex = 8;
            this.Lab_Password.Text = "Mot de passe :";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(284, 65);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(76, 25);
            this.Btn_Cancel.TabIndex = 7;
            this.Btn_Cancel.Text = "Annuler";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(202, 65);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(76, 25);
            this.Btn_Ok.TabIndex = 6;
            this.Btn_Ok.Text = "Ok";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Text_Password
            // 
            this.Text_Password.Location = new System.Drawing.Point(100, 18);
            this.Text_Password.MaxLength = 32;
            this.Text_Password.Name = "Text_Password";
            this.Text_Password.Size = new System.Drawing.Size(235, 20);
            this.Text_Password.TabIndex = 5;
            this.Text_Password.UseSystemPasswordChar = true;
            // 
            // Win_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 107);
            this.Controls.Add(this.Btn_AffPassword);
            this.Controls.Add(this.Lab_Password);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Text_Password);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(388, 146);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(388, 146);
            this.Name = "Win_Password";
            this.Text = "Win_Password";
            this.Load += new System.EventHandler(this.Win_Password_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_AffPassword;
        private System.Windows.Forms.Label Lab_Password;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.TextBox Text_Password;
    }
}