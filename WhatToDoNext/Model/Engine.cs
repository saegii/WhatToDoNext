using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WhatToDoNext
{
    class Engine
    {
        private List<CheckBox> checkBoxes;
        private ListBox toDoListBox;
        
        public Engine(ListBox toDoListBox)
        {
            this.toDoListBox = toDoListBox;
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
