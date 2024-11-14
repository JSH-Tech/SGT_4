using SGT_4.Styles;
using SGT_4.Views.Fenetres;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SGT_4
{
    //*****************************// 
    // Numéro du groupe : // 
    //Yao Josue Abotsidia 
    //Brenda Lydie Guekam Fongang
    //Adoté Jovani Akue-Goeh
    //*******************************// 

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btn_ticket_Click(object sender, RoutedEventArgs e)
        {
            FenetresTickets fenetresTickets = new FenetresTickets();
            fenetresTickets.Show();
        }

        private void btn_personne_Click(object sender, RoutedEventArgs e)
        {
            FenetrePersonne fenetrePersonne = new FenetrePersonne();
            fenetrePersonne.Show();
        }
    }
}