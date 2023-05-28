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
    /// Логика взаимодействия для Theme5.xaml
    /// </summary>
    public partial class Theme5 : Page
    {
        public Theme5()
        {
            InitializeComponent();
        }

        

        private void T1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void T2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void t3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void t4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void t7_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void t8_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void HoooBa5_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.CoreNa?.Navigate(new Alltheme());
        }

        private void t5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void t6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
