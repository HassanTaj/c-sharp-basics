using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics {
    class Student : Person {

        private double _fee;

        public double Fee {
            get { return _fee; }
            set { _fee = value; }
        }


    }
}