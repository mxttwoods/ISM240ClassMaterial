using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_class_excersize
{
    class Student
    {
        //fields
        private string _lastName;
        private string _firstName;
        private string _stdId;

        // constructer 
        public Student()
        {
            _lastName = "";
            _firstName = "";
            _stdId = "";
        }

        //parameterized constructor
        public Student(string StdId)
        {
            _lastName = "";
            _firstName = "";
            _stdId = "";
        }

        // LastName property
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
        // FirstName property
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
        // StdId property
        public string StdId
        {
            get
            {
                return _stdId;
            }
            set
            {
                _stdId = value;
            }
        }

    }
}
