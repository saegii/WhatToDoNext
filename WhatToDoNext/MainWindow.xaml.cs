using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Drawing;

namespace WhatToDoNext
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<CheckBox> checkBoxes = new List<CheckBox>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void addToDoButton_Click(object sender, RoutedEventArgs e)
        {
            String task = addToDoTextBox.Text;
            if (!task.Equals(""))
            {
                ToDo toDo = new ToDo();
                toDo.Name = task;
                addToCheckBox(toDo);
                addToDoTextBox.Text = "";
            }
        }

        private void addToCheckBox(ToDo toDo)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Content = toDo.Name;
            checkBox.Click += new RoutedEventHandler(checkBox_Changed);
            checkBoxes.Add(checkBox);
            refreshToDoListBox();
        }

        private void checkBox_Changed(object sender, RoutedEventArgs e)
        {
            // strikethroug or colorchange comes here!
        }

        private void refreshToDoListBox()
        {
            toDoListBox.Items.Clear();
            foreach(CheckBox checkBox in checkBoxes)
            {
                toDoListBox.Items.Add(checkBox);
            }
        }

        private void deleteItemButton_Click(object sender, RoutedEventArgs e)
        {
            List<CheckBox> checkBoxesToDelete = new List<CheckBox>();
            foreach(CheckBox checkBox in checkBoxes)
            {
                if(checkBox.IsChecked == true)
                {
                    checkBoxesToDelete.Add(checkBox);
                }
            }
            foreach(CheckBox checkBox in checkBoxesToDelete)
            {
                checkBoxes.Remove(checkBox);
            }
            refreshToDoListBox();
        }
    }
}
