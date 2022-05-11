using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP.Adherent
{
    class Adherent
    {
        #region propriétés privées
        private string nomAdherent;
        private string prenomAdherent;
        private string nomEntreprise;
        private string passwordAdherent;
        private string emailAdherent;
        private int activationAdherent;
        private string medaille;
        private string idAdherent;
        #endregion

        #region accesseur
        public string NomAdherent { get => nomAdherent; set => nomAdherent = value; }
        public string PrenomAdherent { get => prenomAdherent; set => prenomAdherent = value; }
        public string PasswordAdherent { get => passwordAdherent; set => passwordAdherent = value; }
        public string EmailAdherent { get => emailAdherent; set => emailAdherent = value; }
        public int ActivationAdherent { get => activationAdherent; set => activationAdherent = value; }
        public string NomEntreprise { get => nomEntreprise; set => nomEntreprise = value; }
        public string Medaille { get => medaille; set => medaille = value; }
        public string IdAdherent { get => idAdherent; set => idAdherent = value; }
        #endregion

        #region Constructeur
        public Adherent(string id, string NAdherent, string PAdherent, string PassAdherent, string MAdherent, int AAdherent, string NEntreprise, string medaille)
        {
            this.IdAdherent = id;
            this.NomAdherent = NAdherent;
            this.PrenomAdherent = PAdherent;
            this.NomEntreprise = NEntreprise;
            this.PasswordAdherent = PassAdherent;
            this.EmailAdherent = MAdherent;
            this.ActivationAdherent = AAdherent;
            this.Medaille = medaille;
        }

        public Adherent(string NAdherent, string PAdherent, string PassAdherent, string MAdherent, int AAdherent, string NEntreprise, string medaille)
        {
            this.NomAdherent = NAdherent;
            this.PrenomAdherent = PAdherent;
            this.NomEntreprise = NEntreprise;
            this.PasswordAdherent = PassAdherent;
            this.EmailAdherent = MAdherent;
            this.ActivationAdherent = AAdherent;
            this.Medaille = medaille;
        }

        public Adherent(string id, string NAdherent)
        {
            this.IdAdherent = id;
            this.NomAdherent = NAdherent;
        }
        #endregion
    }
}
