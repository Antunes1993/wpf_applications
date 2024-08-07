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
    /// Interaction logic for return_info_main.xaml
    /// </summary>
    public partial class return_info_main : Window
    {
        public return_info_main()
        {
            InitializeComponent();
        }

        private void btngetResult_Click(object sender, RoutedEventArgs e)
        {
            return_info_window_sub window = new return_info_window_sub(this); //send this window as a parent parameter
            Opacity = 0.4;
            window.ShowDialog();
            Opacity = 1;
            if (window.Success)
            {
                tbResult.Text = window.Input.ToString();
            }
        }
    }
}
