using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Drawing;
using System.Windows.Input;
using WhatToDoNext.View;

namespace WhatToDoNext
{
    
    public partial class MainWindow : Window
    {
        private List<CheckBox> checkBoxes = new List<CheckBox>();
        private List<Task> tasks = new List<Task>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void addToDoButton_Click(object sender, RoutedEventArgs e)
        {
            String text = addToDoTextBox.Text;
            if (!text.Equals(""))
            {
                Task task = new Task();
                task.Name = text;
                addToCheckBox(task);
                addToDoTextBox.Text = "";
            }
        }

        private void addToCheckBox(Task task)
        {
            tasks.Add(task);
            task.MouseDoubleClick += new MouseButtonEventHandler(openTask);
            refreshToDoListBox();
        }

        private void openTask(object sender, MouseButtonEventArgs e)
        {
            TaskDetail taskDetail = new TaskDetail(sender);
            taskDetail.Show();
        }

        private void checkBox_Changed(object sender, RoutedEventArgs e)
        {
            // strikethroug or colorchange comes here!
        }

        private void deleteItemButton_Click(object sender, RoutedEventArgs e)
        {
            List<Task> tasksToDelete = new List<Task>();

            foreach(Task task in tasks)
            {
                if(task.IsChecked == true)
                {
                    tasksToDelete.Add(task);
                }
            }

            foreach(Task task in tasksToDelete)
            {
                tasks.Remove(task);
            }

            refreshToDoListBox();
        }

        public void refreshToDoListBox()
        {
            toDoListBox.Items.Clear();

            foreach (Task task in tasks)
            {
                task.Content = task.Name;
                toDoListBox.Items.Add(task);
            }
        }
    }
}
