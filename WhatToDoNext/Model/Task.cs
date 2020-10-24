using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WhatToDoNext
{
    class Task : CheckBox
    {
        public String Name { get; set; }

        public static int Id { get; set; }

        public Task()
        {
            Id++;
        }
    }
}
