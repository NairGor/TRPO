﻿using System;
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

namespace DragAndDrop
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
        private void lblSource_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // sender – объект, на котором произошло данное событие.
            Label lbl = sender as Label;
            // Создаем источник.
            // Копируем содержимое метки Drop.
            // 1 параметр: Элемент управления, который будет источником.
            // 2 параметр: Данные, которые будут перемещаться.
            // 3 параметр: Эффект при переносе.
            DragDrop.DoDragDrop(lbl, lbl.Content, DragDropEffects.Copy);
        }
        private void lblTarget_Drop(object sender, DragEventArgs e)
        {
             ((Label)sender).Content = e.Data.GetData(DataFormats.Text);
        }
    }
}