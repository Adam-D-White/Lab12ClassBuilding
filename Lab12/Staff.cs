using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Staff : Person
    {
        private string school;
        private double pay;

        public string School
        {
            set { school = value; }
            get { return school; }

        }
        public double Pay
        {
            set { pay = value; }
            get { return pay; }
        }

        public Staff(string _name, string _address, string _school, double _pay):base(_name, _address)
        {
            school = _school;
            pay = _pay;

        }
        public Staff()
        {

        }

        public override string ToString()
        {
            return$"\n" +
                $"Staff : {Name}\n" +
                $"Address : {Address}\n" +
                $"School : {school}\n" +
                $"Pay : {pay}\n" +
                $""; 
                
        }

    }
}
