using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace CanExecuteApp
{
    public class Order : ObservableObject
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime RequestedDate { get; set; }
    }
}
