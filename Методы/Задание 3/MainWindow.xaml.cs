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

namespace Задание_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public double Calculation(double chislo1, double chislo2, int operation)
        {
            switch (operation)
            {
                case 1:
                    return chislo1 % chislo2;
                case 2:
                    return Math.Pow(chislo1, chislo2);
                case 3:
                    return Convert.ToDouble(Convert.ToString(chislo1) + Convert.ToString(chislo2));
                case 4:
                    return chislo1 / chislo2;
                default:
                    return 0;
            }
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            int operation;
            if (Radio1.IsChecked == true)
                operation = 1;
            else if (Radio2.IsChecked == true)
                operation = 2;
            else if (Radio3.IsChecked == true)
                operation = 3;
            else if (Radio4.IsChecked == true)
                operation = 4;
            else
                operation = 0;


            ResultTB.Text = "Результат: " + Calculation(Convert.ToDouble(Chislo1.Text), Convert.ToDouble(Chislo2.Text), operation);
        }
    }
}
