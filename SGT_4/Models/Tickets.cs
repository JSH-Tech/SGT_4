using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGT_4.Models
{
    internal class Tickets
    {
        private int compteur = 1;
        private int id;
        private string? titre;
        private enum Type{ Panne, Service}
        private enum Categorie{ Materiel, Logiciel, Reseau}
        private enum Priorite{ Basse, Moyenne, Haute, critique}
        private enum Statut{ Ouvert, Ferme}
        private string? commentaire;
        private DateOnly dateCreation;
        private DateOnly dateFertmeture;
        Personnes? personne;
        public Tickets(string? titre, string? commentaire, DateOnly dateCreation, DateOnly dateFertmeture)
        {
            this.id=compteur;
            this.titre = Titre;
            this.commentaire = Commentaire;
            this.dateCreation = DateCreation;
            this.dateFertmeture = DateFertmeture;
            compteur++;
        }

        public string Titre
        {
            get { return this.titre; }
            set { this.titre = value; }
        }

        public string Commentaire
        {
            get { return this.commentaire; }
            set { this.commentaire = value; }
        }

        public DateOnly DateCreation
        {
            get { return this.dateCreation; }
            set { this.dateCreation = value; }
        }

        public DateOnly DateFertmeture
        {
            get { return this.dateFertmeture; }
            set { this.dateFertmeture = value; }
        }
    }
}
