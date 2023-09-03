using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfEnergyCalculator.Models;
using WpfEnergyCalculator.Tests;
using WpfEnergyCalculator.ViewModels;
namespace WpfEnergyCalculator
{



    /// <summary>
    /// Логика взаимодействия для EnclosingStructures.xaml
    /// </summary>
    public partial class EnclosingStructures : Window
    {

        public ObservableCollection<StructureInstance> MyData { get; set;}
        public ObservableCollection<StructurePropertys> StructurePropertyList { get; set; }

        public EnclosingStructures()
        {
            InitializeComponent();

            // for binding
            DataContext = this;
               MyData = DBSample._structure_collection;

        }
        private void ChangeText(object sender, RoutedEventArgs e)
        {
            if (EnclosingStructureForm.SelectedItem is StructureInstance structure_model)
            {
                ThermalProperties thermal_property_view = new ThermalProperties(structure_model);
                thermal_property_view.Show();
            }
            else
            {
                MessageBox.Show("Не заполнены данные");
            }
        }

    }

}
