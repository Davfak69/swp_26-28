using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Vorbereitung
{
  public class Auto
    {
        string _colour;
        string _brand;
        int _year;
        public string colour
        {
            get { return _colour; }
            set { _colour = value; }
        }
        public string brand
{
            get { return _brand; }
            set { _brand = value; }
        }

        public int year
        {
            get { return _year; }
            set { _year = value; }
        }
        public Auto(string colour, string brand, int year)
        {
            _colour = colour;
            _brand = brand;
            _year = year;
        }

    }
}
