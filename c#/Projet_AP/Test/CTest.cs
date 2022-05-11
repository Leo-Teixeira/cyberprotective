using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP.Test
{
    class CTest
    {
        #region propriétés privés
        private string question;
        private string reponse1;
        private bool vrai1;
        private bool faux1;
        private string reponse2;
        private bool vrai2;
        private bool faux2;
        private string reponse3;
        private bool vrai3;
        private bool faux3;
        private string reponse4;
        private bool vrai4;
        private bool faux4;
        private int id;
        #endregion

        #region accesseur

        public string Question { get => question; set => question = value; }
        public string Reponse1 { get => reponse1; set => reponse1 = value; }
        public bool Vrai1 { get => vrai1; set => vrai1 = value; }
        public bool Faux1 { get => faux1; set => faux1 = value; }
        public string Reponse2 { get => reponse2; set => reponse2 = value; }
        public bool Vrai2 { get => vrai2; set => vrai2 = value; }
        public bool Faux2 { get => faux2; set => faux2 = value; }
        public string Reponse3 { get => reponse3; set => reponse3 = value; }
        public bool Vrai3 { get => vrai3; set => vrai3 = value; }
        public bool Faux3 { get => faux3; set => faux3 = value; }
        public string Reponse4 { get => reponse4; set => reponse4 = value; }
        public bool Vrai4 { get => vrai4; set => vrai4 = value; }
        public bool Faux4 { get => faux4; set => faux4 = value; }
        public int Id { get => id; set => id = value; }
        #endregion

        #region constructeur
        public CTest(int id, string question, string R1, bool V1, bool F1, string R2, bool V2, bool F2, string R3, bool V3, bool F3, string R4, bool V4, bool F4)
        {
            this.Id = id;
            this.Question = question;
            this.Reponse1 = R1;
            this.Vrai1 = V1;
            this.Faux1 = F1;
            this.Reponse2 = R2;
            this.Vrai2 = V2;
            this.Faux2 = F2;
            this.Reponse3 = R3;
            this.Vrai3 = V3;
            this.Faux3 = F3;
            this.Reponse4 = R4;
            this.Vrai4 = V4;
            this.Faux4 = F4;
        }
        #endregion

    }
}
