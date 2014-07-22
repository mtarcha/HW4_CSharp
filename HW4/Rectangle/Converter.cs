using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Converter
    {
        private double _usd;
        private double _eur;
        private double _rub;

        public double Usd
        {
            get
            {
                return _usd;
            }
            set
            {
                _usd = value;
            }
        }

        public double Eur
        {
            get
            {
                return _eur;
            }
            set
            {
                _eur = value;
            }
        }

        public double Rub
        {
            get
            {
                return _rub;
            }
            set
            {
                _rub = value;
            }
        }

        public Converter(double _USD, double _EUR, double _RUB)
        {
            _usd = _USD;
            _eur = _EUR;
            _rub = _RUB;
        }

        public double Hrn_Usd()
        {
            return 1 / _usd;
        }
        public double Hrn_Eur()
        {
            return 1 / _eur;
        }
        public double Hrn_Rub()
        {
            return 1 / _rub;
        }
        public double Usd_Hrn()
        {
            return _usd;
        }
        public double Eur_Hrn()
        {
            return _eur;
        }
        public double Rub_Hrn()
        {
            return _rub;
        }
    }
}
