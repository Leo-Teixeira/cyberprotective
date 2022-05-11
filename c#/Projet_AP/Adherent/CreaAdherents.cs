using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Projet_AP.Adherent
{
    public partial class CreaAdherents : Form
    {
        private Adherent unAdherent;
        List<Adherent> lesAdherents = new List<Adherent>();
        List<Entreprise.Entreprise> lesEntreprise = new List<Entreprise.Entreprise>();
        List<Medaille.Medaille> lesMedaille = new List<Medaille.Medaille>();
        public CreaAdherents()
        {
            InitializeComponent();
        }

        private void ChargerList()
        {
            #region chargement liste entreprise
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
            #region chargement liste medaille
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
        private void CreaAdherents_Load(object sender, EventArgs e)
        {
            ChargerList();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            int index = cbListEntreprise.SelectedIndex;
            int indexM = cbMedaille.SelectedIndex;
            int actAdherent = 1; //activer par default
            if (rbDesc.Checked)
            {
                actAdherent = 0;
            }
            int idEntreprise = Convert.ToInt32(Modele.Vmodele.DT2.Rows[index]["id_entreprise"]);
            int idMedaille = Convert.ToInt32(Modele.Vmodele.DT3.Rows[index]["id_medaille"]);
            MessageBox.Show(idEntreprise.ToString(), idMedaille.ToString());
            bool rep = Modele.Vmodele.AjoutAdherent(tbNadherent.Text, tbPadherent.Text, idEntreprise, tbPassword.Text, tbMail.Text, idMedaille, rbAct.Checked);
            unAdherent = new Adherent(tbNadherent.Text, tbPadherent.Text, tbPassword.Text, tbMail.Text, actAdherent, idEntreprise.ToString(), idMedaille.ToString());
            lesAdherents.Add(unAdherent);
            if (rep)
            {
                MessageBox.Show("Adherent inséré dans la BD");
                ChargerList();
            }
            else
            {
                MessageBox.Show("Pb dans l'insertion d’un Adherent");
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            tbMail.Clear();
            tbNadherent.Clear();
            tbPadherent.Clear();
            tbPassword.Clear();
            rbAct.Checked = false;
            rbDesc.Checked = false; 
        }
    }
}
