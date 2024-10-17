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

namespace ПР9
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

        int n = 20;
        int[] a;
        private void Btn_Generate_Massive_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
             a = new int[n];
            for (int i = 0; i < n; i++) 
            {
                a[i] = random.Next(-100, 100);
               
            }
            for (int i = 0; i < n; i++) 
            {
                TextBox_Massiv.Text += a[i].ToString()+ "\r\n"; ;
            }

        }

        private void BtnColculation_Click(object sender, RoutedEventArgs e)
        {
             int[] b = new int[n];
             a.CopyTo( b, 0);
               int min_x = b[0];
             for (int i = 1;i<n;i++)
            {
                if (b[i] < min_x)
                 { min_x = b[i];}
             }
              Minimum_znach_X.Content = min_x;

            int[] c = new int[n];
            a.CopyTo ( c, 0 );
            int max_y = int.MinValue;
            int max_z = int.MinValue;
            foreach (var number in a)
            {
                if (number > max_y)
                {
                    max_z = max_y; // Обновляем второе по величине
                    max_y = number; // Обновляем первое по величине
                }
                else if (number > max_z && number != max_y)
                {
                    max_z = number; // Обновляем второе по величине
                }
            }
            if (max_y == int.MinValue || max_z == int.MinValue)
            {
                Maximum1_znach_Y.Content = "Не удалось найти   наибольшoe значениe.";
                Maximum2_znach_Z.Content = "Не удалось найти   наибольшoe значениe.";
            }
            else
            {
                Maximum1_znach_Y.Content = max_y;
                Maximum2_znach_Z.Content= max_z;
            }
            double f = Math.Sin(min_x) + Math.Cos(max_y) + Math.Tan(max_z);
            Result.Content ="Ответ: " + Math.Round(f,3) ;




        }
    }
}
