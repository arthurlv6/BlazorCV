using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCV.Components
{
    public class Item
    {
        public string Name { get; set; }
        public string Type { get; set; } = "text";
        public bool Show { get; set; } = false;
    }
    public class DetailBase: ComponentBase
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public string Height { get; set; }
        public int Id { get; set; }
        public bool ShowDialog { get; set; }
        public void Show(string name)
        {
            Items.RemoveAll(d=>true);
            Items.Add(new Item { Name = "certificates", Type = "notText" });
            Items.Add(new Item { Name = "2018" });
            Items.Add(new Item { Name = "2016" });
            Items.Add(new Item { Name = "2014.2" });
            Items.Add(new Item { Name = "2014.1" });
            Items.Add(new Item { Name = "2013"  });
            Items.Add(new Item { Name = "2012"  });

            Items.Add(new Item { Name = "stock",Type="notText" });
            var temp = Items;
            var item = Items.Find(d => d.Name == name);

            item.Show = true;
            Height = item.Type == "notText" ? "800px" : "400px";
            ShowDialog = true;
            StateHasChanged();
        }
        public void Close()
        {
            ShowDialog = false;
        }
    }
}
