using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGT_4.Models
{
    internal class Tickets
    {
        private int id;
        private string? titre;
        private enum Type{ Panne, Service}
        private enum Categorie{ Materiel, Logiciel, Reseau}
        private enum Priorite{ Basse, Moyenne, Haute, critique}
        private enum Statut{ Ouvert, Ferme}
        private string? commentaire;
        private DateOnly dateCreation;
        private DateOnly dateFertmeture;
    }
}
