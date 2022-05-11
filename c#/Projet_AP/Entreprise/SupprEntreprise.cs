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

namespace Projet_AP.Entreprise
{
    public partial class SupprEntreprise : Form
    {
        List<Entreprise> lesEntreprise = new List<Entreprise>();
        public SupprEntreprise()
        {
            InitializeComponent();
        }

        private void ChargerEntreprise()
        {
            Modele.Vmodele.Charger_entreprise();
            DataTable dt2 = Modele.Vmodele.DT2;
            lesEntreprise.Clear();
            // remplissage de la collection à partir du dataTable chargé
            for (int i = 0; i < Modele.Vmodele.DT2.Rows.Count; i++)
            {
                lesEntreprise.Add(new Entreprise(dt2.Rows[i]["id_entreprise"].ToString(), dt2.Rows[i]["nom_entreprise"].ToString(), Convert.ToInt32(dt2.Rows[i]["activation_entreprise"])));
                // A comprendre : que fait cette méthode ? quand est-elle déclenchée ?
            }
            lbSuppr.Items.Clear();
            foreach (Entreprise E in lesEntreprise)
            {
                lbSuppr.Items.Add(E.Id + "-" + E.Nom);
            }
        }
        private void SupprEntreprise_Load(object sender, EventArgs e)
        {
            ChargerEntreprise();
        }

        private void BtnSuppr_Click(object sender, EventArgs e)
        {
            int index = lbSuppr.SelectedIndex;
            if (index != -1)
            {
                DialogResult c = MessageBox.Show("Etes-vous sûr de vouloir supprimer cette entreprise ?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (c == DialogResult.Yes)
                {
                    int idEntreprise = Convert.ToInt32(Modele.Vmodele.DT2.Rows[index]["id_entreprise"]);
                    bool rep = Modele.Vmodele.SupprEntreprise(idEntreprise);
                    if (rep)
                    {
                        lesEntreprise.RemoveAt(index);
                        MessageBox.Show("Entreprise supprimer de la BD");
                    }
                    else
                    {
                        MessageBox.Show("Problème lors de la suppression de l'entreprise");
                    }
                }
            }
            ChargerEntreprise();
        }
    }
}
