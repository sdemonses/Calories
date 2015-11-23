using System;
using System.Collections.Generic;
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
using Callories.Сlass;

namespace Callories
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (UserContext db = new UserContext())
            {
                Product prod = new Product() { Name = "Гречневая каша", Calories = 132, Carbohydrate = 25.0, Fat = 2.3, Protein = 4.5 };
                db.Products.Add(prod);
                db.SaveChanges();
            }
        }
    }
}
