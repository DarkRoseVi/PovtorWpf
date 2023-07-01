using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp3.pages
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        DataTable table = new DataTable("tabels");

        public Page3()
        {
            InitializeComponent();
        }

        private void Datagrid_Loaded(object sender, RoutedEventArgs e)
        {
            table.Columns.Add("Name", Type.GetType("System.String"));
            table.Columns.Add("SurName", Type.GetType("System.String"));
            table.Columns.Add("lastNams", Type.GetType("System.String"));
      
        }
    }
}
