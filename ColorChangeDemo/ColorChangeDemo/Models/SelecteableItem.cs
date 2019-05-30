using System;
using System.Collections.Generic;
using System.Text;

namespace ColorChangeDemo.Models
{
    public class SelectableItem: BindingBase
    {
        private bool _selected = false;
        public bool Selected
        {
            get => _selected;
            set => SetProperty(ref _selected, value);
        }

        public string Id { get; set; }
    }
}
