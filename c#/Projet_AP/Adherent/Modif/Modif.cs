using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_AP.Adherent.Modif
{
    public partial class Modif : Form
    {
        List<Entreprise.Entreprise> lesEntreprise = new List<Entreprise.Entreprise>();
        List<Medaille.Medaille> lesMedaille = new List<Medaille.Medaille>();
        List<Adherent> lesAdherents = new List<Adherent>();
        public Modif()
        {
            InitializeComponent();
        }
        private void ModifAdherent()
        {
            Modele.Vmodele.Charger_adherent();
            DataTable dt = Modele.Vmodele.DT5;
            lesAdherents.Clear();
            // remplissage de la collection à partir du dataTable chargé
            for (int i = 0; i < Modele.Vmodele.DT5.Rows.Count; i++)
            {
                lesAdherents.Add(new Adherent(dt.Rows[i]["id_adherent"].ToString(), dt.Rows[i]["nom_adherent"].ToString(), dt.Rows[i]["prenom_adherent"].ToString(), dt.Rows[i]["password_adherent"].ToString(), dt.Rows[i]["email_adherent"].ToString(), Convert.ToInt32(dt.Rows[i]["activation_adherent"]), dt.Rows[i]["id_entreprise"].ToString(), dt.Rows[i]["id_medaille"].ToString()));
                // A comprendre : que fait cette méthode ? quand est-elle déclenchée ?
            }
            lbAdherent.Items.Clear();
            foreach (Adherent E in lesAdherents)
            {
                lbAdherent.Items.Add(E.IdAdherent + "-" + E.NomAdherent);
            }
        }

        private void ChargerEntrepriseMedaille()
        {
            #region chargement Entreprise
            Modele.Vmodele.Charger_entreprise(); //chargement de la table entreprise
            DataTable dt2 = Modele.Vmodele.DT2; //on definit sur quel dataTable on est
            lesEntreprise.Clear(); //on efface tous ce qu'il y'a dans la collection lesEntreprise
            // remplissage de la collection à partir du dataTable chargé
            for (int i = 0; i < Modele.Vmodele.DT2.Rows.Count; i++)
            {
                //on ajoute a la collection colonne par colonne tout les information concernant la table
                lesEntreprise.Add(new Entreprise.Entreprise(dt2.Rows[i]["id_entreprise"].ToString(), dt2.Rows[i]["nom_entreprise"].ToString(), Convert.ToInt32(dt2.Rows[i]["activation_entreprise"])));
            }
            cbListEntreprise.Items.Clear(); //on efface la liste deroulante
                                            //parcourt de la collection pour remplir la liste deroulante
            foreach (Entreprise.Entreprise E in lesEntreprise)
            {
                cbListEntreprise.Items.Add(E.Id + "-" + E.Nom);
            }
            #endregion
            #region chargement Medaille
            Modele.Vmodele.Charger_medaille();
            DataTable dt3 = Modele.Vmodele.DT3;
            lesMedaille.Clear();
            for (int i = 0; i < Modele.Vmodele.DT3.Rows.Count; i++)
            {
                lesMedaille.Add(new Medaille.Medaille(dt3.Rows[i]["id_medaille"].ToString(), dt3.Rows[i]["test_medaille"].ToString()));
            }
            cbMedaille.Items.Clear();
            foreach (Medaille.Medaille M in lesMedaille)
            {
                cbMedaille.Items.Add(M.IdMedaille + "-" + M.TestMedaille);
            }
            #endregion
        }

        private void Modif_Load(object sender, EventArgs e)
        {
            ModifAdherent();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            int index = lbAdherent.SelectedIndex;
            if (index != -1)
            {
                int activation = 1; //entreprise activer de base
                if ((rbAct.Checked || rbDesc.Checked) && tbMail.Text != "" && tbNadherent.Text != "" && tbPadherent.Text != "" && tbPassword.Text != "")
                {
                    if (rbDesc.Checked)
                    {
                        activation = 0;
                    }
                    lesEntreprise[index].Activation = activation;
                    lesEntreprise[index].Nom = tbNadherent.Text;
                    int idAdherent = Convert.ToInt32(Modele.Vmodele.DT5.Rows[index]["id_adherent"]);
                    int idEntreprise = Convert.ToInt32(Modele.Vmodele.DT2.Rows[index]["id_entreprise"]);
                    int idMedaille = Convert.ToInt32(Modele.Vmodele.DT3.Rows[index]["id_medaille"]);
                    bool rep = Modele.Vmodele.ModifAdherent(idAdherent, tbNadherent.Text, tbPadherent.Text, tbPassword.Text, tbMail.Text, idEntreprise, idMedaille, activation);
                    if (rep)
                    {
                        MessageBox.Show("Adherent modifié dans la BD");
                        // mise à jour des données dans le comboBox
                        ModifAdherent(); // pour mettre à jour la comboBox
                        ChargerEntrepriseMedaille();
                    }
                    else
                    {
                        MessageBox.Show("Pb dans la modif d’un Adherent");
                    }
                }
            }
        }

        private void LbAdherent_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerEntrepriseMedaille();
            int index = lbAdherent.SelectedIndex;
            if (index != -1)
            {
                Adherent A = lesAdherents[index];
                tbNadherent.Text = A.NomAdherent;
                rbAct.Checked = (A.ActivationAdherent == 1);
                rbDesc.Checked = (A.ActivationAdherent == 0);
                tbMail.Text = A.EmailAdherent;
                tbPadherent.Text = A.PrenomAdherent;
                tbPassword.Text = A.PasswordAdherent;
                cbListEntreprise.Text = A.NomEntreprise;
                cbMedaille.Text = A.Medaille;
            }
        }
    }
}
