using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace TP4_POO_Bilan_Classes_Objet_Collection
{
    public class Bien
    {
        #region propriétés
        private string adresse, ville;
        private int surface, nbPieces, nbChambres, nbSallesEau, prix;
        private int typeBien; // 2 valeurs possibles : 1 pour appart, 2 pour maison
        private bool vendu;
        private int prixVente;
        #endregion

        #region accesseurs

        public string Adresse { get => adresse; set => adresse = value; }
        public string Ville { get => ville; set => ville = value; }
        public int Surface { get => surface; set { if (value >= 0) surface = value; } }
        public int NbPieces { get => nbPieces; set { if (value >= 0) nbPieces = value; } }
        public int NbChambres { get => nbChambres; set { if (value >= 0 && value <= nbPieces) nbChambres = value; } }
        public int TypeBien { get => typeBien; set { if (value == 1 || value == 2) typeBien = value; } }
        public int NbSallesEau { get => nbSallesEau; set { if (value >= 0 && value < NbPieces) nbSallesEau = value; } }
        public int Prix { get => prix; set { if (value >= 0) prix = value; } }
        public bool Vendu { get => vendu; set => vendu = value; }
        public int PrixVente { get => prixVente; set { if (value >= 0) prixVente = value; } }


        #endregion


        #region constructeur
        /// <summary>
        /// Constructeur de la classe BIEN
        /// </summary>
        /// <param name="unType">entier pour le type du bien</param>
        /// <param name="uneVille">ville du bien</param>
        /// <param name="uneSurface">surface en m2 du bien</param>
        /// <param name="nbP">nb de pièces total du bien</param>
        /// <param name="unPrix">prix à la vente</param>
        public Bien(int unType, string uneVille, int uneSurface, int nbP, int unPrix)
        {
            this.TypeBien = unType;
            this.Ville = uneVille;
            this.Surface = uneSurface;
            this.NbPieces = nbP;
            this.Prix = unPrix;
        }

        public Bien(int unType, string uneVille, int uneSurface, int nbP, int unPrix, int nbC, int nbS, string uneAdresse)
        {
            this.TypeBien = unType;
            this.Ville = uneVille;
            this.Surface = uneSurface;
            this.NbPieces = nbP;
            this.Prix = unPrix;
            this.NbChambres = nbC;
            this.NbSallesEau = nbS;
            this.Adresse = uneAdresse;
        }

        #endregion

        #region méthodes
        /// <summary>
        /// Méthode qui retourne une chaine avec les informations indispensables sur le bien
        /// </summary>
        /// <returns>chaine de caractère</returns>
        public string Afficher()
        {
            return (RetourneTypeBien() + " situé(e) à " + ville + "\nd'une surface de " + Surface + "m2\nde " + nbPieces + " pièces\nPrix : " + Prix + " €");
        }

        /// <summary>
        /// Méthode qui retourne une chaine relative au type de bien : 1 : Appartement 2 : Maison
        /// </summary>
        /// <returns>chaine de caractères</returns>
        public string RetourneTypeBien()
        {
            string tb = "";
            if (TypeBien == 1)
            {
                tb = "Appartement";
            }
            else if (TypeBien == 2)
            {
                tb = "Maison";
            }
            else
            {
                return ("erreur");
            }
            return tb;
        }
        #endregion

    }
}
