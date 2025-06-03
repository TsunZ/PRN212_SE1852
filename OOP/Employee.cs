using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private string _email;
        private string _phone;

        public Employee()
        {
        }

        public Employee(int id, string name, string email, string phone)
        {
            _id = id;
            _name = name;
            _email = email;
            _phone = phone;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Id: {_id}\tName: {_name}\tEmail: {_email}\tPhone: {_phone}");
        }

        public override string ToString()
        {
            string msg = $"Id: " + _id + "\tName: " + _name + "\tEmail: " + _email + "\tPhone: " + _phone;
            return msg;
        }

    }
}
