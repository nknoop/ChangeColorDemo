using ColorChangeDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ColorChangeDemo.ViewModels
{
    public class SelectedItemViewModel: BaseViewModel
    {
        private ObservableCollection<ItemGroup> _itemGroups;
        public ObservableCollection<ItemGroup> ItemGroups
        {
            get => _itemGroups;
            set => SetProperty(ref _itemGroups, value);
        }

        private Item _selectedItem;
        public Item SelectedItem
        {
            get => _selectedItem;
            set => SetProperty(ref _selectedItem, value);
        }

        private ICommand _itemTappedCommand;
        public ICommand ItemTappedCommand => _itemTappedCommand ?? (_itemTappedCommand = new Command<Item>((item) =>
        {
            SelectedItem = item;
        }));

        public SelectedItemViewModel()
        {
            Title = " Selected Item";

            ItemGroups = new ObservableCollection<ItemGroup>()
            {
                new ItemGroup("First")
                {
                    new Item()
                    {
                        Id = "1"
                    },
                    new Item()
                    {
                        Id = "2"
                    },
                    new Item()
                    {
                        Id = "3"
                    }
                },
                new ItemGroup("Second")
                {
                    new Item()
                    {
                        Id = "4"
                    },
                    new Item()
                    {
                        Id = "5"
                    }
                }
            };
        }
    }
}
