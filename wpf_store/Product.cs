using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace wpf_store
{
    public class Product : INotifyPropertyChanged
    {
        private int count;
        private string? name;
        private double? price;

        public int Count { get => count; set { count = value; OnPropertyChanged(); } }
        public string? Name { get => name; set { name = value; OnPropertyChanged(); } }
        public Double? Price { get => price; set { price = value; OnPropertyChanged(); } }

        public SolidColorBrush? Color { get; set; }

        public string? Image { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
