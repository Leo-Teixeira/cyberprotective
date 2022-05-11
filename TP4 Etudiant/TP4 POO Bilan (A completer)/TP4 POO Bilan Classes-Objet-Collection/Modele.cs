using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace TP4_POO_Bilan_Classes_Objet_Collection
{
    public class Modele
    {
        private MySqlConnection myConnection; // objet de connexion
        private bool connopen = false; // test si la connexion est faite
        private bool chargement = false; // test si le chargement d'une requête est fait
        private DataTable dT1 = new DataTable();
        private DataTable dT2 = new DataTable();
        private Bien unBien;

        #region accesseur
        public bool Connopen { get => connopen; set => connopen = value; }
        public bool Chargement { get => chargement; set => chargement = value; }
        public DataTable DT1 { get => dT1; set => dT1 = value; }
        public DataTable DT2 { get => dT2; set => dT2 = value; }
        #endregion
        /// <summary>
        /// Méthode pour se connecter à la BD
        /// </summary>
        public void seconnecter()
        {
            // paramètres de connexion à modifier selon sa BD et son serveur de BD
            string myConnectionString = "Database=slam_immobillier; Data Source=localhost; User Id = root; Password =; ";
            myConnection = new MySqlConnection(myConnectionString);
            try // tentative
            {
                myConnection.Open();
                connopen = true;
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur ouverture bdd : " + err, "PBS connection",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                connopen = false;
            }
        }
        /// <summary>
        /// Méthode pour se déconnecter de la BD
        /// </summary>
        public void sedeconnecter()
        {
            if (!connopen)
                return;
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                connopen = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur fermeture bdd : " + err, "PBS deconnection",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Méthode générique pour charger les données issues d'une requête dans un dataTable
        /// </summary>
        /// <param name="requete"></param>
        /// <param name="DT"></param>
        public void charger(string requete, DataTable DT)
        {
            MySqlCommand command = myConnection.CreateCommand();
            MySqlDataReader reader;
            try
            {
                command.CommandText = requete;
                reader = command.ExecuteReader();
                DT.Load(reader);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "PBS table",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                chargement = false;
            }
        }
        public void charger_donnees(string table)
        {
            charger("select * from bien;", dT1);
        }

        public void charger_donneesVille()
        {
            charger("select distinct villeBien from bien;", DT2);
        }


        
        /// <summary>
        /// Méthode qui permet d'ajouter un bien avec l'ensemble de ses données
        /// </summary>
        /// <returns>bool</returns>
       public bool AjoutBIEN(string adr, string v, int surf, int nbP, int nbC, int nbSE,int prix, int typeB)
        {
            try
            {
             
                // préparation de la requête avec des paramètres
                string requete = "insert into bien values (NULL, @adresse, @ville, @surface,@nbP, @nbC, @nbSE, @p, @tb)";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                // mise à jour des paramètres de la requête préparée avec les infos passées en paramètre de la méthode
                command.Parameters.AddWithValue("adresse", adr);
                command.Parameters.AddWithValue("ville", v);
                command.Parameters.AddWithValue("surface", surf);
                command.Parameters.AddWithValue("nbP", nbP);
                command.Parameters.AddWithValue("nbC", nbC);
                command.Parameters.AddWithValue("nbSE", nbSE);
                command.Parameters.AddWithValue("p", prix);
                command.Parameters.AddWithValue("tb", typeB);
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

        public bool ModifBien(int idBien, string adr, string v, int surf, int nbP, int nbC, int nbSE, int prix, int typeB)
        {
            try
            {
                string Update = "update bien set adresseBien = @adresse, villeBien = @ville, surface = @surface, nbPiece = @nbP, nbChambre = @nbC, nbSalleEau = @nbSE, prix = @p, typeBien = @tb where idBien = @idBien";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = Update;
            
                // mise à jour des paramètres de la requête préparée avec les infos passées en paramètre de la méthode
                command.Parameters.AddWithValue("adresse", adr);
                command.Parameters.AddWithValue("ville", v);
                command.Parameters.AddWithValue("surface", surf);
                command.Parameters.AddWithValue("nbP", nbP);
                command.Parameters.AddWithValue("nbC", nbC);
                command.Parameters.AddWithValue("nbSE", nbSE);
                command.Parameters.AddWithValue("p", prix);
                command.Parameters.AddWithValue("tb", typeB);
                command.Parameters.AddWithValue("idBien", idBien);
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

        public bool SupprBien(int idBien)
        {
            try
            {
                string Suppr = "delete from bien where idBien = @idBien";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = Suppr;
                // Exécution de la requête
                command.Parameters.AddWithValue("idBien", idBien);
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }
    }

}
