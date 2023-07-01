using System;
using System.Collections.Generic;
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
using System.Globalization;


namespace WpfApp3.pages
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }


        private void deneretBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = NamrTb.Text.Trim();
            StringBuilder names = new StringBuilder();
            foreach (var item in name)
            {
                int position = char.ToUpper(item) - 'A' + 1;
                names.Append(position.ToString());
            }
            LoginTb.Text = names.ToString();

            string contextdate = DateTb.Text.Trim();
            DateTime date;
            if(DateTime.TryParseExact(contextdate,"dd.MM.yy",CultureInfo.InvariantCulture, DateTimeStyles.None,out date)) 
            {
                string symbo = "@#!$%*_+=-";
                Random rn = new Random();
                int sums = date.Day + date.Day;
                int imdex = rn.Next(symbo.Length);
                char d = symbo[imdex];
            }
        }



     
    }
    
   
}
