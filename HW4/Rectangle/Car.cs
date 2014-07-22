using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Car : Vehicle
    {

        public override string ToString()
        {
            string p = _price.ToString();
            string s = _speed.ToString();
            string y = _year.ToString();
            return "Car: price=" + p + "speed=" + s + "year=" + _year;
        }
    }
}
