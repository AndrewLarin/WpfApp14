using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Видеокарты",
                ProdPrice = 2350,
                ProdImage = "Data/gpu.jpg",
                ProductCategory = ProductCategories.gpu
            });
            products.Add(new Product()
            {
                ProdName = "Процессоры",
                ProdPrice = 759,
                ProdImage = "Data/cpu.jpg",
                ProductCategory = ProductCategories.cpu
            });
            products.Add(new Product()
            {
                ProdName = "Оперативная память",
                ProdPrice = 456,
                ProdImage = "Data/ram.jpg",
                ProductCategory = ProductCategories.ram
            });
            products.Add(new Product()
            {
                ProdName = "Жесткие диски",
                ProdPrice = 299,
                ProdImage = "Data/hd.jpg",
                ProductCategory = ProductCategories.hd
            });
            listBox.ItemsSource = products;
        }
    }
}
