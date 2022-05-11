using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Projet_AP.Control
{
    class MainMenuStrip : MenuStrip
    {
        #region propriétés privée
        /////////////BDD Table = new BDD();
        #endregion

        /// <summary>
        /// méthode qui permet de créer le menu du back office
        /// </summary>
        public MainMenuStrip()
        {
            Name = "MainMenuStrip"; //nom du menu
            Dock = DockStyle.Top; //positionnement du menu

            //appel de toutes les méthode qui forme le menu
            MenuEntreprise();
            MenuAdherent();
            MenuArticle();
            MenuTest();
            MenuQuitter();
        } 
        /// <summary>
        /// Méthode qui permet d'afficher le menu de l'entreprise
        /// </summary>
        
        public void MenuEntreprise()
        { 
            //création du menu entreprise
            var Entreprise = new ToolStripMenuItem("Entreprise");

            //création des sous menu de entrprise
            var Create = new ToolStripMenuItem("Créer");
            var Modify = new ToolStripMenuItem("Modifier");
            var Delete = new ToolStripMenuItem("Supprimer");
            
            //mis en place des sous menu dans le menu entreprise
            Entreprise.DropDownItems.AddRange(new ToolStripItem[] { Create, Modify, Delete });
            //ajout de entreprise dans le menuStrip
            Items.Add(Entreprise);

            Create.Click += (sender, e) =>
            {
                //Hub.ActiveForm.Close();
                Projet_AP.Entreprise.CreaEntreprise Add = new Projet_AP.Entreprise.CreaEntreprise();
                Add.Show();
            };

            Modify.Click += (sender, e) =>
            {
                //Hub.ActiveForm.Close();
                Projet_AP.Entreprise.Modif.Modif Add = new Projet_AP.Entreprise.Modif.Modif();
                Add.Show();
            };

            Delete.Click += (sender, e) =>
            {
                //Hub.ActiveForm.Close();
                Projet_AP.Entreprise.SupprEntreprise Add = new Projet_AP.Entreprise.SupprEntreprise();
                Add.Show();
            };
        }



        /// <summary>
        /// Méthode qui permet d'afficher le menu de l'adherent
        /// </summary>
        public void MenuAdherent()
        {
            //création du menu Adherent
            var Adherent = new ToolStripMenuItem("Adherent");

            //création des sous menu de Adherent
            var Create = new ToolStripMenuItem("Créer");
            var Modify = new ToolStripMenuItem("Modifier");
            var Delete = new ToolStripMenuItem("Supprimer");

            //mis en place des sous menu dans le menu Adherent
            Adherent.DropDownItems.AddRange(new ToolStripItem[] { Create, Modify, Delete });
            //ajout de Adherent dans le menuStrip
            Items.Add(Adherent);

            Create.Click += (sender, e) =>
            {
                //Hub.ActiveForm.Close();
                Projet_AP.Adherent.CreaAdherents Add = new Projet_AP.Adherent.CreaAdherents();
                Add.Show();
            };

            Modify.Click += (sender, e) =>
            {
                //Hub.ActiveForm.Close();
                Projet_AP.Adherent.Modif.Modif Add = new Projet_AP.Adherent.Modif.Modif();
                Add.Show();
            };

            Delete.Click += (sender, e) =>
            {
                //Hub.ActiveForm.Close();
                Projet_AP.SupprAdherent Add = new Projet_AP.SupprAdherent();
                Add.Show();
            };
        }

        ///<summary>
        ///Méthode qui permet d'afficher le menu de l'article
        /// </summary>       
        public void MenuArticle()
        {
            //création du menu Article
            var Article = new ToolStripMenuItem("Article");

            //création des sous menu de Article
            var Create = new ToolStripMenuItem("Créer");
            var Modify = new ToolStripMenuItem("Modifier");
            var Delete = new ToolStripMenuItem("Supprimer");
            var theme = new ToolStripMenuItem("Création Theme");

            //mis en place des sous menu dans le menu Article
            Article.DropDownItems.AddRange(new ToolStripItem[] { Create, Modify, Delete, theme });
            //ajout de Article dans le menuStrip
            Items.Add(Article);

            Create.Click += (sender, e) =>
            {
                //Hub.ActiveForm.Close();
                Projet_AP.article.CreaArticle Add = new Projet_AP.article.CreaArticle();
                Add.Show();
            };

            Modify.Click += (sender, e) =>
            {
                //Hub.ActiveForm.Close();
                Projet_AP.article.Modif.ModifArticle Add = new Projet_AP.article.Modif.ModifArticle();
                Add.Show();
            };

            Delete.Click += (sender, e) =>
            {
                //Hub.ActiveForm.Close();
                Projet_AP.Article.SupprArticle Add = new Projet_AP.Article.SupprArticle();
                Add.Show();
            };

            theme.Click += (sender, e) =>
            {
                //Hub.ActiveForm.Close();
                article.Theme.CreaTheme AddTheme = new article.Theme.CreaTheme();
                AddTheme.Show();
            };
        }

        ///<summary>
        ///Méthode qui permet d'afficher le menu du test
        /// </summary>
        public void MenuTest()
        {
            //création du menu Test
            var Test = new ToolStripMenuItem("Test");

            //création des sous menu de Test
            var Create = new ToolStripMenuItem("Créer");

            //mis en place des sous menu dans le menu Test
            Test.DropDownItems.Add(Create);
            //ajout de Test dans le menuStrip
            Items.Add(Test);

            Create.Click += (sender, e) =>
            {
                //Hub.ActiveForm.Close();
                Projet_AP.Test.Test Add = new Projet_AP.Test.Test();
                Add.Show();
            };
        }

        ///<summary>
        ///Méthode qui permet d'afficher le menu quitter
        /// </summary>
        public void MenuQuitter()
        {
            //permet de créer le menu quitter
            var Quitter = new ToolStripMenuItem("Quitter");

            //permet de generer le menu quitter
            Items.Add(Quitter);

            Quitter.Click += (s, e) =>
            {
                Application.Exit();
            };
        }
    }
}