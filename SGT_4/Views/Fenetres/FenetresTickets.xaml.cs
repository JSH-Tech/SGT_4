using SGT_4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace SGT_4.Styles
{
    //*****************************// 
    // Numéro du groupe : // 
    //Yao Josue Abotsidia 
    //Brenda Lydie Guekam Fongang
    //Adoté Jovani Akue-Goeh
    //*******************************// 
    public partial class FenetresTickets : Window
    {
        public ObservableCollection<Personnes>? ListePersonnes { get; set; }
        internal Personnes? SelectedPersonne { get; set; }


        public FenetresTickets()
        {
            InitializeComponent();
            DataContext = this;
            ComboBox_personne.ItemsSource = ListePersonnes;
            
        }

        private void btn_Ajouter_Click(object sender, RoutedEventArgs e)
        {
            // Récupération et vérification des champs de texte
            string titre = textBox_titre.Text.Trim();
            string type = ComboBox_type.Text.Trim();
            string commentaire = textBox_commentaire.Text.Trim();
            string categorie = ComboBox_Categorie.Text.Trim();
            string priorite = ComboBox_Priorite.Text.Trim();
            string statut = ComboBox_statut.Text.Trim();

            if (string.IsNullOrEmpty(titre) ||string.IsNullOrEmpty(type) || string.IsNullOrEmpty(categorie) || string.IsNullOrEmpty(priorite) || string.IsNullOrEmpty(statut))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
                return;
            }

            // Vérification de la sélection des dates

            if (!DatePicker_dateCreation.SelectedDate.HasValue)
            {
                MessageBox.Show("Veuillez entrer les dates de création et de fermeture.");
                return;
            }
            // Récupération des dates

            DateOnly dateCreation = DateOnly.FromDateTime(DatePicker_dateCreation.SelectedDate.Value);
            DateOnly dateFermeture = DatePicker_dateFermeture.SelectedDate.HasValue ? DateOnly.FromDateTime(DatePicker_dateFermeture.SelectedDate.Value): DateOnly.MinValue;


            // Création du ticket, même si SelectedPersonne est null
            Tickets nouveauTicket = new Tickets(titre, type, categorie, priorite, statut, commentaire, dateCreation, dateFermeture, SelectedPersonne );

            // Ajoutez le ticket à la liste ou à la collection utilisée pour le ListView
            listViewsTickets.Items.Add( nouveauTicket );
            MessageBox.Show("Ajout effectuer avec success");

            // Réinitialisation des champs

            textBox_titre.Text = "";
            ComboBox_type.SelectedIndex = -1;
            textBox_commentaire.Text = "";
            ComboBox_Categorie.SelectedIndex = -1;
            ComboBox_Priorite.SelectedIndex = -1;
            ComboBox_statut.SelectedIndex = -1;
            DatePicker_dateCreation.SelectedDate = null;
            DatePicker_dateFermeture.SelectedDate = null;
            SelectedPersonne = null;
        }

        private void listViewsTickets_ligneSelectionne(object sender, SelectionChangedEventArgs e)
        {
            Tickets ticketSelectionne = (Tickets)listViewsTickets.SelectedItem;
            if (ticketSelectionne != null)
            {
                // Remplir les champs de texte et de sélection avec les valeurs du ticket sélectionné
                textBox_titre.Text = ticketSelectionne.Titre;
                ComboBox_type.Text = ticketSelectionne.Type;
                textBox_commentaire.Text = ticketSelectionne.Commentaire;
                ComboBox_Categorie.Text = ticketSelectionne.Categorie;
                ComboBox_Priorite.Text = ticketSelectionne.Priorite;
                ComboBox_statut.Text = ticketSelectionne.Status;

                // Remplir les dates si elles sont disponibles
                DatePicker_dateCreation.SelectedDate = ticketSelectionne.DateCreation.ToDateTime(TimeOnly.MinValue);
                DatePicker_dateFermeture.SelectedDate = ticketSelectionne.DateFermeture.ToDateTime(TimeOnly.MinValue);

                // Charger la personne associée s'il y en a une
                SelectedPersonne = ticketSelectionne.PersonneT;
            }
        }

        private void btn_Modifier_Click(object sender, RoutedEventArgs e)
        {
            // Récupère le ticket sélectionné dans la ListView
            Tickets ticketSelectionne = (Tickets)listViewsTickets.SelectedItem;

            // Vérifie si un ticket est sélectionné
            if (ticketSelectionne != null)
            {
                // Met à jour les informations du ticket avec les valeurs des champs de saisie
                ticketSelectionne.Titre = textBox_titre.Text.Trim();
                ticketSelectionne.Type = ComboBox_type.Text.Trim();
                ticketSelectionne.Categorie = ComboBox_Categorie.Text.Trim();
                ticketSelectionne.Priorite = ComboBox_Priorite.Text.Trim();
                ticketSelectionne.Status = ComboBox_statut.Text.Trim();
                ticketSelectionne.Commentaire = textBox_commentaire.Text.Trim();

                // Associe la personne sélectionnée au ticket si une personne est sélectionnée
                if (SelectedPersonne != null)
                {
                    ticketSelectionne.PersonneT = SelectedPersonne;
                }

                // Met à jour les dates de création et de fermeture si elles sont spécifiées
                if (DatePicker_dateCreation.SelectedDate.HasValue)
                {
                    ticketSelectionne.DateCreation = DateOnly.FromDateTime(DatePicker_dateCreation.SelectedDate.Value);
                }

                if (DatePicker_dateFermeture.SelectedDate.HasValue)
                {
                    ticketSelectionne.DateFermeture = DateOnly.FromDateTime(DatePicker_dateFermeture.SelectedDate.Value);
                }

                // Message de confirmation de modification
                MessageBox.Show("Ticket modifié avec succès.");

                // Réinitialise les champs de saisie après modification
                textBox_titre.Text = "";
                ComboBox_type.SelectedIndex = -1;
                textBox_commentaire.Text = "";
                ComboBox_Categorie.SelectedIndex = -1;
                ComboBox_Priorite.SelectedIndex = -1;
                ComboBox_statut.SelectedIndex = -1;
                DatePicker_dateCreation.SelectedDate = null;
                DatePicker_dateFermeture.SelectedDate = null;
                SelectedPersonne = null;

                // Rafraîchit la ListView pour afficher les modifications
                listViewsTickets.Items.Refresh();
            }
            else
            {
                // Message d'erreur si aucun ticket n'est sélectionné
                MessageBox.Show("Veuillez sélectionner un ticket à modifier.");
            }
        }


        private void btn_Supprimer_Click(object sender, RoutedEventArgs e)
        {
            Tickets ticketSelectionne = (Tickets)listViewsTickets.SelectedItem;
            if (ticketSelectionne != null)
            {
                // Demander à l'utilisateur une confirmation avant de supprimer
                MessageBoxResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce ticket ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    // Supprime le ticket sélectionné de la ListView
                    listViewsTickets.Items.Remove(ticketSelectionne);
                    MessageBox.Show("Ticket supprimé avec succès.");

                    // Réinitialiser les champs après suppression
                    textBox_titre.Text = "";
                    ComboBox_type.SelectedIndex = -1;
                    textBox_commentaire.Text = "";
                    ComboBox_Categorie.SelectedIndex = -1;
                    ComboBox_Priorite.SelectedIndex = -1;
                    ComboBox_statut.SelectedIndex = -1;
                    DatePicker_dateCreation.SelectedDate = null;
                    DatePicker_dateFermeture.SelectedDate = null;
                    SelectedPersonne = null;
                }
                else
                {
                    // Si l'utilisateur clique sur Non, annule la suppression
                    MessageBox.Show("Suppression annulée.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un ticket à supprimer.");
            }
        }

        private void btn_Reinitialser_Click(object sender, RoutedEventArgs e)
        {
            textBox_titre.Text = "";
            ComboBox_type.SelectedIndex = -1;
            textBox_commentaire.Text = "";
            ComboBox_Categorie.SelectedIndex = -1;
            ComboBox_Priorite.SelectedIndex = -1;
            ComboBox_statut.SelectedIndex = -1;
            DatePicker_dateCreation.SelectedDate = null;
            DatePicker_dateFermeture.SelectedDate = null;
            SelectedPersonne = null;
        }

        private void btn_Fermer_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
