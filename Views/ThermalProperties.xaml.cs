
using System.Windows;

using WpfEnergyCalculator.Models;
using WpfEnergyCalculator.ViewModels;

namespace WpfEnergyCalculator
{
    /// <summary>
    /// Логика взаимодействия для ThermalProperties.xaml
    /// </summary>



    public partial class ThermalProperties : Window
    {
        public StructureInstance Data { get; set; }
        public ThermalProperties(StructureInstance structure_model)
        {
            InitializeComponent();
            ConnectionViewModel vm = new ConnectionViewModel(structure_model);
            DataContext = vm;
        }
    }
}
