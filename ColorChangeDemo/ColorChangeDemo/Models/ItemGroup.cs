using System;
using System.Collections.Generic;
using System.Text;

namespace ColorChangeDemo.Models
{
    public class ItemGroup: List<Item>
    {
        public string Key { get; set; }

        public ItemGroup(string key)
        {
            Key = key;
        }
    }
}
