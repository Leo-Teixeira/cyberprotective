using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_POO_Bilan_Classes_Objet_Collection
{
    public static class Controleur
    {
        private static Modele vmodele;
        public static void init()
        {
            Vmodele = new Modele();
        }

        #region assecceurs
        public static Modele Vmodele { get => vmodele; set => vmodele = value; }
        #endregion

    }
}
