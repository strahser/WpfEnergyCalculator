using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfEnergyCalculator
{

    public class StructureTableView
    {
        public string StructureName { get; set; }
        public string ShortStructureName { get; set; }
        public string StructureOrientation { get; set; }
        public string StructureArea { get; set; }
        public string  StructureProperty { get; set; }
         
    }


    /// <summary>
    /// Логика взаимодействия для EnclosingStructures.xaml
    /// </summary>
    public partial class EnclosingStructures : Window
    {

        public ObservableCollection<StructureTableView> MyData { get; set; }
        public ObservableCollection<StructurePropertys> StructurePropertyList { get; set; }

        public EnclosingStructures()
        {
            InitializeComponent();

            // for binding
            this.DataContext = this;
            // data for grid
 

            // data for grid

            MyData = new ObservableCollection<StructureTableView>()
               {
                         new StructureTableView() {
                             StructureName="Стена", ShortStructureName="НС1", StructureOrientation="С", StructureArea="100",
                             StructureProperty="1" },
                         new StructureTableView() {
                             StructureName="Окно", ShortStructureName="ОК1", StructureOrientation="С", StructureArea="10",
                         StructureProperty="1"},
                         new StructureTableView() {
                             StructureName="Пол", ShortStructureName="ПЛ1", StructureOrientation="С", StructureArea="100",
                         StructureProperty="1"},
                         new StructureTableView() {
                             StructureName="Кровля", ShortStructureName="КР1", StructureOrientation="С", StructureArea="10",
                             StructureProperty="1"}

               };



        }
        private void ChangeText(object sender, RoutedEventArgs e)
        {
            StructureTableView structure_model = EnclosingStructureForm.SelectedItem as StructureTableView;
            if (structure_model != null)
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
