using SGT_4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SGT_4.Views.Fenetres
{
    public partial class FenetrePersonne : Window
    {
        public ObservableCollection<Personnes> ListePersonnesEnregistrer { get; set; }

        public FenetrePersonne()
        {
            InitializeComponent();
            ListePersonnesEnregistrer = new ObservableCollection<Personnes>();
        }

        private void btnFermer_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            string nom = tbNom.Text;
            string courriel = tbCourriel.Text;
            string departement = tbDepartement.Text;

            if (!string.IsNullOrWhiteSpace(nom) && !string.IsNullOrWhiteSpace(courriel) && !string.IsNullOrWhiteSpace(departement))
            {
                var nouvellePersonne = new Personnes(nom, courriel, departement);
                listViewsPersonne.Items.Add(nouvellePersonne);
                ListePersonnesEnregistrer.Add(nouvellePersonne);
                // Vider les champs après ajout
                tbNom.Text = "";
                tbCourriel.Text = "";
                tbDepartement.Text = "";
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
        }

        private void btnModifier_Click(object sender, RoutedEventArgs e)
        {
            if (listViewsPersonne.SelectedItem is Personnes personneSelectionnee)
            {
                personneSelectionnee.Nom = tbNom.Text;
                personneSelectionnee.Courriel = tbCourriel.Text;
                personneSelectionnee.Departement = tbDepartement.Text;

                // Actualiser l'affichage
                listViewsPersonne.Items.Refresh();

                // Vider les champs après modification
                tbNom.Text = "";
                tbCourriel.Text = "";
                tbDepartement.Text = "";
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une personne à modifier.");
            }
        }

        private void btnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (listViewsPersonne.SelectedItem is Personnes personneSelectionnee)
            {
                // Demander une confirmation de suppression
                MessageBoxResult resultat = MessageBox.Show(
                    "Êtes-vous sûr de vouloir supprimer cette personne ?",
                    "Confirmation de suppression",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Warning);

                // Si l'utilisateur a cliqué sur "Oui", on supprime la personne
                if (resultat == MessageBoxResult.Yes)
                {
                    listViewsPersonne.Items.Remove(personneSelectionnee);
                }
                // Sinon, ne rien faire (annuler la suppression)
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une personne à supprimer.");
            }
        }


        private void listViewsPersonne_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (listViewsPersonne.SelectedItem is Personnes personneSelectionnee)
            {
                // Remplir les champs avec les informations de la personne sélectionnée
                tbNom.Text = personneSelectionnee.Nom;
                tbCourriel.Text = personneSelectionnee.Courriel;
                tbDepartement.Text = personneSelectionnee.Departement;
            }
        }

        private void btnReinitialiser_Click(object sender, RoutedEventArgs e)
        {
            tbNom.Text = "";
            tbCourriel.Text = "";
            tbDepartement.Text = "";
        }


    }
}
