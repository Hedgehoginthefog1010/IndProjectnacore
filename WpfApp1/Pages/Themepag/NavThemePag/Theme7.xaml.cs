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
    /// Логика взаимодействия для Theme7.xaml
    /// </summary>
    public partial class Theme7 : Page
    {
        public Theme7()
        {
            InitializeComponent();
        }

        private void o1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void o2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void o3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void o5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void o6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void o7_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void o8_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void o9_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void o10_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void HoooBa7_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.CoreNa?.Navigate(new Alltheme());
        }
    }
}
