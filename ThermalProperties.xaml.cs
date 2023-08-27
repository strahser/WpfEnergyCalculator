using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfEnergyCalculator
{
    /// <summary>
    /// Логика взаимодействия для ThermalProperties.xaml
    /// </summary>
    public class StructurePropertys
    {
        public string StructurePropertyId { get; set; }
        public string StructureType { get; set; }
        public string ImagePath { get; set; }
        public double HeatCapacity { get; set; }
        public double StructureThickness { get; set; }
    }
    public partial class ThermalProperties : Window
    {
        public StructureTableView Data { get; set; }
        public ThermalProperties(StructureTableView structure_model)
        {
            Data = structure_model;
            InitializeComponent();
            ConnectionViewModel vm = new ConnectionViewModel();
            DataContext = vm;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((ConnectionViewModel)DataContext).SelectedStructure = "test";
        }
    }


    public class ConnectionViewModel : INotifyPropertyChanged
    {
        public ConnectionViewModel()
        {
            

            ObservableCollection<StructurePropertys>  StructurePropertyList = new ObservableCollection<StructurePropertys>()
               {
                new StructurePropertys() { StructurePropertyId="1", ImagePath ="Images/wall.png", HeatCapacity=4100,StructureThickness=200,StructureType="Стена"},
                new StructurePropertys() {StructurePropertyId="2", ImagePath="Images/wall.png", HeatCapacity=4100,StructureThickness=200,StructureType="Кровля"},
                 new StructurePropertys() {StructurePropertyId="3", ImagePath="Images/wall.png", HeatCapacity=4100,StructureThickness=200,StructureType="Окно"}
               };
            _structure_collection = new CollectionView(StructurePropertyList);
        }



        private  CollectionView _structure_collection;
        private string _selected_structure;

        public CollectionView StructureCollection
        {
            get { return _structure_collection; }
        }

        public string SelectedStructure
        {
            get { return _selected_structure; }
            set
            {
                if (_selected_structure == value) return;
                _selected_structure = value;
                OnPropertyChanged("SelectedStructure");
            }
        }


        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
