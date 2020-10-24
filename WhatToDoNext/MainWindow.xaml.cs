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

namespace WhatToDoNext
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

        private void addToDoButton_Click(object sender, RoutedEventArgs e)
        {
            String text = addToDoTextBox.Text;
            if (!text.Equals(""))
            {
                ToDo toDo = new ToDo(addToDoTextBox.Text);
                addToDoToListBox(toDo);
            }
        }

        private void addToDoToListBox(ToDo toDo)
        {
            toDoListBox.Items.Add(toDo.getName());
        }
    }
}
