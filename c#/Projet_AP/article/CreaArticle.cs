using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_AP.article
{
    public partial class CreaArticle : Form
    {
        private Article unArticle;
        List<Article> lesArticles = new List<Article>();
        List<article.Theme.CThemes> lesThemes = new List<article.Theme.CThemes>();
        public CreaArticle()
        {
            InitializeComponent();
        }
        private void ChargerTheme()
        {
            Modele.Vmodele.Charger_Theme();
            DataTable dt = Modele.Vmodele.DT4;
            lesThemes.Clear();
            // remplissage de la collection à partir du dataTable chargé
            for (int i = 0; i < Modele.Vmodele.DT4.Rows.Count; i++)
            {
                lesThemes.Add(new article.Theme.CThemes(Convert.ToInt32(dt.Rows[i]["id_theme"]), dt.Rows[i]["article_theme"].ToString()));
                // A comprendre : que fait cette méthode ? quand est-elle déclenchée ?
            }
            cbListTheme.Items.Clear();
            foreach (article.Theme.CThemes T in lesThemes)
            {
                cbListTheme.Items.Add(T.IdTheme + "-" + T.Theme);
            }
        }
        private void CreaArticle_Load(object sender, EventArgs e)
        {
            ChargerTheme();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            int actArticle = 1; //activer par default
            if (rbDesactivation.Checked)
            {
                actArticle = 0;
            }
            bool rep = Modele.Vmodele.AjoutArticle(tbTitre.Text, tbChapeau.Text, dtpDate.Value, tbDebut.Text, tbImage.Text, tbLien.Text, rbActivation.Checked, cbListTheme.SelectedIndex+1);
            unArticle = new Article(tbTitre.Text, tbChapeau.Text, dtpDate.ToString(), tbDebut.Text, tbImage.Text, tbLien.Text, actArticle);
            lesArticles.Add(unArticle);
            if (rep)
            {
                MessageBox.Show("Article inséré dans la BD");

            }
            else
            {
                MessageBox.Show("Pb dans l'insertion d’un Article");
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            tbTitre.Clear();
            tbChapeau.Clear();
            dtpDate.Refresh();
            tbDebut.Clear();
            tbImage.Clear();
            tbLien.Clear();
            rbActivation.Checked = false;
            rbDesactivation.Checked = false;
        }
    }
}
