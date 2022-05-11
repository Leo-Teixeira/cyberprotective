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
    public partial class FormBiensImmobiliers : Form
    {
        private Bien unBien;
        List<Bien> lesBiens = new List<Bien>();
        public FormBiensImmobiliers()
        {
            InitializeComponent();
        }


        private void TbSurface_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, caractères autorisés : chiffre seulement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void TbPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, caractères autorisés : chiffre seulement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            rbAppart.Checked = false;
            rbMaison.Checked = false;
            tbSurface.Clear();
            tbAdresse.Clear();
            tbVille.Clear();
            numNbChambres.Value = 0;
            numNbPieces.Value = 0;
            numNbSalleEau.Value = 0;
            tbPrix.Clear();
        }
        
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            int typeB=2; // maison par défaut
            // saisies  de type de bien, ville, surface, nbPieces et prix obligatoires
            if ((rbAppart.Checked || rbMaison.Checked) && tbVille.Text != "" && tbSurface.Text != "" && numNbPieces.Value !=0 && tbPrix.Text !="")
            {
                if (rbAppart.Checked) typeB = 1;

                unBien = new Bien(typeB, tbVille.Text, Convert.ToInt32(tbSurface.Text), Convert.ToInt32(numNbPieces.Value), Convert.ToInt32(tbPrix.Text), Convert.ToInt32(numNbChambres.Value), Convert.ToInt32(numNbSalleEau.Value), tbAdresse.Text);

                MessageBox.Show(unBien.Afficher());

                lesBiens.Add(unBien);

                // AJOUT DANS LA BD
                // appel de la méthode AjoutBD avec en paramètre les données saisies sur la vue
                bool rep = Controleur.Vmodele.AjoutBIEN(tbAdresse.Text, tbVille.Text, Convert.ToInt32(tbSurface.Text), Convert.ToInt32(numNbPieces.Value), Convert.ToInt32(numNbChambres.Value), Convert.ToInt32(numNbSalleEau.Value), Convert.ToInt32(tbPrix.Text), Convert.ToInt32(typeB));// paramètres à compléter dans l’ordre d’appel de la méthode….
                if (rep)
                {
                    MessageBox.Show("BIEN inséré dans la BD");
                    // mise à jour des données dans le comboBox
                    BtnAnnuler_Click(sender, e); // Annulation pour vider les zones de saisies
                    chargerCombo(); // pour mettre à jour la comboBox
                }
                else
                {
                    MessageBox.Show("Pb dans l'insertion d’un bien");
                    BtnAnnuler_Click(sender, e); // Annulation pour vider les zones de saisies
                    chargerCombo(); // pour mettre à jour la comboBox
                }

            }
            else
            {
                MessageBox.Show("Erreur, il faut saisir au moins le type de bien, la ville, la surface, le nb de pièces et le prix pour valider", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Controleur.Vmodele.sedeconnecter();
            Application.Exit();
        }

        private void FormBiensImmobiliers_Load(object sender, EventArgs e)
        {
            Controleur.init();
            Controleur.Vmodele.seconnecter();
            if (Controleur.Vmodele.Connopen == false)
            {
                MessageBox.Show("erreur lors de la connexion a la bdd", "connection", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
            {
                MessageBox.Show("ok", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Controleur.Vmodele.charger_donnees("bien");
     
                if (Controleur.Vmodele.Chargement)
                {
                    DataTable dt = Controleur.Vmodele.DT1;
                // remplissage de la collection à partir du dataTable chargé
                // on parcourt tout le dataTable
                    for (int i = 0; i < Controleur.Vmodele.DT1.Rows.Count; i++)
                    {
                        // on ajoute chaque tupe du dataTable dans la collection
                       lesBiens.Add(new Bien(Convert.ToInt32(dt.Rows[i]["typeBien"]),
                       dt.Rows[i]["villeBien"].ToString(), Convert.ToInt32(dt.Rows[i]["surface"]),
                       Convert.ToInt32(dt.Rows[i]["nbPiece"]),
                       Convert.ToInt32(dt.Rows[i]["prix"]),
                       Convert.ToInt32(dt.Rows[i]["nbChambre"]), Convert.ToInt32(dt.Rows[i]["nbSalleEau"]),dt.Rows[i]["adresseBien"].ToString()));
                    }
                    chargerCombo(); // méthode à ajouter plus bas
                }
            }
        }

        private void chargerCombo()
        {
            // pour refaire le lien entre DT1 et lesBiens et la comboBox
            Controleur.Vmodele.charger_donnees("bien");
            DataTable dt = Controleur.Vmodele.DT1;
            lesBiens.Clear();
            // remplissage de la collection à partir du dataTable chargé
            for (int i = 0; i < Controleur.Vmodele.DT1.Rows.Count; i++)
            {
               lesBiens.Add(new Bien(Convert.ToInt32(dt.Rows[i]["typeBien"]),
               dt.Rows[i]["villeBien"].ToString(), Convert.ToInt32(dt.Rows[i]["surface"]),
               Convert.ToInt32(dt.Rows[i]["nbPiece"]), Convert.ToInt32(dt.Rows[i]["prix"]),
               Convert.ToInt32(dt.Rows[i]["nbChambre"]), Convert.ToInt32(dt.Rows[i]["nbSalleEau"]),
               dt.Rows[i]["adresseBien"].ToString()));
                // A comprendre : que fait cette méthode ? quand est-elle déclenchée ?
            }
                cbListeBiens.Items.Clear();
            foreach(Bien B in lesBiens)
            {
                cbListeBiens.Items.Add(B.RetourneTypeBien()+" - " + B.Adresse + " - " + B.Ville + " " + B.NbPieces + " pièces - " + B.Prix+ "€");
            }

        }

        private void CbListeBiens_SelectedIndexChanged(object sender, EventArgs e)
        {
            // A comprendre
            int index = cbListeBiens.SelectedIndex;
            if (index !=-1)
            {
                Bien B = lesBiens[index];
                rbAppart.Checked = (B.TypeBien == 1);
                rbMaison.Checked = (B.TypeBien == 2);
                tbSurface.Text = B.Surface.ToString();
                tbAdresse.Text = B.Adresse;
                tbVille.Text = B.Ville;
                numNbPieces.Value = B.NbPieces;
                numNbChambres.Value = B.NbChambres;
                numNbSalleEau.Value = B.NbSallesEau;
                tbPrix.Text = B.Prix.ToString();
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            int index = cbListeBiens.SelectedIndex;
            if (index != -1)
            {
                DialogResult c = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce bien ?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (c == DialogResult.Yes)
                { 
                    

                    BtnAnnuler_Click(sender, e); // Annulation pour vider les zones de saisies
                    FormBiensImmobiliers_Load(sender, e); // pour mettre à jour la comboBox

                    int idBien = Convert.ToInt32(Controleur.Vmodele.DT1.Rows[index]["idBien"]);
                    bool rep = Controleur.Vmodele.SupprBien(idBien);// paramètres à compléter dans l’ordre d’appel de la méthode….
                    if (rep)
                    {
                        Controleur.init();
                        Controleur.Vmodele.seconnecter();
                        // mise à jour des données dans le comboBox
                        lesBiens.RemoveAt(index);
                        BtnAnnuler_Click(sender, e); // Annulation pour vider les zones de saisies
                        chargerCombo(); // pour mettre à jour la comboBox
                        MessageBox.Show("BIEN supprimer");
                    }
                    else
                    {
                        MessageBox.Show("Pb dans la suppression d’un bien");
                    }
                }
            }

            chargerCombo();

        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            int index = cbListeBiens.SelectedIndex;
            if (index != -1)
            {
                int typeB = 2; // maison par défaut
                               // saisies  de type de bien, ville, surface, nbPieces et prix obligatoires
                if ((rbAppart.Checked || rbMaison.Checked) && tbVille.Text != "" && tbSurface.Text != "" && numNbPieces.Value != 0 && tbPrix.Text != "")
                {
                    if (rbAppart.Checked) typeB = 1;
                    lesBiens[index].TypeBien = typeB;

                    // A COMPLETER : mettre à jour toutes les autres propriétés du bien sélectionné à partir des informations saisies sur l'interface
                    lesBiens[index].TypeBien = typeB;
                    lesBiens[index].Ville = tbVille.Text;
                    lesBiens[index].Surface = Convert.ToInt32(tbSurface.Text);
                    lesBiens[index].NbPieces = Convert.ToInt32(numNbPieces.Value);
                    lesBiens[index].Prix = Convert.ToInt32(tbPrix.Text);
                    lesBiens[index].NbChambres = Convert.ToInt32(numNbChambres.Value);
                    lesBiens[index].NbSallesEau = Convert.ToInt32(numNbSalleEau.Value);
                    lesBiens[index].Adresse = tbAdresse.Text;

                    MessageBox.Show("Bien modifié");

                   
                    int idBien = Convert.ToInt32(Controleur.Vmodele.DT1.Rows[index]["idBien"]);
                    bool rep = Controleur.Vmodele.ModifBien(idBien, tbAdresse.Text, tbVille.Text, Convert.ToInt32(tbSurface.Text), Convert.ToInt32(numNbPieces.Value), Convert.ToInt32(numNbChambres.Value), Convert.ToInt32(numNbSalleEau.Value), Convert.ToInt32(tbPrix.Text), typeB);// paramètres à compléter dans l’ordre d’appel de la méthode….
                    if (rep)
                    {
                        MessageBox.Show("BIEN modifié dans la BD");
                        // mise à jour des données dans le comboBox
                        BtnAnnuler_Click(sender, e); // Annulation pour vider les zones de saisies
                        chargerCombo(); // pour mettre à jour la comboBox
                    }
                    else
                    {
                        MessageBox.Show("Pb dans la modif d’un bien");
                    }

                }
            }
        }

        private void TextBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, caractères autorisés : chiffre seulement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }


        private void CbListeBiens_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
