using System;
using System.Collections.Generic;
using System.Text;

namespace ColorChangeDemo.Models
{
    public class SelectableItemGroup: List<SelectableItem>
    {
        public string Key { get; set; }

        public SelectableItemGroup(string key)
        {
            Key = key;
        }
    }
}
