using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP.article
{
    class Article
    {
        #region propriétés privées
        private string titreArticle;
        private string chapeauArticle;
        private string dateArticle;
        private string resumeArticle;
        private int activation;
        private string imgArticle;
        private string lienArticle;
        private int idArticle;
        #endregion

        #region accesseurs
        public string TitreArticle { get => titreArticle; set => titreArticle = value; }
        public string ChapeauArticle { get => chapeauArticle; set => chapeauArticle = value; }
        public string DateArticle { get => dateArticle; set => dateArticle = value; }
        public string ResumeArticle { get => resumeArticle; set => resumeArticle = value; }
        public int Activation { get => activation; set => activation = value; }
        public string ImgArticle { get => imgArticle; set => imgArticle = value; }
        public string LienArticle { get => lienArticle; set => lienArticle = value; }
        public int IdArticle { get => idArticle; set => idArticle = value; }
        #endregion

        #region constructeur
        public Article (string titre, string chapeau, string date, string resume, string image, string lien, int activation)
        {
            this.TitreArticle = titre;
            this.ChapeauArticle = chapeau;
            this.DateArticle = date;
            this.ResumeArticle = resume;
            this.Activation = activation;
            this.ImgArticle = image;
            this.LienArticle = lien;
        }
        public Article(int id, string titre, string chapeau, string date, string resume, string image, string lien, int activation)
        {
            this.TitreArticle = titre;
            this.ChapeauArticle = chapeau;
            this.DateArticle = date;
            this.ResumeArticle = resume;
            this.Activation = activation;
            this.ImgArticle = image;
            this.LienArticle = lien;
            this.IdArticle = id;
        }
        #endregion

    }
}
