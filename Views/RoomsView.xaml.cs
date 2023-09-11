using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using WpfEnergyCalculator.Models;
using WpfEnergyCalculator.Tests;
using WpfEnergyCalculator.Data;
using WpfEnergyCalculator.ViewModels;

namespace WpfEnergyCalculator
{
    /// <summary>
    /// Логика взаимодействия для RoomsView.xaml
    /// </summary>

    public partial class RoomsView : Window
    {


        public RoomsView()
        {
            InitializeComponent();
            RoomViewModels roomViewModel = new RoomViewModels();
            DataContext = roomViewModel;
         
            
        }
        private void UpdateRoomDetail(object sender, RoutedEventArgs e)
        {
            if (RoomForm.SelectedItem is RoomData selectedRoom)
            {
               RoomProperties roomPropertyWindow = new RoomProperties(selectedRoom);
               roomPropertyWindow.Show();
               roomPropertyWindow.Owner = this;
            }
            else
            {
                MessageBox.Show("Не заполнены данные");
            }
        }

        private void CreateRoom(object sender, RoutedEventArgs e)
        {

            RoomProperties roomPropertyWindow = new RoomProperties();
            roomPropertyWindow.Show();
            roomPropertyWindow.Owner = this;

        }


    }
}
