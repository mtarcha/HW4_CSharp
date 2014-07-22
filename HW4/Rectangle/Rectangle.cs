using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        private double _side1;
        private double _side2;

        public Rectangle()
        {
            _side1 = 1;
            _side2 = 1;
        }
        public Rectangle(double _SIDE1, double _SIDE2)
        {
            _side1 = _SIDE1;
            _side2 = _SIDE2;
        }
        private double AreaCalculator()
        {
            double _square = 0;
            _square = _side1 * _side2;
            return _square;
        }
        private double PerimeterCalculator()
        {
            double _area = 0;
            _area = 2 * (_side1 + _side2);
            return _area;
        }
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }

    }
}
