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

namespace WpfApp1.Pages.Themepag.NavThemePag.iNTe
{
    /// <summary>
    /// Логика взаимодействия для interpag.xaml
    /// </summary>
    public partial class interpag : Page
    {
        public interpag()
        {
            InitializeComponent();
        }

        private void Homme_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.CoreNa?.Navigate(new Theme2());
        }
    }
}
