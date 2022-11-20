using P01BazaDanych.Models;
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

namespace P01BazaDanych
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, RoutedEventArgs e)
        {
            BazaTestowaContext db = new BazaTestowaContext();

            var zawodnicy = db.Osobies.ToArray();

            lblDane.ItemsSource = zawodnicy;
            lblDane.DisplayMemberPath = "DaneDoWyswietlenia";
        }

        private void btnZapisz_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}