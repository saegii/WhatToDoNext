using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Drawing;
using System.Windows.Input;

namespace WhatToDoNext
{
    
    public partial class MainWindow : Window
    {
        private List<CheckBox> checkBoxes = new List<CheckBox>();
        private Engine engine;

        public MainWindow()
        {
            InitializeComponent();
            engine = new Engine(toDoListBox);
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
            // checkBox.Click += new RoutedEventHandler(checkBox_Changed);
            checkBox.MouseDoubleClick += new MouseButtonEventHandler(openTask);
            checkBoxes.Add(checkBox);
            refreshToDoListBox();
        }

        private void openTask(object sender, MouseButtonEventArgs e)
        {
            TaskDetail taskDetail = new TaskDetail();
            taskDetail.Show();
        }

        private void checkBox_Changed(object sender, RoutedEventArgs e)
        {
            // strikethroug or colorchange comes here!
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

        public void refreshToDoListBox()
        {
            toDoListBox.Items.Clear();
            foreach (CheckBox checkBox in checkBoxes)
            {
                toDoListBox.Items.Add(checkBox);
            }
        }
    }
}
