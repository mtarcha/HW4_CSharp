using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Ship : Vehicle
    {
        private string _port;
        private int _quality;

        public override string ToString()
        {
            string q = _quality.ToString();
            string p = _price.ToString();
            string s = _speed.ToString();
            string y = _year.ToString();
            return "Ship: port=" + _port + q + "price=" + p + "speed=" + s + "year=" + _year;
        }
    }
}
