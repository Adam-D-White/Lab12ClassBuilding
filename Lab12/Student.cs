using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public string Program
        {
            set { program = value; }
            get { return program; }
        }
        public int Year
        {
            set { year = value; }
            get { return year; }
        }
        public double Fee
        {
            set { fee = value; }
            get { return fee; }
        }

        public Student(string _name, string _address, string _program , int _year, double _fee):base(_name, _address)
        {
            program = _program;
            year = _year;
            fee = _fee;
        }
        public Student()
        {

        }

        public override string ToString()
        {
            return $"\n" +
                $"Student : {Name}\n" +
                $"Address : {Address}\n" +
                $"Program : {program}\n" +
                $"Year : {year}\n" +
                $"Fee : {fee}\n" +
                $"";
        }

    }
}
