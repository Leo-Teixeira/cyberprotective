using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_AP.Test
{
    public partial class Test : Form
    {
        List<article.Article> lesArticles = new List<article.Article>();
        public Test()
        {
            InitializeComponent();
        }
        
        public void ChargerArticle()
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
            cbListArticle.Items.Clear();
            foreach (article.Article A in lesArticles)
            {
                cbListArticle.Items.Add(A.IdArticle + "-" + A.TitreArticle);
            }
        }
        private void BtnValider_Click(object sender, EventArgs e)
        {
            bool rep = Modele.Vmodele.AjoutQuestion(tbQuestion.Text, tbRep1.Text, tbRep2.Text, tbRep3.Text, tbRep4.Text, rbVrai1.Checked, rbVrai2.Checked, rbVrai3.Checked, rbVrai4.Checked, cbListArticle.SelectedIndex+1);
            if (rep)
            {
                MessageBox.Show("Question bien inserer dans la BDD");
            }
            else
            {
                MessageBox.Show("Probleme lors de l'insertion de la question");
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            tbQuestion.Clear();
            tbRep1.Clear();
            rbVrai1.Checked = false;
            rbFaux1.Checked = false;
            tbRep2.Clear();
            rbVrai2.Checked = false;
            rbFaux2.Checked = false;
            tbRep3.Clear();
            rbVrai3.Checked = false;
            rbFaux3.Checked = false;
            tbRep4.Clear();
            rbVrai4.Checked = false;
            rbFaux4.Checked = false;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            ChargerArticle();
        }
    }
}
