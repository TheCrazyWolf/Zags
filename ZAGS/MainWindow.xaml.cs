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

namespace ZAGS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (Model.ApplicationContext ef = new Model.ApplicationContext())
            {
                grid.ItemsSource = ef.Marriage.ToList();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Model.Marriage marriage = new Model.Marriage();
            marriage.Fio1 = "Фамилия имя отчество";
            marriage.Fio2 = "Фамилия имя отчество";
            marriage.Registration = DateTime.Now;

            using (Model.ApplicationContext ef = new Model.ApplicationContext())
            {
                ef.Add(marriage);
                ef.SaveChanges();
            }

            Button_Click(sender, e);
        }
    }
}
