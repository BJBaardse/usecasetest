using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace usecases
{
    class Actor
    {
        public string name;
        public Point plaats;

        public Actor(string _name, Point _plaats)
        {
            name = _name;
            plaats = _plaats;
        }
    }
}
