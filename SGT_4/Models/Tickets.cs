using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGT_4.Models
{
    //*****************************// 
    // Numéro du groupe : // 
    //Yao Josue Abotsidia 
    //Brenda Lydie Guekam Fongang
    //Adoté Jovani Akue-Goeh
    //*******************************// 
    public class Tickets
    {
        private static int compteur = 1;
        private int id;
        private string? titre;
        private string? type;
        private string? categorie;
        private string? priorite;
        private string? status;
        private string? commentaire;
        private DateOnly dateCreation;
        private DateOnly dateFermeture= DateOnly.MinValue;
        Personnes? personneT;

        public Tickets(string? titre, string? type, string? categorie, string? priorite, string? status, string? commentaire, DateOnly dateCreation, DateOnly dateFermeture, Personnes? personneT = null)
        {
            Titre = titre;
            Type = type;
            Categorie = categorie;
            Priorite= priorite;
            Status = status;
            Commentaire = commentaire;
            DateCreation = dateCreation;
            DateFermeture = dateFermeture;
            PersonneT = personneT;
        }

        public string? Status
        {
            get { return this.status; }
            set { this.status = value; }
        }
        public string? Priorite
        {
            get { return this.priorite; }
            set { this.priorite = value; }
        }

        public string? Categorie
        {
            get { return this.categorie; }
            set { this.categorie = value; }
        }
        public string? Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string? Titre
        {
            get { return this.titre; }
            set { this.titre = value; }
        }

        public string? Commentaire
        {
            get { return this.commentaire; }
            set { this.commentaire = value; }
        }

        public DateOnly DateCreation
        {
            get { return this.dateCreation; }
            set { this.dateCreation = value; }
        }

        public DateOnly DateFermeture
        {
            get { return this.dateFermeture; }
            set { this.dateFermeture = value; }
        }

        public Personnes? PersonneT
        {
            get { return this.personneT; }
            set { this.personneT = value; }
        }
    }
}
