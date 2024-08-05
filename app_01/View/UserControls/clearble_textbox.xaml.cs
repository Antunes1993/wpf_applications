using System.Windows;
using System.Windows.Controls;

namespace app_01.View.UserControls
{
    public partial class clearble_textbox : UserControl
    {
        public clearble_textbox()
        {
            InitializeComponent();
        }
        private string placeholder;
        public string Placeholder 
        {   
            get { return placeholder; } 
            set 
            {  
                placeholder = value; 
                tbPlaceHolder.Text = placeholder;
            } 
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();            
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                tbPlaceHolder.Visibility = Visibility.Visible;
            }
            else 
            {
                tbPlaceHolder.Visibility = Visibility.Collapsed;
            }
        }
    }
}
