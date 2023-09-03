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

namespace WpfEnergyCalculator
{
    /// <summary>
    /// Логика взаимодействия для RoomsView.xaml
    /// </summary>

    public partial class RoomsView : Window
    {
        public ObservableCollection<RoomData> RoomPropertyList { get; set; }
        public RoomsView()
        {
            InitializeComponent();
            this.DataContext = this;
            RoomPropertyList = DBSample._RoomPropertyList;
        }
        private void ShowRoomDetail(object sender, RoutedEventArgs e)
        {
            if (RoomForm.SelectedItem is RoomData)
            {
               RoomProperties roomPropertyWindow = new RoomProperties();
                roomPropertyWindow.Show();
            }
            else
            {
                MessageBox.Show("Не заполнены данные");
            }
        }
    }
}
