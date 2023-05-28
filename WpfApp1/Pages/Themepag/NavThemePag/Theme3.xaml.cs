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
using static WpfApp1.Core.Corere;

namespace WpfApp1.Pages.Themepag.NavThemePag
{
    /// <summary>
    /// Логика взаимодействия для Theme3.xaml
    /// </summary>
    public partial class Theme3 : Page
    {
        public Theme3()
        {
            InitializeComponent();
        }

        private void In4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Мажорное трезвучие состоит из б.3 и м.3.\n" +
               "Такое трезвучие называют ещё «большим».\n" +
               "Между его крайними звуками ч.5 (консонирующий интервал).Минорное трезвучие состоит из м.3 и б.3. " +
               "\nТакое трезвучие называют ещё «мáлым». \nМежду крайними звуками аккорда ч.5 \n" +
               "(консонирующий интервал).\nУвеличенное трезвучие состоит из б.3 и б.3.\n Между крайними звуками ув.5 (диссонирующий интервал).\nУменьшённое трезвучие состоит из м.3 и м.3.\nМежду крайними звуками ум.5 \n(диссонирующий интервал).", 
               "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void HoooBa2_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.CoreNa?.Navigate(new Alltheme());

        }
    }
}
