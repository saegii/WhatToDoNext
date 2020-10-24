using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatToDoNext
{
    class ToDo
    {
        private String name;

        public ToDo(String name)
        {
            this.name = name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }
    }
}
