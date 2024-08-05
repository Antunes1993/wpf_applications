using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using Microsoft.Win32;

namespace app_01
{
    public partial class MainWindow : Window
    {
        bool running = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Source Fles | *.pdf";
            ofd.InitialDirectory = "C:\\temp";
            ofd.Title = "Please select PDF file(s).";
            ofd.Multiselect = true;


            bool? success = ofd.ShowDialog();
            if (success == true)
            {
                string path = ofd.FileName;
                string filename = ofd.SafeFileName;
                tbResult.Text = filename + "  --  " + path;
            }
            else
            {
                //pass
            }
        }
    }
}