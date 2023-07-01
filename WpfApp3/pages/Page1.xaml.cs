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
using WpfApp3.pages;

namespace WpfApp3.pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public List<Class1> persons { get; set; } = new List<Class1>();
        public Page1()
        {
            InitializeComponent();

            DatagritInfo.ItemsSource = persons.ToList();
        }


        private void DatagritInfo_Loaded(object sender, RoutedEventArgs e)
        {
         

        
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            persons.Add(new Class1()
            {
                Adress = AdressTb.Text.Trim(),
                Email = EmaulTb.Text.Trim(),
                Name = NameTb.Text.Trim(),
                Age =AgeTb.Text.Trim()
            }) ;
            
            DatagritInfo.ItemsSource = persons.ToList();
        }
    }
}
