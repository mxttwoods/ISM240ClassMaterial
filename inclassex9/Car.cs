using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclassex9
{
    class Car : Automobile

    {

        private int _doors;
        // Constructor
        public Car()

        {
            _doors = 0;

        }
        // Doors property
        public int Doors

        {
            get { return _doors; }
            set { _doors = value; }

        }
    }
}