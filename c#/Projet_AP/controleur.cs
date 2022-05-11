using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP
{
    public static class controleur
    {
        private static BDD vmodele;
        public static void Init()
        {
            Vmodele = new BDD();
        }

        #region assecceurs
        public static BDD Vmodele { get => vmodele; set => vmodele = value; }
        #endregion
    }
}
