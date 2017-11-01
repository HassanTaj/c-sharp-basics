using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics {
    class Teacher :Person {

        private int _experience;

        public int Experience {
            get { return _experience; }
            set { _experience = value; }
        }

        private string _qualification;

        public string Qualification {
            get { return _qualification; }
            set { _qualification = value; }
        }


        private string _specialization;

        public string Specialization {
            get { return _specialization; }
            set { _specialization = value; }
        }

        private double _salary;

        public double Salary {
            get { return _salary; }
            set { _salary = value; }
        }


    }
}
