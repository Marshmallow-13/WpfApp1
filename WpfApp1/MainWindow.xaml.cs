using System;
using Lib1;
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

namespace WpfApp1
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
        private void Button_Click_Сгенерировать(object sender, RoutedEventArgs e)
        {
            // Переменная разности сгенерированных чисел
            int raz = 0;
            // счётчик количества сгенерированных чисел
            int kol = 0;
            //  сумма сгенерированных чисел
            int sum = 0;
            // вынимаем значение из поля ввода
            bool f1 = int.TryParse(TextBox_K.Text, out int K);
             // проверка является ли значение числом
            if (f1 == true)
            {
                // подходит ли число узловию задачи
                if (K < 0) 
                {
                    while (raz > K)
                    {
                        Lib1.Class1.GetRaz(K, ref sum, ref kol, out int value, ref raz); // Призыв метода
                         // Заполняем поле сгенерированных чисел
                        Числа.Text = Числа.Text + " " + Convert.ToString(value);
                        // заполняем поле суммы чисел
                        Сумма.Text = sum.ToString(); 
                        // заполняем поле количества чисел
                        Количество.Text = kol.ToString(); 
                    }
                }
                else
                    MessageBox.Show("Введите число меньшее чем 0");
            }
            else
                MessageBox.Show("Введите число");
        }

        private void B_Очистить(object sender, RoutedEventArgs e) 
        {
            Количество.Clear();
            Сумма.Clear();
            Числа.Clear();
        }

        private void MenuItem_Click_О_программе(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_Выход(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    
}
