using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_AP.Entreprise
{
    public partial class CreaEntreprise : Form
    {
        private Entreprise uneEntreprise;
        List<Entreprise> lesEntreprise = new List<Entreprise>();
        public CreaEntreprise()
        {
            InitializeComponent();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            int actEntreprise = 1; //activer par default
            bool rep = Modele.Vmodele.AjoutEntreprise(tbNEntreprise.Text, rbActEntreprise.Checked);
            if (rbDesEntreprise.Checked)
            {
                actEntreprise = 0;
            }
            uneEntreprise = new Entreprise(tbNEntreprise.Text, actEntreprise);
            lesEntreprise.Add(uneEntreprise);
            if (rep)
            {
                MessageBox.Show("Entreprise inséré dans la BD");

            }
            else
            {
                MessageBox.Show("Pb dans l'insertion d’une Entreprise");
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            tbNEntreprise.Clear();
            rbActEntreprise.Checked = false;
            rbDesEntreprise.Checked = false;
        }
    }
}
