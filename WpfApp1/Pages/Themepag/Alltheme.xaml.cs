using MaterialDesignThemes.Wpf;
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
using WpfApp1.Pages.Themepag.NavThemePag;
using static WpfApp1.Core.Corere;

namespace WpfApp1.Pages.Themepag
{
    /// <summary>
    /// Логика взаимодействия для Alltheme.xaml
    /// </summary>
    public partial class Alltheme : Page
    {
        public Alltheme()
        {
            InitializeComponent();
        }

        private void t0_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.CoreNa?.Navigate(new Theme1());

        }

        private void t1_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.CoreNa?.Navigate(new Theme2());
        }

        private void t3_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.CoreNa?.Navigate(new Theme3());
        }

        private void t4_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.CoreNa?.Navigate(new Theme4());
        }

        private void t5_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.CoreNa?.Navigate(new Theme5());
        }

        private void t6_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.CoreNa?.Navigate(new Theme6());
        }

        private void t7_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.CoreNa?.Navigate(new Theme7());
        }

        private void Homeba_Click(object sender, RoutedEventArgs e)
        {
            CoreNav.CoreNa?.Navigate(new MainPage1());
        }
    }
}
