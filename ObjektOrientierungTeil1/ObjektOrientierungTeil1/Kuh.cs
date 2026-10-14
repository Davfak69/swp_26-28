using System;
using System.Collections.Generic;
using System.Text;

namespace ObjektOrientierungTeil1
{
    public class Kuh
    {
        string _name; // private field for the name of the Kuh

        string _colour; // private field for the colour of the Kuh

        public string name // public property for the name of the Kuh
        {
            get { return _name; }
            set { _name = value; }

        }
        public string Colour // public property for the colour of the Kuh
        {
            get { return _colour; }
            set { _colour = value; }
        }
        public Kuh(string name, string colour) // Impliezierter Rückgabewert ist ein Objekt der Klasse Kuh
        {
            _name = name;
            _colour = colour;
        }
       

    }
}
