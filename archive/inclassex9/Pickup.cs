using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclassex9
{
    class Pickup : Automobile
    
    { 
 private string _drive;
        // Constructor
        public Pickup()

        {
            _drive = ""
           ;

        }
        // Drive property
        public string Drive

        {
            get { return _drive; }
            set { _drive = value; }
        }
    }
}
