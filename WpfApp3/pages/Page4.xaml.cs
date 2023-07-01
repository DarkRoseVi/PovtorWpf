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

namespace WpfApp3.pages
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void ResultBtn_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(aTb.Text.Trim());
            int b = int.Parse(bTb.Text.Trim());
            int c = int.Parse(cTb.Text.Trim());
            double d = (Math.Pow(b, 2)) - (4 * a * b);
            double d2 = Math.Pow(d, 1 / 2);
            if (d2 == 0.0)
            {
                double result = (-b) / (2 * a);
                ResultSt.Visibility = Visibility;
                ResultTb.Text = result.ToString() + " ";
            }
            else if (d2 > 0.0)
            {
                double result1 = Math.Round( ((-b + d2) / (2 * a)),3);
                double result2 =Math.Round(( (-b - d2) / (2 * a)),3);
                ResultSt.Visibility = Visibility;
                ResultTb.Text = result1.ToString() + " ";
                Resul2tSt.Visibility = Visibility;
                Result2Tb.Text = result2.ToString() + " ";

            }
            else if (d2 < 0.0)
            {
                MessageBox.Show("Дискриминант меньше 0");
            }
        }

        private void aTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            string number = aTb.Text.Trim();
            double num;
            var res = double.TryParse(number,out num);
            if (res)
            {
                MessageBox.Show("yes");
            }
            else MessageBox.Show("no");

        }

        private void bTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            string contextnumber = bTb.Text.Trim();
            double number;
            var res = double.TryParse(contextnumber, out number);
            if (res)
            {
                MessageBox.Show("yes");
            }
            else MessageBox.Show("no");
        }

        //private void aTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        //{
        //    //if(!Char.IsDigit(e.Text,0) ) 
        //    //{
        //    //    e.Handled = true;
        //    //}
        //}
    }
}
