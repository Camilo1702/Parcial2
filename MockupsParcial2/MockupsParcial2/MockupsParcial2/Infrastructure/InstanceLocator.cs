using System;
using System.Collections.Generic;
using System.Text;

namespace MockupsParcial2.Infrastructure
{
    using MockupsParcial2.ViewModels;
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
