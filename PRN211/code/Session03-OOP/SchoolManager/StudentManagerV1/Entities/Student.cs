using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//in Java: com.mycompany.studentmanager.entities
//         com.mycompany.studentmanager.entities.Student
namespace StudentManagerV1.Entities
{
    internal class Student
    {
        //inside a class is attributes and behaviors of objects that belong to this class
        //Class likes a mold, a template, a form that need to be filled to get a copy/an object
        private string _id; //_______ like a place holder of a form
        private string _name; //_______ like a place holder of a form
        private int _yob; //_______ like a place holder of a form
        private string _email; //_______ like a place holder of a form
        private double _gpa; //_ for naming convention of attributes

        public Student(string id, string name, int yob, string email, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _email = email;
            _gpa = gpa;
        }

        //we have a mold, next wr need a funnel - Phễu
        //to take the outside material, to fill in inside the mold
        // to get the object at the final
        //THE FUNNEL HELP US TO CREATE/CONSTRUCT AN OBJECT/BỨC TƯỢNG
        //THE FUNNEL IS CALLED CONSTRUCTOR - A METHOD TO RECEIVE THE
        //PARAMETERS TO FILL IN

        //Ctrl + . 

        //IN A MOLD/CLASS/OBJECT, THE ATTRIBUTE IS SET A PRIVATE
        //NO ONE OUTSIDE CAN SEE IT
        //I MEET YOU I KNOW THAT YOU HAVE A NAME (PRIVATE)
        //AND WR EXCHANGE, WE COMMUNICATE, I ASK YOU ABOUT YOUR NAME
        //AND YOU TELL ME YOUR NAME
        //RETURN YOUR NAME TO ME!!!
        //THAT ACTION IS CALL GET(), I TELL YOU SOMETHING INSIDE ME

        public string GetName()
        {
            return _name;
        }

        public int GetYob() => _yob;

        public double GetGpa() => _gpa;

        //sometimes we will show full of, most of out internal profile
        //like your profile section in FB
        //this Get() is called ToString()
        //show many information in a long sentence
        public void ShowProfile()
        {
            Console.WriteLine(@$"Here is my profile:
ID: {_id}
Name: {_name}
YOB: {_yob}
Email: {_email}
GPA: {_gpa}");
        }
    }
}
