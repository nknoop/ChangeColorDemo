using ColorChangeDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ColorChangeDemo.ViewModels
{
    public class DeselectViewModel: BaseViewModel
    {
        private ObservableCollection<SelectableItemGroup> _selectableItemGroups;
        public ObservableCollection<SelectableItemGroup> SelectableItemGroups
        {
            get => _selectableItemGroups;
            set => SetProperty(ref _selectableItemGroups, value);
        }

        public ICommand ItemTappedCommand { get; }


        public DeselectViewModel()
        {
            Title = "Deselect";

            SelectableItem previous = null;

            ItemTappedCommand = new Command<SelectableItem>((item) =>
            {
                if (previous != null)
                    previous.Selected = false;
                previous = item;
                item.Selected = true;
            });

            SelectableItemGroups = new ObservableCollection<SelectableItemGroup>
            {
                new SelectableItemGroup("First")
                {
                    new SelectableItem
                    {
                        Id = "1"
                    },
                    new SelectableItem
                    {
                        Id = "2"
                    },
                    new SelectableItem
                    {
                        Id = "3"
                    }
                },
                new SelectableItemGroup("Second")
                {
                    new SelectableItem
                    {
                        Id = "4"
                    },
                    new SelectableItem
                    {
                        Id = "5"
                    }
                }
            };
        }
    }
}
