using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class User
    {
        private string _login;
        private string _firstName;
        private string _lastName;
        private int _age;
        private readonly DateTime _date;

        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }            
        }

        public User(string _LOGIN, string _FIRSTNAME, string _LASTNAME, int _AGE, DateTime _DATE)
        {
            _login = _LOGIN;
            _firstName = _FIRSTNAME;
            _lastName = _LASTNAME;
            _age = _AGE;
            _date = _DATE;
        }

    }
}
