using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_AP.Article
{
    public partial class SupprArticle : Form
    {
        List<article.Article> lesArticles = new List<article.Article>();
        public SupprArticle()
        {
            InitializeComponent();
        }
        private void ChargerArticle()
        {
            Modele.Vmodele.Charger_Article();
            DataTable dt = Modele.Vmodele.DT1;
            lesArticles.Clear();
            // remplissage de la collection à partir du dataTable chargé
            for (int i = 0; i < Modele.Vmodele.DT1.Rows.Count; i++)
            {
                lesArticles.Add(new article.Article(Convert.ToInt32(dt.Rows[i]["id_article"]), dt.Rows[i]["titre_article"].ToString(), dt.Rows[i]["chapeau_article"].ToString(), dt.Rows[i]["date_publi_article"].ToString(), dt.Rows[i]["resume_article"].ToString(), dt.Rows[i]["image_article"].ToString(), dt.Rows[i]["lien_article"].ToString(), Convert.ToInt32(dt.Rows[i]["activation_article"])));
                // A comprendre : que fait cette méthode ? quand est-elle déclenchée ?
            }
            lbArticle.Items.Clear();
            foreach (article.Article A in lesArticles)
            {
                lbArticle.Items.Add(A.IdArticle + "-" + A.TitreArticle);
            }
        }

        private void SupprArticle_Load(object sender, EventArgs e)
        {
            ChargerArticle();
        }

        private void BtnSuppr_Click(object sender, EventArgs e)
        {
            int index = lbArticle.SelectedIndex;
            if (index != -1)
            {
                DialogResult c = MessageBox.Show("Etes-vous sûr de vouloir supprimer cette Article ?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (c == DialogResult.Yes)
                {
                    int idArticle = Convert.ToInt32(Modele.Vmodele.DT1.Rows[index]["id_article"]);
                    bool rep = Modele.Vmodele.SupprArticle(idArticle);
                    if (rep)
                    {
                        lesArticles.RemoveAt(index);
                        MessageBox.Show("Article supprimer de la BD");
                    }
                    else
                    {
                        MessageBox.Show("Problème lors de la suppression de l'Article");
                    }
                }
            }
            ChargerArticle();
        }
    }
}
