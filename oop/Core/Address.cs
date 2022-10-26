using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Core
{
    public class Address
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _house;
        private int _apartament;

        public int Index
        {
            get => _index;
            set => _index = value;
        }

        public string Country
        {
            get => _country;
            set => _country = value;
        }

        public string City
        {
            get => _city;
            set => _city = value;
        }

        public string Street
        {
            get => _street;
            set => _street = value;
        }

        public string House
        {
            get => _house;
            set => _house = value;
        }

        public int Apartament
        {
            get => _apartament;
            set => _apartament = value;
        }

        public string getFulllAddress()
        {
            return _index + ", " + _country + ", г. " + _city + ", ул." + _street + ", д." + _house + ", кв." + _apartament;
        }
    }
}
