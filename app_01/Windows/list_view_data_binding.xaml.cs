using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for list_view_data_binding.xaml
    /// </summary>
    public partial class list_view_data_binding : Window
    {
        public list_view_data_binding()
        {
            DataContext = this;
            entries = new ObservableCollection<string>(); //Its necessary create that before Initialize Component
            InitializeComponent();
        }
        /// <summary>
        /// Dynamic data collection that provides notifications when items are added or removed. 
        /// In the first databinding class we implemented the interface INotifyPropertyChanged 
        /// and every time a property changed we had to implement the method onPropertyChanged. 
        /// 
        /// The ObservableCollection does that for us and do that in inListOperation. 
        /// All those things are builtin the observable colletion.
        /// We donot have to see if this operations (add, delete, refresh) are happening with 
        /// the elements of the list. The observable collection will do thad automatically and 
        /// communicate with the ui. 
        /// </summary>
        private ObservableCollection<string> entries;

        public ObservableCollection<string> Entries
        {
            get { return entries; }
            set { entries = value; }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Entries.Add(tbEntry.Text);
            tbEntry.Clear();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            string selectedItem = (string)lvEntries.SelectedItem; //Here we are not using binding. 
            Entries.Remove(selectedItem);
        }
        
        private void btnClr_Click(object sender, RoutedEventArgs e)
        {
            entries.Clear();
        }
    }
}
