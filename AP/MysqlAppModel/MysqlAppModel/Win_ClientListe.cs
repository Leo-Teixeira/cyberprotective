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
using System.Data.SqlClient;

namespace MysqlAppModel
{
    public partial class Win_ClientListe : Form
    {
        public Win_ClientListe()
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

        private void TBtn_Cherche_Click(object sender, EventArgs e)
        {
            if (Txt_NomClient.Text.Trim() != string.Empty ) {
                MajDataSource_Tableau("SELECT * FROM client WHERE  nomclient LIKE @Param_NomClient ");
                return;
            }
        

            MajDataSource_Tableau("SELECT * FROM client");

        }

        private void TBtn_Tous_Click(object sender, EventArgs e)
        {
            MajDataSource_Tableau("SELECT * FROM client");
        }
        


        private void TBtn_Ajouter_Click(object sender, EventArgs e)
        {
            Ouvre_Fiche("INSERT");
        }

        private void TBtn_Modifier_Click(object sender, EventArgs e)
        {
            Ouvre_Fiche("UPDATE");
        }

        private void TBtn_Suprimer_Click(object sender, EventArgs e)
        {
    
                SuppressionClient();
           
      
        }
        
        private void TLab_Navig_Click(object sender, EventArgs e)
        {

        }

        private void TCmBox_NbrEnreg_Click(object sender, EventArgs e)
        {

        }

        private void TBtn_Preced_Click(object sender, EventArgs e)
        {

        }

        private void TBtn_Suivant_Click(object sender, EventArgs e)
        {

        }

        private void Win_ClientListe_Load(object sender, EventArgs e)
        {
            MajDataSource_Tableau("SELECT * FROM client");
        }

        private void Lab_NomClient_Click(object sender, EventArgs e)
        {

        }

        private void MajDataSource_Tableau(string Query)
        {
            if (DGrid_Result.DataSource != null) { DGrid_Result.DataSource = null; } else { DGrid_Result.Rows.Clear(); }

            try
            {

                MySqlCommand MyCommand = new MySqlCommand(Query, GestMysql.Cnx_Mysql);

                MyCommand.Prepare();
                
                MySqlParameter Param_NomClient = new MySqlParameter("@Param_NomClient", MySqlDbType.VarChar);
                Param_NomClient.Value  = "%"+Txt_NomClient.Text+"%" ;
                Param_NomClient.Direction = ParameterDirection.Output;
                MyCommand.Parameters.Add(Param_NomClient);

                GBox_Result.Visible = false;
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                DGrid_Result.DataSource = dTable;
                GBox_Result.Visible = true;

                DGrid_Result.Focus();

            }
            catch (Exception ex)
            {
                GBox_Result.Visible = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void Ouvre_Fiche(string ModeAccess="UPDATE")
        {

            int firstRowIndex;
            string NumClient = string.Empty;

            if (DGrid_Result.SelectedRows.Count == 0 && ModeAccess != "INSERT")
            {
                return;
            }

            if (DGrid_Result.SelectedRows.Count > 0 )
            {
                firstRowIndex = DGrid_Result.SelectedRows.Count - 1;
                NumClient     = DGrid_Result.SelectedRows[firstRowIndex].Cells[0].Value.ToString();
            }

            Win_ClientFiche maFicheClient = new Win_ClientFiche();
            maFicheClient.ModeAccess = ModeAccess;
            maFicheClient.CodeClient = NumClient;

            if (ModeAccess != "INSERT")
            {
                maFicheClient.LoadData();
            }

            maFicheClient.ShowDialog();



           

        }

        private void SuppressionClient()
        {
            String Query = string.Empty;
            int firstRowIndex;
            string NumClient = string.Empty;

            if (DGrid_Result.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectionnez l'enregistrement que vous desirez supprimer à l'aide du tableau");
                return;
            }

            firstRowIndex = DGrid_Result.SelectedRows.Count - 1;
            NumClient = DGrid_Result.SelectedRows[firstRowIndex].Cells[0].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Etes-vous certain de vouloir supprimer cet enregistrement ?", "Demande de confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GestClient myclient = new GestClient();
                myclient.codeclient = NumClient;
                myclient.Supprimer();
                
                MajDataSource_Tableau("SELECT * FROM client");


            }
               
        }

  

        private void DGrid_Result_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void DGrid_Result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGrid_Result_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Ouvre_Fiche("UPDATE");
        }

        private void DGrid_Result_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
                Ouvre_Fiche("UPDATE");
            
        }
    }
}
