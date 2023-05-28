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
using WpfApp1.Pages.Themepag.NavThemePag.iNTe;
using static WpfApp1.Core.Corere;

namespace WpfApp1.Pages.Themepag.NavThemePag
{
    /// <summary>
    /// Логика взаимодействия для Theme2.xaml
    /// </summary>
    public partial class Theme2 : Page
    {
        public Theme2()
        {
            InitializeComponent();
        }

        private void HoooBa1_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.CoreNa?.Navigate(new Alltheme());

        }

        private void In3_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.CoreNa?.Navigate(new interpag());
        }
    }
}
