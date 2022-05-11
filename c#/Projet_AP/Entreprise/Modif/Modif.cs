using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_AP.Entreprise.Modif
{
    public partial class Modif : Form
    {
        List<Entreprise> lesEntreprise = new List<Entreprise>();
        public Modif()
        {
            InitializeComponent();
        }

        private void ModifEntreprise()
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
            lbModif.Items.Clear();
            foreach (Entreprise E in lesEntreprise)
            {
                lbModif.Items.Add(E.Id + "-" + E.Nom);
            }
        }

        private void Modif_Load(object sender, EventArgs e)
        {
            ModifEntreprise();
        }

        private void BtnModif_Click(object sender, EventArgs e)
        {
            int index = lbModif.SelectedIndex;
            if (index != -1)
            {
                int activation = 1; //entreprise activer de base
                if ((rbAct.Checked || rbDesc.Checked) && tbNom.Text != "")
                {
                    if (rbDesc.Checked)
                    {
                        activation = 0;
                    }
                    lesEntreprise[index].Activation = activation;
                    lesEntreprise[index].Nom = tbNom.Text;

                    int idEntreprise = Convert.ToInt32(Modele.Vmodele.DT2.Rows[index]["id_entreprise"]);
                    bool rep = Modele.Vmodele.ModifEntreprise(idEntreprise, tbNom.Text, activation);
                    if (rep)
                    {
                        MessageBox.Show("Entreprise modifié dans la BD");
                        // mise à jour des données dans le comboBox
                        ModifEntreprise(); // pour mettre à jour la comboBox
                    }
                    else
                    {
                        MessageBox.Show("Pb dans la modif d’une Entreprise");
                    }
                }
            }
        }

        private void LbModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbModif.SelectedIndex;
            if (index != -1)
            {
                Entreprise E = lesEntreprise[index];
                tbNom.Text = E.Nom;
                rbAct.Checked = (E.Activation == 1);
                rbDesc.Checked = (E.Activation == 0);
            }
        }
    }
}
