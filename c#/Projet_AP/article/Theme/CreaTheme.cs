using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_AP.article.Theme
{
    public partial class CreaTheme : Form
    {
        private CThemes unTheme;
        List<CThemes> lesThemes = new List<CThemes>();
        public CreaTheme()
        {
            InitializeComponent();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            bool rep = Modele.Vmodele.AjoutTheme(tbTheme.Text);
            unTheme = new CThemes(tbTheme.Text);
            lesThemes.Add(unTheme);
            if (rep)
            {
                MessageBox.Show("Theme bien insérer dans la BDD");
            }
            else
            {
                MessageBox.Show("Problème lors de l'insertion du Theme");
            }
        }
    }
}
