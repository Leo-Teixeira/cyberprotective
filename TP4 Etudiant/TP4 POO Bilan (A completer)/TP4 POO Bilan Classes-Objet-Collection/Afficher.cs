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

namespace TP4_POO_Bilan_Classes_Objet_Collection
{
    public partial class Afficher : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        public Afficher()
        {
            InitializeComponent();
        }

        private void charger_combo()
        {
            cbAfficher.Items.Clear();
            // creation d’une liste des villes
            List<KeyValuePair<string, string>> FList = new List<KeyValuePair<string, string>>();
            FList.Add(new KeyValuePair<string, string>("0", "toutes les villes"));
            cbAfficher.Items.Add("toutes les villes");
            // on parcourt le dataTable des villes DT2 de la classe modele pour compléter la FList
            for (int i = 0; i < Controleur.Vmodele.DT2.Rows.Count; i++)
            {
                FList.Add(new KeyValuePair<string,
                string>((string)Controleur.Vmodele.DT2.Rows[i][0],
                Controleur.Vmodele.DT2.Rows[i][0].ToString()));
            }
            // on lie la liste à la comboBox
            cbAfficher.DataSource = FList;
            cbAfficher.ValueMember = "Key";
            cbAfficher.DisplayMember = "Value";
            cbAfficher.Text = cbAfficher.Items[0].ToString();
        }

        private void changefiltre()
        {
            // on récupère la ville sélectionnée
            string num = cbAfficher.SelectedValue.ToString();
            if (num == "0") // cas de "toutes les villes"
                            // pour annuler le filtre
                Controleur.Vmodele.DT1.DefaultView.RowFilter = "";
            else
            {
                string Filter = "villeBien = '" + num + "'"; // filtre sur la ville
                                                             // on applique le filtre à la dataTable
                Controleur.Vmodele.DT1.DefaultView.RowFilter = Filter;
            }
            dgvImmo.Refresh(); // mise à jour du dataGridView
        }

        private void Afficher_Load(object sender, EventArgs e)
        {
            Controleur.init();
            Controleur.Vmodele.seconnecter();
            if (Controleur.Vmodele.Connopen == true)
            {
                MessageBox.Show("ok", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Controleur.Vmodele.charger_donnees("bien");
                Controleur.Vmodele.charger_donneesVille();
                charger_combo();

                if (Controleur.Vmodele.Chargement)
                {
                    bindingSource1.DataSource = Controleur.Vmodele.DT1;
                    dgvImmo.DataSource = bindingSource1;
                }
            }
            else
            {
                MessageBox.Show("probleme lors de la connection");
            }
        }

        private void dgvImmo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvImmo.Columns[0].HeaderText = "Numéro";
            dgvImmo.Columns[1].HeaderText = "Adresse";
            dgvImmo.Columns[2].HeaderText = "Ville";
            dgvImmo.Columns[0].Visible = true;
            dgvImmo.Refresh();
        }

        private void cbAfficher_SelectedIndexChanged(object sender, EventArgs e)
        {
            changefiltre();
        }
    }
}
