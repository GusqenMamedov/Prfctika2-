using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApp2
{
    public partial class CpiskiWindow1 : Window
    {
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<User> Users { get; set; }

        public CpiskiWindow1()
        {
            InitializeComponent();

            Products = new ObservableCollection<Product>
            {
                new Product { Name = "Товар 1", Price = 100 },
                new Product { Name = "Товар 2", Price = 200 }
            };

            Users = new ObservableCollection<User>
            {
                new User { Name = "Пользователь 1", Age = 25 },
                new User { Name = "Пользователь 2", Age = 30 }
            };

            DataContext = this;
        }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
}
