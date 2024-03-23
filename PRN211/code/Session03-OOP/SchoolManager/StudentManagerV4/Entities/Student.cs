using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV4.Entities
{
    internal class Student
    {
        //type prop tab tab to automatically generate properties
        public string Id { get; set; } //Id, Name,... is so called PROPERTY
        public string Name { get; set; } //A PROPERTY GOES ALONG WITH TWO METHODS
        public string Email { get; set; } //GET() SET(), THINK IT A AS VARIABLE ALSO
        public int Yob { get; set; } //TO GET() ITS VALUE, TO ASSIGN IT A VALUE
        public double Gpa { get; set; } //.Id = ???; .Id

        public void ShowAll() => Console.WriteLine("{0} | {1} | {2} | {3} | {4}", Id, Name, Yob, Email, Gpa);

        //Java: @Override
        //C#: override, new
        public override string ToString() => $"{Id} | {Name} | {Yob} | {Email} | {Gpa}";

        //THE BACKING FIELDS AUTOMATICALLY GENERATED IN THE RUNTIME
        //NOT CODING TIME TO KEEP THE SOURCE COED MORE CLEAN
        //AUTO-IMPLEMENTED PROPERTIES

        //JAVA: YOU HAVE TO USE 3RD PARTY LIBRARIES/DEPENDENCY
        //TO GET THE SAME: LOMBOK


    }
}

//Class formular: Step to create a class
//1. Create a class with a name (Noun, Pascal Case)
//2. Declare attribute/field/backing fields with _ convention
//   profull tab tab
//   * Using AUTO-IMPLEMENTED PROPERTY (DO NOT NEED TO DECLARE BACKING FIELDS)
//
//3. Declare the CONSTRUCTOR BOTH EMPTY CONSTRUCTOR (EXPLICIT - TUOUNGWF MINH, CHỦ ĐỘNG) & PARAMETER CONSTRUCTOR
//  OR DONT DECLARE ANY CONSTRUCTOR - COMPLIER/RUNTIME WILL CREATE A DEFAULT ONE FOR YOU
//
//4. CREATE A TOSTRING() METHOD TO SHOW ALL (MOST OF) INFORMATION OF AN OBJECT
//   OR SHOWPROFILE() SHOWALL() METHOD TO CHECK THE INTERNAL STATE OF AN OBJECT
//   * ToString() is A STANDARD NAME YOU SHOULD FOLLOW

//5. DEFINE THE OTHER METHODS TO PROCESS ANY THING WITHIN AN OBJECT