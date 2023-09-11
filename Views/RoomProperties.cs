using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WpfEnergyCalculator.ViewModels;

namespace WpfEnergyCalculator
{
    /// <summary>
    /// Логика взаимодействия для RoomProperties.xaml
    /// </summary>
    public partial class RoomProperties : Window
    {
        public RoomProperties()
        {

            InitializeComponent();
            RoomPropertyViewModel roomPropertyViewModel = new RoomPropertyViewModel();
            DataContext = roomPropertyViewModel;
        }

        public RoomProperties(RoomData SelectedRoom)
        {

            InitializeComponent();
            RoomPropertyViewModel roomPropertyViewModel = new RoomPropertyViewModel(SelectedRoom);
            DataContext = roomPropertyViewModel;
        }

    }
}
