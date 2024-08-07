using app_01.Model;
using app_01.MVVM;
using System;
using System.Collections.ObjectModel;
using System.Windows.Controls.Primitives;

namespace app_01.ViewModel
{
    internal class mvvm_example_view_model : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        public RelayCommand AddCommand => new RelayCommand(execute => AddItem());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem());
        public mvvm_example_view_model() 
        {
            Items=new ObservableCollection<Item>();
            //Items.Add(new Item
            //{
            //    Name="Product1",
            //    SerialNumber="0001",
            //    Quantity=1,
            //});
            //Items.Add(new Item
            //{
            //    Name = "Product2",
            //    SerialNumber = "0002",
            //    Quantity = 5,
            //});
            //Items.Add(new Item
            //{
            //    Name = "Product3",
            //    SerialNumber = "0003",
            //    Quantity = 15,
            //});
        }
        private Item selectedItem;

        public Item SelectedItem
        {
            get { return selectedItem; }
            set 
            { 
                selectedItem = value;
                OnPropertyChanged();
            }
        }

        public void AddItem()
        {
            Items.Add(new Item
            {
                Name="New item",
                SerialNumber = "XXXX",
                Quantity = 0,
            });
        }

        public void DeleteItem()
        {
            Items.Remove(SelectedItem);
        }
    }
}
