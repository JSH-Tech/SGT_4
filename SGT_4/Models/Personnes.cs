using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public class Personnes: INotifyPropertyChanged
    {
		private static int compteur = 1;
		private int matricule;
		private string? nom;
		private string? courriel;
		private string? departement;
		private List<Tickets> listeTicketsUnePersonne;
        public Personnes(string? nom, string? courriel, string? departement)
        {
			this.matricule = compteur;
            Nom = nom;
            Courriel = courriel;
            Departement = departement;
            listeTicketsUnePersonne = new List<Tickets>();
            compteur++;
        }

        public List<Tickets> ListeTicketsUnePersonne
        {
            get { return this.listeTicketsUnePersonne; }
        }

        // Implémentation de INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        // Méthode pour déclencher l'événement PropertyChanged
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        // Propriétés avec notification de changement
        public string? Departement
        {
            get { return this.departement; }
            set
            {
                if (this.departement != value)
                {
                    this.departement = value;
                    OnPropertyChanged(nameof(Departement)); 
                }
            }
        }

        public string? Courriel
        {
            get { return this.courriel; }
            set
            {
                if (this.courriel != value)
                {
                    this.courriel = value;
                    OnPropertyChanged(nameof(Courriel)); 
                }
            }
        }

        public string? Nom
        {
            get { return this.nom; }
            set
            {
                if (this.nom != value)
                {
                    this.nom = value;
                    OnPropertyChanged(nameof(Nom));
                }
            }
        }

        public int Matricule
        {
            get { return this.matricule; }
            set
            {
                if (this.matricule != value)
                {
                    this.matricule = value;
                    OnPropertyChanged(nameof(Matricule)); 
                }
            }
        }


    }
}
