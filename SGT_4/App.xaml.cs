using SGT_4.Models;
using System.Configuration;
using System.Data;
using System.Windows;

namespace SGT_4
{

    public partial class App : Application
    {
        // Liste partagée pour stocker les tickets
        public List<Tickets> TicketsList { get; set; } = new List<Tickets>();

        // Liste partagée pour stocker les personnes 
        public List<Personnes> PersonnesList { get; set; } = new List<Personnes>();
    }

}
