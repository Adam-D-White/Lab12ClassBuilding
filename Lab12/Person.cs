﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Person
    {

        private string name;
        private string address;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Address
        {
            set { address = value; }
            get { return address; }

        }

        public Person(string _name, string _address)
        {
            name = _name;
            address = _address;
        }
        

        
        public Person()
        {

        }
        public override string ToString()
        {
            return $"\n" +
                $"Name : {name}\n" +
                $"Address : {address} \n" +
                $"";
        }


    }
}
