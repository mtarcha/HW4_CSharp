using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Plane : Vehicle
    {
        private double _hight; 
        private int _quality;

        public double Hight
        {
            get
            {
                return _hight;
            }
            set
            {
                _hight = value;
            }
        }
        public int Quality
        {
            get
            {
                return _quality;
            }
            set
            {
                _quality = value;
            }
        }
        public override string ToString()
        {
            string h = _hight.ToString();
            string q = _quality.ToString();
            string p = _price.ToString();
            string s = _speed.ToString();
            string y = _year.ToString();
            return "Plane: \nhight=" + h + "\nquality=" + q + "\nprice=" + p + "\nspeed=" + s + "\nyear=" + _year;
        }
    }
}
