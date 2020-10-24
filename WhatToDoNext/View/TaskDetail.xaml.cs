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
using System.Windows.Shapes;

namespace WhatToDoNext.View
{
    /// <summary>
    /// Interaction logic for TaskDetail.xaml
    /// </summary>
    public partial class TaskDetail : Window
    {
        private Task task;

        public TaskDetail(object sender)
        {
            InitializeComponent();
            task = sender as Task;
            loadData();
        }

        private void loadData()
        {
            toDoDetailTextBox.Text = task.Name;
        }

        public void saveButton_Click(object sender, RoutedEventArgs e)
        {
            // nothing yet
        }
    }
}
