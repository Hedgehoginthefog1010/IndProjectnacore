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
using WpfApp1.Pages.Themepag.NavThemePag.iNTe;

namespace WpfApp1.Pages.Themepag.NavThemePag
{
    /// <summary>
    /// Логика взаимодействия для Theme4.xaml
    /// </summary>
    public partial class Theme4 : Page
    {
        public Theme4()
        {
            InitializeComponent();
        }

        private void HoooBa4_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.CoreNa?.Navigate(new Alltheme());
        }
    }
}
