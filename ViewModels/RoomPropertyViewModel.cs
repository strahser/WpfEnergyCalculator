using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfEnergyCalculator.ViewModel;
using WpfEnergyCalculator.Models;
using WpfEnergyCalculator.Data;

namespace WpfEnergyCalculator.ViewModels
{
    class RoomPropertyViewModel: ViewModelBase
    {
        #region Constructors
        public RoomPropertyViewModel()
        {
            _chooseAction = "New";
            RoomArea = 1;
            RoomHeight = 1;
            RoomProperty = RoomProperty;
            RoomType = RoomType;
            _roomTypeList = new List<string>()
            {
                "Жилое","Не Жилое"
            };
            _roomPropertyList = new List<string>()
            {
                "Отапливаемые","Не Отапливаемые"
            };
        }

        public RoomPropertyViewModel(RoomData __selectedRoom)
        {       

            _roomTypeList = new List<string>()
            {
                "Жилое","Не Жилое"
            };
            _roomPropertyList = new List<string>()
            {
                "Отапливаемые","Не Отапливаемые"
            };
            _selectedRoom = __selectedRoom;
            RoomArea = _selectedRoom.RoomArea;
            RoomHeight = _selectedRoom.RoomHeight;
            RoomProperty = _selectedRoom.RoomProperty;
            RoomType = _selectedRoom.RoomType;
        }
        #endregion

        #region Privat propertys
        private string _chooseAction=null;
        private List<string> _roomTypeList;
        private List<string> _roomPropertyList;  
        private RoomData _selectedRoom;
        private double _roomArea;
        private double _roomHeight;
        private string _roomProperty;
        private string _roomType;
        #endregion

        #region Collections
        public List<string> RoomPropertyList
        {
            get { return _roomPropertyList;}
            set
            {
                _roomPropertyList = value;
                OnPropertyChanged("RoomPropertyList");
            }
        }
        public List<string> RoomTypeList
        {
            get { return _roomTypeList; }

            set
            {
                _roomTypeList = value;
                OnPropertyChanged("RoomTypeList");
            }
        }

        #endregion


        #region Propertys

        public double RoomArea
        {
            get { return _roomArea; }

            set
            {
                if (value != _roomArea)
                {
                    _roomArea = value;
                    OnPropertyChanged("RoomArea");
                }
            }
        }

        public RoomData SelectedRoom
        {
            get { return _selectedRoom; }
            set { if (value != _selectedRoom)
                {
                    _selectedRoom = value;
                    OnPropertyChanged("SelectedRoom");
                }
                    
                        } 
        }




        public double RoomHeight
        {
            get { return _roomHeight; }

            set
            {
                if (value != _roomHeight)
                {
                    _roomHeight = value;
                    OnPropertyChanged("RoomHeight");
                }
            }
        }

        public string RoomProperty
        {
            get { return _roomProperty; }

            set
            {
                if (value != _roomProperty)
                {
                    _roomProperty = value;
                    OnPropertyChanged("RoomProperty");
                }
            }
        }


        public string RoomType
        {
            get { return _roomType; }

            set
            {
                if (value != _roomType)
                {
                    _roomType = value;
                    OnPropertyChanged("RoomType");
                }
            }
        }



        #endregion


        #region Commands
        private RelayCommand _updateRoomsFactoryCommand;
        private RelayCommand _addCommand;
        

        public RelayCommand UpdateRoomsFactoryCommand
        {
            get
            {
                return _updateRoomsFactoryCommand ??
                  (_updateRoomsFactoryCommand = new RelayCommand(obj => UpdateRoomsFactory()));

            }
        }

        public RelayCommand AddRoomCommand
        {
            get
            {
                return _addCommand ??
                  (_addCommand = new RelayCommand(obj => UpdateRoomsFactory()));

            }
        }



        #endregion


        #region Commands Data
        private void UpdateRoomsFactory()
        {
            if (_chooseAction == "New")
            {
                AddNewRoomCommandData();
            }
            else
            {
                UpdateRoomsCommandData();
            }
        }

        private void UpdateRoomsCommandData()
        {


            using (MyDbContext db = new MyDbContext())
            {

                if (SelectedRoom.RoomArea != 0 && SelectedRoom.RoomHeight != 0 && SelectedRoom.RoomProperty != null && SelectedRoom.RoomType != null)
                {
                    try
                    {
                        RoomData _room = db.RoomData.Find(SelectedRoom.RoomDataID);
                        _room.RoomArea = RoomArea;
                        _room.RoomHeight = RoomHeight;
                        _room.RoomProperty = RoomProperty;
                        _room.RoomType = RoomType;
                        db.SaveChanges();
                        MessageBox.Show($"Помещение {SelectedRoom.RoomDataID} изменено" );
                    }

                    catch (Exception ex)

                    {
                        MessageBox.Show("Error occured while saving. " + ex.InnerException);
                    }
                }
                else { MessageBox.Show($"Не Изменена запись {SelectedRoom.RoomDataID} "); }
            }

        }
        private void AddNewRoomCommandData()
        {
            using (MyDbContext db = new MyDbContext())
            {

                if (RoomArea != 0 && RoomHeight != 0 && RoomProperty != null && RoomType != null)
                {
                    try
                    {
                        RoomData _room = new RoomData()
                        {
                            RoomArea = RoomArea,
                            RoomHeight = RoomHeight,
                            RoomProperty = RoomProperty,
                            RoomType = RoomType,
                        };
                        db.RoomData.Add(_room);
                        db.SaveChanges();
                        MessageBox.Show($"Добавлено Помещение {_room.RoomDataID}");
                    }

                    catch (Exception ex)

                    {
                        MessageBox.Show("Error occured while saving. " + ex.InnerException);
                    }
                }
                else { MessageBox.Show($"Не Создана запись. Проверьте данные  "); }
            }
        }
        private RelayCommand _getAllRoomsa;
        public RelayCommand GetAllRoomsa
        {
            get
            {
                return _getAllRoomsa ??
                  (_getAllRoomsa = new RelayCommand(obj => GetAllRoomsCommandData()));

            }
        }

        public void GetAllRoomsCommandData()
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.RoomData.ToList();

            }
        }

        #endregion

    }
}
