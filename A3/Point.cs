using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
    class Point
    {
        int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int XCoordinate
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int YCoordinate
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }
}
