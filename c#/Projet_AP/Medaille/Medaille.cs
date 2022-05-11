using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP.Medaille
{
    class Medaille
    {
        #region propriétés privées
        private string idMedaille;
        private string testMedaille;
        #endregion

        #region accesseur
        public string IdMedaille { get => idMedaille; set => idMedaille = value; }
        public string TestMedaille { get => testMedaille; set => testMedaille = value; }
        #endregion

        #region constructeur
        public Medaille (string id, string nom)
        {
            this.IdMedaille = id;
            this.TestMedaille = nom;
            #endregion
        }
    }
}
