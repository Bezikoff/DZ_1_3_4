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

namespace DZ_1_3_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RB1.IsChecked = true; RB2.IsChecked = false; RB3.IsChecked = false;
        }
        private void RB1_MouseEnter(object sender, MouseEventArgs e)
        {
            RB1.IsChecked = true;
            RB2.IsChecked = false; RB3.IsChecked = false;
        }

        private void RB2_MouseEnter(object sender, MouseEventArgs e)
        {
            RB2.IsChecked = true;
            RB1.IsChecked = false; RB3.IsChecked = false;
        }

        private void RB3_MouseEnter(object sender, MouseEventArgs e)
        {
            RB3.IsChecked = true;
            RB2.IsChecked = false; RB1.IsChecked = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x = 0;
            if ((bool)RB1.IsChecked) { x = Math.Sin(Convert.ToDouble(TB1.Text)); }
            else if ((bool)RB2.IsChecked) { x = Math.Cos(Convert.ToDouble(TB1.Text)); }
            else if ((bool)RB3.IsChecked) { x = Math.Exp(Convert.ToDouble(TB1.Text)); }
            else { x = Convert.ToDouble(TB1.Text); }
            double y = Convert.ToDouble(TB2.Text);
            double z = Convert.ToDouble(TB3.Text);
            double d = 0;
            if (Convert.ToDouble(TB1.Text) > y)
            {
                d = Math.Pow(x - y, 3) + Math.Atan(x);
            }
            else if (Convert.ToDouble(TB1.Text) < y)
            {
                d = Math.Pow(y - x, 3) + Math.Atan(x);
            }
            else
            {
                d = Math.Pow(x + y, 3) + 0.5;
            }
            LB1.Items.Clear();
            LB1.Items.Add("Лабораторная Безикова");
            LB1.Items.Add($"X = {Convert.ToDouble(TB1.Text)}");
            LB1.Items.Add($"Y = {y}");
            LB1.Items.Add($"Z = {z} (не учитывается)");
            LB1.Items.Add($"Результат = {d}");
        }
    }
}
