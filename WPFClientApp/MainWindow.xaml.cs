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
using DataModel;

namespace WPFClientApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person person;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            person = new Person("Alex");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = person.Name;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = person.ToJson().ToString();
        }
    }
}