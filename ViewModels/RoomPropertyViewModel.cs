using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfEnergyCalculator.ViewModel;

namespace WpfEnergyCalculator.ViewModels
{
    class RoomPropertyViewModel: ViewModelBase
    {


        private double _roomGeometryArea;

        public double RoomGeometryArea
        {
            get { return _roomGeometryArea; }

            set
            {
                if (value != _roomGeometryArea)
                {
                    _roomGeometryArea = value;
                    OnPropertyChanged("RoomGeometryArea");
                }
            }
        }
        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj =>

                  MessageBox.Show(obj.ToString())));

            }
        }

 
        

    }
}
