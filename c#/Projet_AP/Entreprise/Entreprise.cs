using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP.Entreprise
{
    public class Entreprise
    {
        List<Entreprise> lesEntreprise = new List<Entreprise>();

        #region propriétés privées
        private string nom;
        private int activation;
        private string id;
        #endregion

        #region accesseur
        public string Nom { get => nom; set => nom = value; }
        public int Activation { get => activation; set => activation = value; }
        public string Id { get => id; set => id = value; }
        #endregion

        #region constructeur
        public Entreprise (string unNom, int uneActivation)
        {
            this.Nom = unNom;
            this.Activation = uneActivation;
        }

        public Entreprise (string unId, string unNom)
        {
            this.Nom = unNom;
            this.Id = unId;
        }

        public Entreprise (string unId, string unNom, int uneActivation)
        {
            this.Nom = unNom;
            this.Id = unId;
            this.Activation = uneActivation;
        }
        #endregion

    }
}
