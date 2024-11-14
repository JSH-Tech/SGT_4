using SGT_4.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SGT_4.Fenetres
{
    class Convertisseur
    {
        public class PersonneToStringConverter : IValueConverter
        {
            // Cette méthode convertit l'objet Personnes en une chaîne (Nom ou une valeur par défaut si null)
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                // Si l'objet est de type Personnes, retourne le nom, sinon retourne "Aucune personne"
                return value is Personnes personne ? personne.Nom : "Aucune personne";
            }

            // Cette méthode ConvertBack n'est pas nécessaire dans ce cas
            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                return null; // Ce convertisseur ne gère pas la conversion dans l'autre sens
            }
        }
    }
}
