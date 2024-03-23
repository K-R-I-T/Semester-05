using StudentManagerV3.Entities;

namespace StudentManagerV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            //the tool offers you multiple ways to create an object
            //there are three ways in this case to create an object

            //update an existing object by using setting
            //and show it up by using getting
            //via using PROPERTIES INSTEAD OF GET() AND SET()
            s1.Email = "ahihi@fpt.edu.vn";
            s1.Gpa = 8.6;

            Console.WriteLine($"{s1.GetId()} {s1.Email} {s1.Gpa} {s1.Yob}");
            
            //NEW WAY TO CREATE AN EMPTY OBJECT AND USING PROPERTY
            Student s2 = new Student() { Email = "amazing@...", Gpa = 9.9, Yob = 2003 };
            //CREATE OBJECT USING PROPERTY INITIATION
            Console.WriteLine($"{s2.Email} {s2.Gpa} {s2.Yob}");
        }
    }
}
