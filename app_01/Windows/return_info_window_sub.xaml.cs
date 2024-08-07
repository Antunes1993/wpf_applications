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
    /// Interaction logic for return_info_window_sub.xaml
    /// </summary>
    public partial class return_info_window_sub : Window
    {
        public bool Success { get; set; }
        public string Input { get; set; }

        public return_info_window_sub(Window parentWindow)
        {
            Owner = parentWindow; //receives a parent window as owner parameter
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            Success = true;
            Input = tb_userinput.Text;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void tb_userinput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(!string.IsNullOrEmpty(tb_userinput.Text))
                btnOK.IsEnabled = true;
            else btnOK.IsEnabled = false;
        }
    }
}
