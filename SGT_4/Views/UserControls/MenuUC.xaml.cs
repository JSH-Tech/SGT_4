﻿using MaterialDesignThemes.Wpf;
using SGT_4.Views.Fenetres;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SGT_4.Views.UserControls
{
    /// <summary>
    /// Interaction logic for MenuUC.xaml
    /// </summary>
    public partial class MenuUC : UserControl
    {
        public MenuUC()
        {
            InitializeComponent();
        }

        private void btn_personne_Click(object sender, RoutedEventArgs e)
        {
            FenetreListePersonne fenetreListePersonnes = new FenetreListePersonne();
            fenetreListePersonnes.Show();
        }
    }
}
