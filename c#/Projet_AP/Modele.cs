using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP
{
    class Modele
    {
        private static BDD vmodele;
        public static void init()
        {
            Vmodele = new BDD();
        }

        #region assecceurs
        public static BDD Vmodele { get => vmodele; set => vmodele = value; }
        #endregion
    }
}
