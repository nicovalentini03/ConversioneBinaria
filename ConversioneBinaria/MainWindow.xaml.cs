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

namespace ConversioneBinaria
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string n = TxtBinary.Text;
            if (Combobox.SelectedIndex == 0)
            {
                int ris = Convert.ToInt32(n, 2);
                TxtConversione.Text = ris.ToString();

            }
            else if (Combobox.SelectedIndex == 1)
            {
                int a = int.Parse(n);
                string ris = Convert.ToString(a, 2);
                TxtConversione.Text = ris.ToString();
            }
              




        }
    }
}
