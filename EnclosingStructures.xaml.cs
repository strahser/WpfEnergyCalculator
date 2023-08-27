using System;
using System.Collections.ObjectModel;
using System.Data;
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
    }


    /// <summary>
    /// Логика взаимодействия для EnclosingStructures.xaml
    /// </summary>
    public partial class EnclosingStructures : Window
    {

        public ObservableCollection<StructureTableView> MyData { get; set; }
        public ICommand ClickMyButton1 { get; set; }

        public EnclosingStructures()
        {
            InitializeComponent();

            // for binding
            this.DataContext = this;

            // data for grid
            MyData = new ObservableCollection<StructureTableView>()
               {
                         new StructureTableView() {StructureName="Стена", ShortStructureName="НС1", StructureOrientation="С", StructureArea="100"},
                         new StructureTableView() {StructureName="Окно", ShortStructureName="ОК1", StructureOrientation="С", StructureArea="10"}

               };

        }
        private void ChangeText(object sender, RoutedEventArgs e)
        {
            StructureTableView item = EnclosingStructureForm.SelectedItem as StructureTableView;
            if (item != null)
            {
                ThermalProperties thermal_property_view = new ThermalProperties(item.ShortStructureName);
                thermal_property_view.Show();
            }
            else
            {
                MessageBox.Show("Не заполнены данные");
            }
        }

    }

}
