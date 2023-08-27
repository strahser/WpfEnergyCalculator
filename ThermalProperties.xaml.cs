using System;
using System.Collections.Generic;
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
    public partial class ThermalProperties : Window
    {
        public string Data { get; set; }
        public ThermalProperties(string data)
        {
            Data = data;
            InitializeComponent();
            DataContext = this;
        }
    }
}
