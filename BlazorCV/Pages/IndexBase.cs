using BlazorCV.Components;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCV.Pages
{
    public class IndexBase:ComponentBase
    {
        public Detail Detail { get; set; }
        public void ModalShow(string name)
        {
            Detail.Show(name);
        }
        
    }
}
