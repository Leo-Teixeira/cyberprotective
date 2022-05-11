using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP.article.Theme
{
    class CThemes
    {
        #region propriétés privées
        private string theme;
        private int idTheme;
        #endregion

        #region accesseur
        public string Theme { get => theme; set => theme = value; }
        public int IdTheme { get => idTheme; set => idTheme = value; }
        #endregion

        #region constructeur
        public CThemes (int id, string unTheme)
        {
            this.IdTheme = id;
            this.Theme = unTheme;
        }

        public CThemes (string unTheme)
        {
            this.Theme = unTheme;
        }
        #endregion
    }
}
