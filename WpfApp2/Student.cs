using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Student
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string ? Address { get; set; }

        public Student(string _fname, string _lname)
        {
            Fname = _fname;
            Lname = _lname;
        }
        public Student() { }
    }
}
