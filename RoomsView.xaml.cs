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

namespace WpfEnergyCalculator
{
    /// <summary>
    /// Логика взаимодействия для RoomsView.xaml
    /// </summary>
    public class RoomData
    {
        public string RoomType { get; set; }   
        public string RoomProperty { get; set; }
        public Double RoomArea { get; set; }
        public Double RoomHeight { get; set; }

    }
    public partial class RoomsView : Window
    {
        public ObservableCollection<RoomData> RoomPropertyList { get; set; }
        public RoomsView()
        {
            InitializeComponent();
            this.DataContext = this;

            RoomPropertyList = new ObservableCollection<RoomData>()
            {
                new RoomData()
                {
                    RoomType="Жилые",RoomProperty="Отапливаемые",RoomArea=20,RoomHeight=3
                },
                new RoomData()
                {
                    RoomType="Вспомогательные",RoomProperty="Не Отапливаемые",RoomArea=50,RoomHeight=3
                },


            };

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
