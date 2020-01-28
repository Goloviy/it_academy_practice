using System;
using System.Collections.Generic;
using System.Text;

namespace Project_14._3
{
    class Neighbor
    {
        private string _fullName;
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                _fullName = value;
            }
        }

        private int _flatNumber;
        public int FlatNumber
        {
            get
            {
                return _flatNumber;
            }
            set
            {
                _flatNumber = value;
            }
        }

        private int _phoneNumber;
        public int PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }
    }
}
