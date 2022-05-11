using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MysqlAppModel
{
    public partial class Win_Password : Form
    {

        public string RepPassword = string.Empty;

        public Win_Password()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void Btn_AffPassword_Click(object sender, EventArgs e)
        {
            Text_Password.UseSystemPasswordChar = !Text_Password.UseSystemPasswordChar;
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            Valide_Password();
        }


        public void Valide_Password()
        {
            RepPassword = Text_Password.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Win_Password_Load(object sender, EventArgs e)
        {

        }



        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            RepPassword = string.Empty;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Text_Password_Validating(object sender, CancelEventArgs e)
        {
            Btn_Ok.Focus();
        }

        private void Text_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Valide_Password();
            }
        }

        private void Win_Password_Load_1(object sender, EventArgs e)
        {

        }
    }
}
