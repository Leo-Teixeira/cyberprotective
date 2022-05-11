using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_AP.article.Modif
{
    public partial class ModifArticle : Form
    {
        List<Article> lesArticles = new List<Article>();
        List<Theme.CThemes> lesThemes = new List<Theme.CThemes>();
        public ModifArticle()
        {
            InitializeComponent();
        }

        private void Article()
        {
            Modele.Vmodele.Charger_Article();
            DataTable dt = Modele.Vmodele.DT1;
            lesArticles.Clear();
            // remplissage de la collection à partir du dataTable chargé
            for (int i = 0; i < Modele.Vmodele.DT1.Rows.Count; i++)
            {
                lesArticles.Add(new Article(Convert.ToInt32(dt.Rows[i]["id_article"]), dt.Rows[i]["titre_article"].ToString(), dt.Rows[i]["chapeau_article"].ToString(), dt.Rows[i]["date_publi_article"].ToString(), dt.Rows[i]["resume_article"].ToString(), dt.Rows[i]["image_article"].ToString(), dt.Rows[i]["lien_article"].ToString(), Convert.ToInt32(dt.Rows[i]["activation_article"])));
                // A comprendre : que fait cette méthode ? quand est-elle déclenchée ?
            }
            lbModif.Items.Clear();
            foreach (Article A in lesArticles)
            {
                lbModif.Items.Add(A.IdArticle + "-" + A.TitreArticle);
            }
        }
        private void ChargerTheme()
        {
            Modele.Vmodele.Charger_Theme();
            DataTable dt4 = Modele.Vmodele.DT4;
            lesThemes.Clear();
            for (int i = 0; i < Modele.Vmodele.DT4.Rows.Count; i++)
            {
                lesThemes.Add(new article.Theme.CThemes(Convert.ToInt32(dt4.Rows[i]["id_theme"]), dt4.Rows[i]["article_theme"].ToString()));
                // A comprendre : que fait cette méthode ? quand est-elle déclenchée ?
            }
            cbListTheme.Items.Clear();
            foreach (Theme.CThemes T in lesThemes)
            {
                cbListTheme.Items.Add(T.IdTheme + "-" + T.Theme);
            }
        }

        private void ModifArticle_Load(object sender, EventArgs e)
        {
            Article();
        }

        private void BtnModif_Click(object sender, EventArgs e)
        {
            int index = lbModif.SelectedIndex;
            if (index != -1)
            {
                int activation = 1; //entreprise activer de base
                if ((rbActivation.Checked || rbDesactivation.Checked) && tbTitre.Text != "" && tbChapeau.Text != "" && dtpDate.Text != "" && tbDebut.Text != "" && tbImage.Text != "" && tbLien.Text != "")
                {
                    if (rbDesactivation.Checked)
                    {
                        activation = 0;
                    }
                    lesArticles[index].Activation = activation;
                    lesArticles[index].TitreArticle = tbTitre.Text;
                    int idArticle = Convert.ToInt32(Modele.Vmodele.DT1.Rows[index]["id_article"]);
                    bool rep = Modele.Vmodele.ModifArticle(idArticle, tbTitre.Text, tbChapeau.Text, dtpDate.Value, tbDebut.Text, tbImage.Text, tbLien.Text, activation, cbListTheme.SelectedIndex + 1);
                    if (rep)
                    {
                        MessageBox.Show("Article modifié dans la BD");
                        // mise à jour des données dans le comboBox
                        Article(); // pour mettre à jour la comboBox
                    }
                    else
                    {
                        MessageBox.Show("Pb dans la modif d’un Article");
                    }
                }
            }
        }

        private void LbModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerTheme();
            int index = lbModif.SelectedIndex;
            if (index != -1)
            {
                Article A = lesArticles[index];
                tbTitre.Text = A.TitreArticle;
                tbChapeau.Text = A.ChapeauArticle;
                dtpDate.Text = A.DateArticle;
                tbDebut.Text = A.ResumeArticle;
                tbImage.Text = A.ImgArticle;
                tbLien.Text = A.LienArticle;
                rbActivation.Checked = (A.Activation == 1);
                rbDesactivation.Checked = (A.Activation == 0);
            }
        }
    }
}
