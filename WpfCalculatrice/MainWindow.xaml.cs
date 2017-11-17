﻿using System;
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

namespace WpfCalculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Addition addition;
        public MainWindow() //Constructeur
        {
            InitializeComponent();
            addition = new Addition(33, 5); //Instanciation
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            double dblNumber1;
            double dblNumber2;

            if (double.TryParse(tbxNumber1.Text, out dblNumber1)) //Si il a réussi à convertir tbxNumber2 en string, il met le contenu dans dblNumber1
            {
                if (double.TryParse(tbxNumber2.Text, out dblNumber2)) //Si il a réussi à convertir tbxNumber2 en string, il met le contenu dans dblNumber2
                {
                    addition.setVal1(dblNumber1);
                    addition.setVal2(dblNumber2);
                    lblResponse.Content = addition.Additionne();
                    MessageBox.Show(addition.Affiche());
                }
                else
                {
                    MessageBox.Show("Veuillez controler le format des nombre saisis", "Erreur lors de la conversion", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez controler le format des nombre saisis","Erreur lors de la conversion",  MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMul_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}