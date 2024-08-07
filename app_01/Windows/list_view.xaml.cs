using System;
using System.Collections;
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
    /// Interaction logic for list_view.xaml
    /// </summary>
    public partial class list_view : Window
    {
        public list_view()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(tbEntry.Text);
            tbEntry.Clear();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var items = lvEntries.SelectedItems;
            var result = MessageBox.Show($"Are u shure you want to delete {items.Count} items?", "Sure", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                var itemsList = new ArrayList(items);

                foreach (var item in itemsList)
                {
                    lvEntries.Items.Remove(item);
                }

            }
        }

        private void btnClr_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }
    }
}
