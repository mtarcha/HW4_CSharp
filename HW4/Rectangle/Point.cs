using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Point
    {
        private int _x;
        private int _y;
        private string _name;

        public int X
        {
            get
            {
                return _x;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public Point(int _X, int _Y, string _NAME)
        {
            _x = _X;
            _y = _Y;
            _name = _NAME;
        }
    }
}
