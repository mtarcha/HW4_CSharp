using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Figure
    {
        private Point _A;
        private Point _B;
        private Point _C;
        private Point _D;
        private Point _E;
        private double _perimeter;

        public double Perimeter
        {
            get
            {
                return _perimeter;
            }
        }

        // var показує нам скільки сторін у фігури
        int _var;

        public Figure(Point _a, Point _b, Point _c)
        {
            _A = _a;
            _B = _b;
            _C = _c;
            _var = 3;
        }
        public Figure(Point _a, Point _b, Point _c, Point _d)
            : this(_a, _b, _c)
        {
            _D = _d;
            _var = 4;
        }
        public Figure(Point _a, Point _b, Point _c, Point _d, Point _e)
            : this(_a, _b, _c, _d)
        {
            _E = _e;
            _var = 5;
        }
        public string Name_of_Figure
        {
            get
            {
                switch (_var)
                {
                    case 3: return "Triangle";
                    case 4: return "Rectangle";
                    default: return "Pentagon";
                }
            }
        }
        public double LengthSide(Point _A, Point _B)
        {
            return Math.Sqrt((_A.X - _B.X) * (_A.X - _B.X) + (_A.Y - _B.Y) * (_A.Y - _B.Y));
        }
        public void PerimeterCalculator()
        {
            switch (_var)
            {
                case 3: _perimeter = (LengthSide(_A, _B) + LengthSide(_B, _C) + LengthSide(_C, _A)); break;
                case 4: _perimeter = (LengthSide(_A, _B) + LengthSide(_B, _C) + LengthSide(_C, _D) + LengthSide(_D, _A)); break;
                case 5: _perimeter = (LengthSide(_A, _B) + LengthSide(_B, _C) + LengthSide(_C, _D) + LengthSide(_D, _E) + LengthSide(_E, _A)); break;
            }
        }
    }
}
