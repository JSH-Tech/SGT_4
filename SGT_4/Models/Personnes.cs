using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGT_4.Models
{
    internal class Personnes
    {
		private static int compteur = 1;
		private int matricule;
		private string? nom;
		private string? courriel;
		private string? departement;
		public List<Tickets> listeTicketsUnePersonne;
        public Personnes(string? nom, string? courriel, string? departement)
        {
			this.matricule = compteur;
            this.nom = Nom;
            this.courriel = Courriel;
            this.departement = Departement;
            listeTicketsUnePersonne = new List<Tickets>();
            compteur++;
        }

        public string? Departement
        {
			get { return this.departement; }
			set { this.departement = value; }
		}

		public string? Courriel
        {
			get { return this.courriel; }
			set { this.courriel = value; }
		}


		public string? Nom
        {
			get { return this.nom; }
			set { this.nom = value; }
		}


		public int Matricule
        {
			get { return this.matricule; }
			set { this.matricule = value; }
		}

	}
}
