using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics {
    class Program {
        static void Main(string[] args) {


            int integer = 10;

            double doublevar;
            decimal decvar;
            float floatvar;

            char c = 'a';
            string str = "slkdjflasjdf";

            bool boolean = true;

            object obj = "";
            var something = "";


            //dynamic jg = Convert.ToInt32(str); // error will oc


            Method1(1.45); // expects an int

            Teacher t = new Teacher() {
                Name = "MR.Teacher",
                Salary = 20000
            };

            Student s = new Student() {
                Name = "Ijaz",
                Fee = 30000
            };

        }

        public static void Method1(dynamic a) {
            Console.WriteLine($"you entered {a}");
        }
    }
}