using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;



namespace MysqlAppModel
{
    public partial class Win_Bienvenue : Form
    {
        public Win_Bienvenue()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {

                return Quitter_Prog();


            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void TSMI_Connecter_Click(object sender, EventArgs e)
        {
            try
            {

                GestMysql.verbose = true ;
                if ( ! GestMysql.Connecter() )
                {
                    Lab_InfoCnx.Text = "Info : Echec connexion ";
                    Lab_InfoCnx.ForeColor = Color.Black;
                    return ;
                }

                Lab_InfoCnx.Text = "Connecté à " + GestMysql.Cnx_Database + "@" + GestMysql.Cnx_Server + ":" + GestMysql.Cnx_MysqlPort + ", avec Identifiant : " + GestMysql.Cnx_UserId  ;
                Lab_InfoCnx.ForeColor = Color.Green;

                TSMI_Tables.Enabled = true  ;
                TSMI_Connecter.Enabled   = false ;
                TSMI_ParamBDD.Enabled    = false ;
                TSMI_Deconnecter.Enabled = true  ;
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                TSMI_Tables.Enabled = false;

            }
        }

        private void TSMI_Deconnecter_Click(object sender, EventArgs e)
        {
            TSMI_Deconnecter.Enabled = false;
            TSMI_Connecter.Enabled = false;

            try
            {
                GestMysql.Deconnecter();
                GestMysql.Cnx_Mysql.Close();
                TSMI_Tables.Enabled = false ;
                TSMI_Connecter.Enabled   = true  ;
                TSMI_ParamBDD.Enabled    = true  ;
                TSMI_Deconnecter.Enabled = false ;
                Lab_InfoCnx.Text = "Vous n'êtes pas connecté.";
                Lab_InfoCnx.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }



        private void Win_Bienvenue_Load(object sender, EventArgs e)
        {
            GestParam.Load_Setting2Param();
        }

        private void TSMI_Infos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Serveur : "     + GestParam.Param_Server+ ":" + GestParam.Param_MysqlPort + Environment.NewLine 
                          + "Identifiant : " + GestParam.Param_UserId + Environment.NewLine 
                          + "Base de données : "    + GestParam.Param_MainDatabase + Environment.NewLine 
                          ,"Informations de connexion"
                          ,MessageBoxButtons.OK
                          ,MessageBoxIcon.Information);
        }

        private void TSMI_Quitter_Click(object sender, EventArgs e)
        {

            Quitter_Prog();

        }

        private bool Quitter_Prog()
        {
            DialogResult dialog = MessageBox.Show("Etes vous certain de vouloir fermer cette application ?", "Quitter le programme", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                GestMysql.Deconnecter();
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                return true;
            }

            return false;

        }

        private void TSMI_ParamBDD_Click(object sender, EventArgs e)
        {

            Win_CnxParam iWin_CnxParam = new Win_CnxParam();
            iWin_CnxParam.ShowDialog();

        }



        private void TSMI_ClientListe_Click(object sender, EventArgs e)
        {
            Win_ClientListe iWin_ClientListe =new Win_ClientListe();
            iWin_ClientListe.ShowDialog();
        }


    }
}
