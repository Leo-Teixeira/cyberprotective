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
    public partial class Win_ClientFiche : Form
    {
        public string ModeAccess = "";
        public string CodeClient = string.Empty;

        public Win_ClientFiche()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Win_ClientFiche_Load(object sender, EventArgs e)
        {
            if (ModeAccess=="UPDATE") { Txt_CodeClient.Enabled = false; };

        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {

            int result;

            if (Txt_CodeClient.Text == string.Empty)
            {
                MessageBox.Show("Merci de saisir un code aphanumerique de votre choix...");
                return;

            }
            ;

            try
            {
                GestClient myclient = new GestClient();

                myclient.codeclient = Txt_CodeClient.Text;
                myclient.nomclient = Txt_NomClient.Text;
                myclient.adresse = Txt_Adresse.Text;
                myclient.codepostal = Txt_CodePostal.Text;
                myclient.ville = Txt_Ville.Text;
                myclient.tel = Txt_Tel.Text;
                myclient.email = Txt_Email.Text;
                myclient.datenaissance = Convert.ToDateTime(Txt_DateNaiss.Text);

                int.TryParse(Txt_NoteMoy.Text, out result);
                myclient.notemoy = result;

                switch (ModeAccess)
                {
                    case "INSERT":
                        myclient.Ajouter();
                        break;
                    case "UPDATE":
                        myclient.Modifier();
                        break;

                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

   
        
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {

            this.Close();


        }

        public void LoadData()
        {

            GestClient myclient = new GestClient();

            myclient.codeclient = this.CodeClient;
            myclient.Lire();

            Txt_CodeClient.Text = myclient.codeclient;
            Txt_NomClient.Text = myclient.nomclient;
            Txt_Adresse.Text = myclient.adresse;
            Txt_CodePostal.Text = myclient.codepostal;
            Txt_Ville.Text = myclient.ville;
            Txt_Tel.Text = myclient.tel;
            Txt_Email.Text = myclient.email;
            Txt_DateNaiss.Text = myclient.datenaissance.ToString("dd/MM/yyyy");
            Txt_NoteMoy.Text = myclient.notemoy.ToString();






        }

        private void Txt_CodeClient_TextChanged(object sender, EventArgs e)
        {
            ChampAlphaNum monCode = new ChampAlphaNum();
            monCode.ScanCible = (TextBox)sender;
            monCode.Valide_TextChanged();
        }

        private void Txt_CodeClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChampAlphaNum monCode = new ChampAlphaNum();
            monCode.ScanCible = (TextBox)sender;
            monCode.eKeyPressEvArg = (KeyPressEventArgs)e;
            monCode.Valide_KeyPress();
        }

        private void Txt_CodePostal_TextChanged(object sender, EventArgs e)
        {
            ChampEntier monCode = new ChampEntier();
            monCode.ScanCible = (TextBox)sender;
            monCode.ValMin = 0;
            monCode.ValMax = 99999;
            monCode.Valide_TextChanged();
        }

        private void Txt_CodePostal_Leave(object sender, EventArgs e)
        {
            ChampEntier monCode = new ChampEntier();
            monCode.ScanCible = (TextBox)sender;
            monCode.ValMin = 0;
            monCode.ValMax = 99999;
            monCode.Valide_Leave();
        }

        private void Txt_Email_Leave(object sender, EventArgs e)
        {
            ChampEMail monCode = new ChampEMail();
            monCode.ScanCible = (TextBox)sender;
            if (monCode.Valide_LostFocus()) return;

            MessageBox.Show("Email Non valide", "Adresse Email invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            monCode.ScanCible.Focus();
        }

        private void Txt_DateNaiss_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChampDate monCode = new ChampDate();
            monCode.ScanCible = (MaskedTextBox)sender;
            monCode.eKeyPressEvArg = (KeyPressEventArgs)e;
            monCode.Valide_KeyPress();
        }

        private void Txt_DateNaiss_Validating(object sender, EventArgs e)
        {
            ChampDate monCode = new ChampDate();
            monCode.ScanCible = (MaskedTextBox)sender;
            monCode.eCancelEvArgs = (CancelEventArgs)e;
            monCode.Valide_Validating();
        }

        private void Txt_DateNaiss_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    } 

}

 

