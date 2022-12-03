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
using System.Threading;

namespace _8Ball
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

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            // Ставим курсор ожидания.
            this.Cursor = Cursors.Wait;
            // Делаем задержку, для создания эффекта того, что программа задумалась.
            Thread.Sleep(TimeSpan.FromSeconds(1));
            // Берем случайный ответ.
            Random rnd = new Random();
            int num = rnd.Next(0, 4);
            string[] answers = { "Да", "Нет", "Очень сомнительно", "Вероятно да", "Звёзды говорят нет", "Вероятно нет", 
                "Скорее нет, чем да", "Скорее да, чем нет", "Затрудняюсь ответить" };
            txtAnswer.Text = answers[num];
            // Восстанавливаем прежнее состояние курсора.
            this.Cursor = null;
        }

        private void txtAnswer_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtQuestion_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
