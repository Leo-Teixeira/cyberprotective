using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_POO_Bilan_Classes_Objet_Collection
{
    public partial class FormPrincipale : Form
    {
        public FormPrincipale()
        {
            InitializeComponent();
        }

        private void AjouterModifierSupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBiensImmobiliers FBI = new FormBiensImmobiliers();
            FBI.MdiParent = this;
            FBI.Show();
        }

        private void QUITTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AFFICHERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Afficher Aff = new Afficher();
            Aff.MdiParent = this;
            Aff.Show();
            Controleur.Vmodele.seconnecter();
        }
    }
}
