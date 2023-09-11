using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfEnergyCalculator.Data;
using WpfEnergyCalculator.Models;
using WpfEnergyCalculator.ViewModel;

namespace WpfEnergyCalculator.ViewModels
{
    public class RoomViewModels : ViewModelBase
    {

        
        private RoomData _selectedRoom;

        private ObservableCollection<RoomData> _roomdataList;
        private RelayCommand _updateRoomsList;
        private ICommand _deleteRoomCommand;

//Data Grid Source

        public ObservableCollection<RoomData> RoomDatList
        {
            get { return _roomdataList; }
            set
            {
                _roomdataList = value;
                OnPropertyChanged(nameof(RoomDatList));
            }
        }
        public RoomData SelectedRoom
        {
            get { return _selectedRoom; }

            set
            {
                if (value != _selectedRoom)
                {
                    _selectedRoom = value;
                    OnPropertyChanged(nameof(SelectedRoom));
                }
            }
        }

        public RelayCommand UpdateRoomsList
        {
            get
            {

                return _updateRoomsList ??
                  (_updateRoomsList = new RelayCommand(obj => UpdateRooms()));

            }
        }
        public ICommand DeleteRoomCommand
        {
            get
            {
                return _deleteRoomCommand ??
                   (_deleteRoomCommand = new RelayCommand(obj => DeleteRoomData()));


            }
        }


        private void UpdateRooms()
        {
            using (MyDbContext db = new MyDbContext())
            {
                RoomDatList = new ObservableCollection<RoomData>(db.RoomData.ToList());

            }
        }

        public void DeleteRoomData()
        {

            using (MyDbContext db = new MyDbContext())
            {
                
                RoomData selectedRoom = SelectedRoom ;
                MessageBoxResult result = MessageBox.Show($"Вы хотите удалить комнату {selectedRoom.RoomDataID}", "Удаление из базы данных", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.Yes);

                if (selectedRoom != null && result == MessageBoxResult.Yes)
                {
                    RoomData room = db.RoomData.Single(x => x.RoomDataID == selectedRoom.RoomDataID);
                    db.RoomData.Remove(room);
                    db.SaveChanges();
                    MessageBox.Show($"Комната {room.RoomDataID} успешно удалена");
                    UpdateRooms();

                }
            }
        }

        public RoomViewModels()
        {
            UpdateRooms();
        }
    }


}
