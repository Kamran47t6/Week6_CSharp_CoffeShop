using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_task
{
    class MenuItem
    {
        public string Name;
        public string Type;
        public float Price;
        public MenuItem(string name,string type,float price)
        {
            Name = name;
            Type = type;
            Price = price;
        }

    }
}
