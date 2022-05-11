using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;

namespace Projet_AP
{
    public class BDD
    {
        #region propriétés privés
        private MySqlConnection myConnection; // objet de connexion
        private bool connopen = false; // test si la connexion est faite
        private bool chargement = false; // test si le chargement d'une requête est fait
        // objet pour se connecter a une table
        private DataTable dT1 = new DataTable();
        private DataTable dT2 = new DataTable();
        private DataTable dT3 = new DataTable();
        private DataTable dT4 = new DataTable();
        private DataTable dT5 = new DataTable();
        #endregion

        #region accesseur
        public MySqlConnection MyConnection { get => myConnection; set => myConnection = value; }
        public bool Connopen { get => connopen; set => connopen = value; }
        public bool Chargement { get => chargement; set => chargement = value; }
        public DataTable DT1 { get => dT1; set => dT1 = value; }
        public static MySqlCommand MySqlConnection { get; internal set; }
        public DataTable DT2 { get => dT2; set => dT2 = value; }
        public DataTable DT3 { get => dT3; set => dT3 = value; }
        public DataTable DT4 { get => dT4; set => dT4 = value; }
        public DataTable DT5 { get => dT5; set => dT5 = value; }
        #endregion

        ///<summary>
        ///Methode qui permet de se connecter a la bdd
        /// </summary>
        public void Seconnecter()
        {
            // paramètres de connexion à modifier selon sa BD et son serveur de BD
            string myConnectionString = "Server=192.168.233.1; Database=AP_SLAM_BDD; User Id = leo; Password =leo; ";
            MyConnection = new MySqlConnection(myConnectionString);
            try // tentative
            {
                MyConnection.Open();
                Connopen = true;
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur ouverture bdd : " + err, "PBS connection",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connopen = false;
            }
        }
        /// <summary>
        /// méthode qui permet d'executer une requete de lecture des données
        /// </summary>
        /// <param name="requete"></param>
        /// <param name="DT"></param>
        public void Charger(string requete, DataTable DT)
        {
            MySqlCommand command = myConnection.CreateCommand(); //création d'une command sql
            MySqlDataReader reader;
            try
            {
                command.CommandText = requete; //on affecte la commande placer en parametre
                reader = command.ExecuteReader(); //on l'execute
                DT.Load(reader); //on la traite
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "PBS table",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                chargement = false;
            }
        }

        #region méthode pour l'entreprise
        /// <summary>
        /// méthode qui permet de charger la table entreprise
        /// </summary>
        public void Charger_entreprise()
        {
            Charger("select * from Entreprise ;", dT2);
        }

        /// <summary>
        /// méthode qui va permettre d'ajouter une entreprise
        /// </summary>
        /// <param name="nomEntreprise"></param>
        /// <param name="activation"></param>
        /// <returns></returns>
        public bool AjoutEntreprise(string nomEntreprise, bool activation)
        {
            try
            {
                // préparation de la requête avec des paramètres
                string requete = "insert into Entreprise values (NULL, @nom, @activation)"; //requete sql qui permet d'ajouter une entreprise
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                // mise à jour des paramètres de la requête préparée avec les infos passées en paramètre de la méthode
                command.Parameters.AddWithValue("nom", nomEntreprise);
                command.Parameters.AddWithValue("activation", activation);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// méthode qui permet de supprimer une entreprise
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool SupprEntreprise(int id)
        {
            try
            {
                string SupprAdherent = "delete FROM Adherent WHERE Adherent.id_entreprise IN (SELECT Entreprise.id_entreprise FROM Entreprise WHERE Entreprise.id_entreprise = @idEntreprise and Adherent.id_entreprise=Entreprise.id_entreprise)"; //requete qui permet de supprimer l'id_entreprise qui se trouve dans la table adherent
                string Suppr = "delete from Entreprise where id_entreprise = @idEntreprise"; //requete qui permet de supprimer l'entreprise apres avoir supprimer celui dans la table adherent
                MySqlCommand commandEntreprise = myConnection.CreateCommand();
                MySqlCommand commandAdherent = myConnection.CreateCommand();
                commandAdherent.CommandText = SupprAdherent;
                commandEntreprise.CommandText = Suppr;
                // Exécution de la requête
                commandAdherent.Parameters.AddWithValue("idEntreprise", id);
                commandEntreprise.Parameters.AddWithValue("idEntreprise", id);
                int i = commandAdherent.ExecuteNonQuery();
                int j = commandEntreprise.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i>0 || j>0);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// méthode qui va permettre de modifier une entreprise
        /// </summary>
        /// <param name="entreprise"></param>
        /// <param name="nom"></param>
        /// <param name="activation"></param>
        /// <returns></returns>
        public bool ModifEntreprise(int entreprise, string nom, int activation)
        {
            try
            {
                string Update = "update Entreprise set nom_entreprise = @Nom, activation_entreprise = @Activation where id_entreprise = @IdEntreprise"; //requete qui permet d'update l'entreprise avec les parametre que l'on a modifier
                string UpdateAdherent = "update Adherent set activation_adherent = 0 where id_entreprise = @idEntreprise";
                MySqlCommand command = myConnection.CreateCommand();
                MySqlCommand commandAdherent = myConnection.CreateCommand();
                command.CommandText = Update;
                commandAdherent.CommandText = UpdateAdherent;
                command.Parameters.AddWithValue("IdEntreprise", entreprise);
                command.Parameters.AddWithValue("Nom", nom);
                command.Parameters.AddWithValue("Activation", activation);
                commandAdherent.Parameters.AddWithValue("idEntreprise", entreprise);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                int j = commandAdherent.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0 || j > 0);
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region méthode pour l'Adherent

        /// <summary>
        /// méthode qui permet d'ajouter un adherent
        /// </summary>
        public void Charger_adherent()
        {
            Charger("select * from Adherent ;", dT5);
        }

        /// <summary>
        /// méthode qui pemret d'ajouter un adherent
        /// </summary>
        /// <param name="nomAdherent"></param>
        /// <param name="prenomAdherent"></param>
        /// <param name="nomEntreprise"></param>
        /// <param name="pwdAdherent"></param>
        /// <param name="emailAdherent"></param>
        /// <param name="idMedaille"></param>
        /// <param name="activation"></param>
        /// <returns></returns>
        public bool AjoutAdherent(string nomAdherent, string prenomAdherent, int nomEntreprise, string pwdAdherent, string emailAdherent, int idMedaille, bool activation)
        {
            try
            {
                // préparation de la requête avec des paramètres
                string requete = "insert into Adherent values (NULL, @nomA, @prenomA, MD5 (@pwdA), @emailA, @activation, @nomE, @idMedaille)";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                // mise à jour des paramètres de la requête préparée avec les infos passées en paramètre de la méthode
                command.Parameters.AddWithValue("nomA", nomAdherent);
                command.Parameters.AddWithValue("prenomA", prenomAdherent);
                command.Parameters.AddWithValue("nomE", nomEntreprise);
                command.Parameters.AddWithValue("pwdA", pwdAdherent);
                command.Parameters.AddWithValue("emailA", emailAdherent);
                command.Parameters.AddWithValue("activation", activation);
                command.Parameters.AddWithValue("idMedaille", idMedaille);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// méthode qui permet de supprimer un adherent
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool SupprAdherent(int id)
        {
            try
            {
                string SupprRealiser = "delete FROM realiser WHERE realiser.id_adherent IN (SELECT Adherent.id_adherent FROM Adherent WHERE Adherent.id_adherent = @idAdherent and realiser.id_adherent=Adherent.id_adherent)";
                string Suppr = "delete from Adherent where id_adherent = @idAdherent";
                MySqlCommand commandRealiser = myConnection.CreateCommand();
                MySqlCommand commandAdherent = myConnection.CreateCommand();
                commandRealiser.CommandText = SupprRealiser;
                commandAdherent.CommandText = Suppr;
                // Exécution de la requête
                commandAdherent.Parameters.AddWithValue("idAdherent", id);
                commandRealiser.Parameters.AddWithValue("idAdherent", id);
                int j = commandRealiser.ExecuteNonQuery();
                int k = commandAdherent.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (j > 0 || k > 0);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// méthode qui permet de moidifier un adherent
        /// </summary>
        /// <param name="idAdherent"></param>
        /// <param name="nomAdherent"></param>
        /// <param name="prenomAdherent"></param>
        /// <param name="pwdAdherent"></param>
        /// <param name="emailAdherent"></param>
        /// <param name="idEntreprise"></param>
        /// <param name="idMedaille"></param>
        /// <param name="activation"></param>
        /// <returns></returns>
        public bool ModifAdherent(int idAdherent, string nomAdherent, string prenomAdherent, string pwdAdherent, string emailAdherent, int idEntreprise, int idMedaille, int activation)
        {
            try
            {
                string Update = "update Adherent set id_adherent = @idAdherent, nom_adherent = @nomAdherent, prenom_adherent = @prenomAdherent, password_adherent = MD5(@pwdAdherent), email_adherent = @emailAdherent, activation_adherent = @activation, id_entreprise = @idEntreprise, id_medaille = @idMedaille where id_adherent = @idAdherent";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = Update;
                command.Parameters.AddWithValue("idAdherent", idAdherent);
                command.Parameters.AddWithValue("nomAdherent", nomAdherent);
                command.Parameters.AddWithValue("prenomAdherent", prenomAdherent);
                command.Parameters.AddWithValue("pwdAdherent", pwdAdherent);
                command.Parameters.AddWithValue("emailAdherent", emailAdherent);
                command.Parameters.AddWithValue("idEntreprise", idEntreprise);
                command.Parameters.AddWithValue("idMedaille", idMedaille);
                command.Parameters.AddWithValue("activation", activation);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }
        #endregion


        #region méthode pour l'article

        /// <summary>
        /// méthode qui permet de charger la table article
        /// </summary>
        public void Charger_Article()
        {
            Charger("select * from Article ;", dT1);
        }

        /// <summary>
        /// méthode qui permet d'ajouter un article
        /// </summary>
        /// <param name="titre"></param>
        /// <param name="chapeau"></param>
        /// <param name="date"></param>
        /// <param name="resume"></param>
        /// <param name="image"></param>
        /// <param name="lien"></param>
        /// <param name="activation"></param>
        /// <param name="theme"></param>
        /// <returns></returns>
        public bool AjoutArticle(string titre, string chapeau, DateTime date, string resume, string image, string lien, bool activation, int theme)
        {
            try
            {
                // préparation de la requête avec des paramètres
                string requete = "insert into Article values (NULL, @titre, @chapeau, @date, @resume, @image, @lien, @activation)";
                string ajoutSousTable = "insert into contenir values (@theme, (select id_article from Article where lien_article = @lien))";
                MySqlCommand command = myConnection.CreateCommand();
                MySqlCommand commandSousTable = myConnection.CreateCommand();
                command.CommandText = requete;
                commandSousTable.CommandText = ajoutSousTable;
                // mise à jour des paramètres de la requête préparée avec les infos passées en paramètre de la méthode
                command.Parameters.AddWithValue("titre", titre);
                command.Parameters.AddWithValue("chapeau", chapeau);
                command.Parameters.AddWithValue("date", date);
                command.Parameters.AddWithValue("resume", resume);
                command.Parameters.AddWithValue("image", image);
                command.Parameters.AddWithValue("lien", lien);
                command.Parameters.AddWithValue("activation", activation);
                commandSousTable.Parameters.AddWithValue("theme", theme);
                commandSousTable.Parameters.AddWithValue("lien", lien);
                //command.Parameters.AddWithValue("theme", theme);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                int j = commandSousTable.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0 || j > 0);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// méthode qui permet de supprimer un article
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool SupprArticle(int id)
        {
            try
            {
                string SupprContenir = "delete FROM contenir WHERE contenir.id_article IN (SELECT Article.id_article FROM Article WHERE Article.id_article = @idArticle and Article.id_article=contenir.id_article)";
                string SupprReference = "delete FROM Faire_Reference WHERE Faire_Reference.id_article IN (SELECT Article.id_article FROM Article WHERE Article.id_article = @idArticle and Article.id_article=Faire_Reference.id_article)";
                string Suppr = "delete from Article where id_article = @idArticle";
                MySqlCommand commandArticle = myConnection.CreateCommand();
                MySqlCommand commandContenir = myConnection.CreateCommand();
                MySqlCommand commandReference = myConnection.CreateCommand();
                commandContenir.CommandText = SupprContenir;
                commandReference.CommandText = SupprReference;
                commandArticle.CommandText = Suppr;
                // Exécution de la requête
                commandContenir.Parameters.AddWithValue("idArticle", id);
                commandReference.Parameters.AddWithValue("idArticle", id);
                commandArticle.Parameters.AddWithValue("idArticle", id);
                int i = commandContenir.ExecuteNonQuery();
                int k = commandReference.ExecuteNonQuery();
                int m = commandArticle.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0 || k > 0 || m > 0);
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "PBS table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }

        /// <summary>
        /// méthode qui permet de modifier un article
        /// </summary>
        /// <param name="idArticle"></param>
        /// <param name="titre"></param>
        /// <param name="chapeau"></param>
        /// <param name="date"></param>
        /// <param name="resume"></param>
        /// <param name="image"></param>
        /// <param name="lien"></param>
        /// <param name="activation"></param>
        /// <returns></returns>
        public bool ModifArticle(int idArticle, string titre, string chapeau, DateTime date, string resume, string image, string lien, int activation, int idTheme)
        {
            try
            {
                string Update = "update Article set id_article = @idArticle, titre_article = @titre, chapeau_article = @chapeau, date_publi_article = @date, resume_article = @resume, image_article = @image, lien_article = @lien, activation_article = @activation where id_article = @idArticle";
                string UpdateLien = "update contenir set id_theme = @idTheme, id_article = @idArticle where id_article = @idArticle";
                MySqlCommand command = myConnection.CreateCommand();
                MySqlCommand commandLien = myConnection.CreateCommand();
                command.CommandText = Update;
                commandLien.CommandText = UpdateLien;
                command.Parameters.AddWithValue("idArticle", idArticle);
                command.Parameters.AddWithValue("titre", titre);
                command.Parameters.AddWithValue("chapeau", chapeau);
                command.Parameters.AddWithValue("date", date);
                command.Parameters.AddWithValue("resume", resume);
                command.Parameters.AddWithValue("image", image);
                command.Parameters.AddWithValue("lien", lien);
                command.Parameters.AddWithValue("activation", activation);
                commandLien.Parameters.AddWithValue("idArticle", idArticle);
                commandLien.Parameters.AddWithValue("idTheme", idTheme);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                int j = commandLien.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0 || j > 0);
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region méthode pour les themes

        /// <summary>
        /// méthode qui permet de charger la table theme
        /// </summary>
        public void Charger_Theme()
        {
            Charger("select * from Theme;", DT4);
        }

        /// <summary>
        /// méthode qui permet d'ajouter un theme
        /// </summary>
        /// <param name="theme"></param>
        /// <returns></returns>
        public bool AjoutTheme(string theme)
        {
            try
            {
                // préparation de la requête avec des paramètres
                string requete = "insert into Theme values (NULL, @theme)";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                // mise à jour des paramètres de la requête préparée avec les infos passées en paramètre de la méthode
                command.Parameters.AddWithValue("theme", theme);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region méthode pour Test

        /// <summary>
        /// méthode qui permet de charger la table test
        /// </summary>
        public void Charger_Test()
        {
            Charger("select from * Qcm;", DT1);
        }

        /// <summary>
        /// méthode qui permet d'ajouter une question
        /// </summary>
        /// <param name="question"></param>
        /// <param name="proposition1"></param>
        /// <param name="proposition2"></param>
        /// <param name="proposition3"></param>
        /// <param name="proposition4"></param>
        /// <param name="reponse1"></param>
        /// <param name="reponse2"></param>
        /// <param name="reponse3"></param>
        /// <param name="reponse4"></param>
        /// <returns></returns>
        public bool AjoutQuestion (string question, string proposition1, string proposition2, string proposition3, string proposition4, bool reponse1, bool reponse2, bool reponse3, bool reponse4, int idArticle)
        {
            try
            {
                // préparation de la requête avec des paramètres
                string requete = "insert into Qcm values (NULL, @question, @proposition1, @proposition2, @proposition3, @proposition4, @reponse1, @reponse2, @reponse3, @reponse4)";
                string requeteArticle = "insert into Faire_Reference values (@idArticle, (select numero_question from Qcm where question_question = @question))";
                MySqlCommand command = myConnection.CreateCommand();
                MySqlCommand commandArticle = myConnection.CreateCommand();
                command.CommandText = requete;
                commandArticle.CommandText = requeteArticle;
                // mise à jour des paramètres de la requête préparée avec les infos passées en paramètre de la méthode
                command.Parameters.AddWithValue("question", question);
                command.Parameters.AddWithValue("proposition1", proposition1);
                command.Parameters.AddWithValue("proposition2", proposition2);
                command.Parameters.AddWithValue("proposition3", proposition3);
                command.Parameters.AddWithValue("proposition4", proposition4);
                command.Parameters.AddWithValue("reponse1", reponse1);
                command.Parameters.AddWithValue("reponse2", reponse2);
                command.Parameters.AddWithValue("reponse3", reponse3);
                command.Parameters.AddWithValue("reponse4", reponse4);
                commandArticle.Parameters.AddWithValue("idArticle", idArticle);
                commandArticle.Parameters.AddWithValue("question", question);
                //command.Parameters.AddWithValue("theme", theme);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                int j = commandArticle.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0 || j > 0);
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region méthode pour la medaille

        /// <summary>
        /// méthode qui permet de charger la table médaille
        /// </summary>
        public void Charger_medaille()
        {
            Charger("select * from Medaille ;", DT3);
        }
        #endregion
    }
}
