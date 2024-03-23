using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV3.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private string _email;
        private int _yob;
        private double _gpa;

        //We create an empty constructor by our self
        //explicitly empty constructor - chủ động tường minh
        //and we can even create multiple constructor
        //there are multiple way to create an object depending
        //on how many information you want to fill in first

        //You visit a registration page
        //name (*): __________
        //email (*): __________
        //dob: __________
        //address: __________
        //phone: _________
        //zip code: _________
        //education: _________

        //ctor tab to create a default/an empty contructor

        public Student()
        {
            
        }

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }

        public Student(string id, string name, string email, int yob, double gpa)
        {
            _email = email;
            _yob = yob;
            _gpa = gpa;
        }

        //ctrl . -> choose Generate parameters ctor as you want

        //Get/Set() methods
        public string GetId()
        {
            return _id;
        }

        public void SetId(string id)
        {
            _id = id;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public int Yob //Yob: PROPERTY
        {               //  PROPERTY IS NEW FEATURE IN C# TO MAKE OUR PROJECT MORE AND MORE NATURAL LIKE IN REAL LIFE
                        //IT IS A COMBINATION OF GET/SET METHODS
                        //IN DEEPER, IT STILL USE BACKING FIELD TO STORE
                        //THE ACTUAL VALUE/ATTRIBUTE OF AN OBJECT
                        //
                        //A "FULL-PROPERTY" TECHNIQUE
            get { return _yob;}
            set { _yob = value;}
        }
        //USAGE: .YOB, CW(S.YOB) -> CALL GETYOB()
        //                       -> TAKE THE VALUE OF _YOB, A VARIABLE AS NORMAL
        //       .YOB = 2003 -> LIKE SET()
        //ASSIGN A NEW VALUE FOR YOB

        public double Gpa
        {
            get => _gpa;
            set => _gpa = value;
        }//you can use get, or set in a separately way
        //or both of them

        //if you forget the format to write Get() Set()
        //type propfull tab tab

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

    }
}
