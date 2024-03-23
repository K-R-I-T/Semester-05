using StudentManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Services
{
    internal class Cabinet
    {   //a Cabinet likes a box to store that has more spaces to store things
        //so its property/attribute is an array!!!
        //my be it has color, label, manufacturer, ... but we focus on to stroe things instead of
        
        private Student[] _list = new Student[300]; //backing field
        
        private int _count = 0; //to know where to put to the array
        //will be increased one by one when we put a new profile to the array

        //why i dont you {get; set;} like in Student class
        //think that you have never use the Cabinet in the way that: put 300 profiles at once to fill in the Cabinet
        //think that: you take one by one profile, slowly put each of it into the Cabinet
        //we rarely assign an array (like the normal property int Yob) by using one statement and at once
        //We assign the elements of an array
        //one by one [0] = [1] = [2] =
        //never arr = !!!
        //never _list = !!!
        //A BOX, A CONTAINER WILL INTRODUCE THE CRUD METHODS TO ALLOW YOU TO WORK WITH THE SPACES INSIDE THE BOX
        //OPEN THE DOOR OF A BOX, PUT A NEW THING
        //OPEN THE DOOR OF A BOX, TO FIND THINGS
        //OPEN THE DOOR OF A BOX, TO TAKE A DESIRED ONE, TO MODIFY IT
        //OPEN THE DOOR OF A BOX, TO REMOVE THE OLD ONE...
        //CRUD: CREATE, READ/RETRIEVE, UPDATE, DELETE
        //          SELECT SUM()            SELECT *
        //              JOIN, LEFT JOIN

        //SOLID PRINCIPLE
        //S: SINGLE RESPONSIBILITY PRINCIPLE - TÍNH ĐƠN TRÁCH NHIỆM CỦA HÀM/CLASS
        //O: OPEN/CLOSE PRINCIPLE - MỞ RỘNG, ĐÓNG GÓI
        //L: LISKOV SUBSTITUTION PRINCIPLE - TÍNH THAY THẾ
        //I: INTERFACE SEGREGATION PRINCIPLE - TÍNH TÁCH RỜI GIAO DIỆN
        //D: DEPENDENCY INVERSION PRINCIPLE - TÍNH ĐẢO NGƯỢC PHỤ THUỘC
        //THIS CLASS, THIS METHOD DOESNT TIGHT WITH THE INPUT METHOD
        //TO MAKE THIS CLASS MORE FLEXIBLE TO SERVER MULTIPLE KINDS OF APP: CONSOLE, WEB, MOBILE, DESKTOP...
        //IT DOESNT HAVE CONSOLE.READLINE() TO TIGHT WITH COMMAND LINE
        //INSTEAD, IT TAKES THE VALUE VIA PARAMETERS
        //USER, DEV, YOU PREPARE DATA IN SOME WHERE OUT THERE
        //IM HERE TO PROCESS YOUR DATA, STORE YOUR DATA
        //THE INPUT DATA MISSION, THE OTHER GUY WILL TAKE IT
        public void AddNewProfile(string id, string name, string email, int yob, double gpa)
        {
            _list[_count] = new Student() { Id = id, Name = name, Email = email, Yob = yob, Gpa = gpa };
            _count++;
        }

        //print the list, to see all available profiles
        public void PrintStudentList()
        {
            Console.WriteLine($"There is/are {_count} student(s) in the box:");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_list[i]); //ToString() in background
                                             //gọi thầm tên em
            }
        }
    }
}
