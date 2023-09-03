using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfEnergyCalculator.ViewModel;
using WpfEnergyCalculator.ViewModels;

namespace WpfEnergyCalculator
{
    /// <summary>
    /// Логика взаимодействия для AreaCalculatorView.xaml
    /// </summary>
    public partial class AreaCalculatorView : UserControl
    {
 

        public AreaCalculatorView()
        {
            CalculateAreaViewModel calculateAreaViewModel = new CalculateAreaViewModel();
            InitializeComponent();
            DataContext = calculateAreaViewModel;


        }
    }
}
