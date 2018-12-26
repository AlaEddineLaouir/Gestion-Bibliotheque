using System;


namespace ServiceFournis
{
    [Serializable]
    public class Ouvrague
    {
        private String typeOuvrague;
        private String theme;
        private String auteur;
        private String titre;
        private String code;

        public Ouvrague(string typeOuvrague, string theme, string auteur, string titre, string code)
        {
            this.TypeOuvrague = typeOuvrague;
            this.Theme = theme;
            this.Auteur = auteur;
            this.Titre = titre;
            this.Code = code;
        }

        public string TypeOuvrague { get => typeOuvrague; set => typeOuvrague = value; }
        public string Theme { get => theme; set => theme = value; }
        public string Auteur { get => auteur; set => auteur = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Code { get => code; set => code = value; }
    }
}
