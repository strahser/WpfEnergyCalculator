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


namespace WpfEnergyCalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EnclosingStructures taskWindow = new EnclosingStructures();
            taskWindow.Show();
        }

        private void ShowRoomView(object sender, RoutedEventArgs e)
        {
            RoomsView taskWindow = new RoomsView();
            taskWindow.Show();
        }
        
    }
}
