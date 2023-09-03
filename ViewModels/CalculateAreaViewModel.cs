using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfEnergyCalculator.Models;
using WpfEnergyCalculator.ViewModel;

namespace WpfEnergyCalculator.ViewModels
{
    class CalculateAreaViewModel : ViewModelBase
    {
        private bool _isCheckedCalculation;
        private double _geometryArea;


        public bool IsCheckedCalculation
        {
            get { return _isCheckedCalculation; }
            set { _isCheckedCalculation = value; OnPropertyChanged("IsCheckedCalculation"); }
        }
        public double GeometryArea
        {
            get { return _geometryArea; }
            set { _geometryArea = value;
                OnPropertyChanged("GeometryArea");
            }
        }
        public double GeometryLenght { get; set; }
        public double GeometryWidth { get; set; }
        public int GeometryQuantity { get; set; }

        private ICommand _calculateArea;
        public ICommand CalculateArea
        {
            get
            {
                _calculateArea = new RelayCommand(
                    param => CalculateAreaFunck()
                );
                return _calculateArea;
            }
        }
        private void CalculateAreaFunck()
        {
            if (IsCheckedCalculation)
            {
                GeometryArea = GeometryArea;
            }
            else
            {
                GeometryArea = GeometryLenght * GeometryWidth * GeometryQuantity;

            }

        }
    }
}
