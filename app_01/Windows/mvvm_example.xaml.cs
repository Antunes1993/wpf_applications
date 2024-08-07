using app_01.ViewModel;
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

namespace app_01.Windows
{
    /// <summary>
    /// Interaction logic for mvvm_example.xaml
    /// </summary>
    public partial class mvvm_example : Window
    {
        public mvvm_example()
        {
            InitializeComponent();
            mvvm_example_view_model vm = new mvvm_example_view_model();
            DataContext = vm;
        }
    }
}
