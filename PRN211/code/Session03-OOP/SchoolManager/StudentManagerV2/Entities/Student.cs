using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Java: com.mycompany.myproject.mymodule.
//      com.microsoft.sqlserver.jdbc.SQLServerDriver
//. means a sub folder, a package, a box to keep things
namespace StudentManagerV2.Entities
{
    internal class Student
    {
        private string _id; //_ and camelCase
        private string _name; //field, attribute, backed field
        private string _email; //backing field
        private int _yob;
        private double _gpa;

        //we create no constructor

        //we need to create Get() and Set() to allow an object can communicate with the other
        public string GetName()
        {
            return _name;
        }

        public string GetEmail() => _email;

        public void ShowProfile() => Console.WriteLine($"{_id} | {_name} | {_email} | {_yob} | {_gpa}");

        public void SetGpa(double gpa) => _gpa = gpa;

        public void SetName(string name)
        {
            _name = name;
        }
    }
}
