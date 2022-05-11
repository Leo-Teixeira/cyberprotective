using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionJouets
{
    class Jouets
    {
        public class jeu
        {
            #region proprietes privee
            private int numero;
            private string libelle;
            private int prix;
            private TrancheAge tranche;
            #endregion

            #region accesseur
            public int Numero { get => numero; set => numero = value; }
            public string Libelle { get => libelle; set => libelle = value; }
            public int Prix { get => prix; set => prix = value; }
            public TrancheAge Tranche { get => tranche; set => tranche = value; }
            #endregion

            #region constructeur
            public jeu(int num, string libelle)
            {
                this.Numero = num;
                this.Libelle = libelle;
            }
            #endregion

            public bool convient (int unAge)
            {
                if ( == unAge)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public class A_Competence : jeu
        {
            private string competence;
            private bool parent;

            public string Competence { get => competence; set => competence = value; }
            public bool Parent { get => parent; set => parent = value; }

            public A_Competence(int num, string libelle, string competence) : base(num, libelle)
            {
                this.Competence = competence;
            }
            public A_Competence(int num, string libelle, string competence, bool parent) : base(num, libelle)
            {
                this.Competence = competence;
                this.Parent = parent;
            }
        }

        public class sexue : jeu
        {
            private string sexe;

            public string Sexe { get => sexe; set => sexe = value; }

            public sexue (int num, string libelle, string sexe) : base(num, libelle)
            {
                this.Sexe = sexe;
            }
        }

        public class TrancheAge
        {
            private int code;
            private int ageMini;
            private int ageMax;

            public int Code { get => code; set => code = value; }
            public int AgeMini { get => ageMini; set => ageMini = value; }
            public int AgeMax { get => ageMax; set => ageMax = value; }
            
            public TrancheAge(int c, int aMin, int aMax)
            {
                this.Code = c;
                this.AgeMini = aMin;
                this.AgeMax = aMax;
            }
        }
    }






    }
}
