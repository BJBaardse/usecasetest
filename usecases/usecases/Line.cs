using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace usecases
{
    class Line
    {
        public Point beginpunt;
        public Point eindpunt;
        public Line(Point a, Point b)
        {
            beginpunt = a;
            eindpunt = b;
        }
    }
}
