using StudentManagerV4.Entities;

namespace StudentManagerV4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateAnObjectV1();
            //CreateAnObjectV2();
            CreateAnObjectV3UsingAnonymousType();
        }

        //Assumthat the Student table has 10 columns
        //Student(Id | LastName | FirstName | Dob | Province | Address | MajorId | Gpa | Status ...)
        //SQL statements
        //SELECT * FROM STUDENT => TAKE ALL COLUMNS, ALL ROWS
        //SELECT * FROM STUDENT WHERE <CONDITION TO FILTER ROWS> => TAKE ALL COLUMNS, SOME ROWS
        //SELECT Id, LastName, FirstName, Dob, Email FROM STUDENT
        //A PROJECTION QUERY - PHÉP CHIẾU, DÙNG ỐNG NHÒM ĐỂ NHÌN 1 KHU VỰC
        //                   - USE SCOPE TO SEE A NARROW AREA

        //A WEB PAGE TO SHOW A LIST OF STUDENTS WITH MOST POPULAR COLUMNS LIKE ID | NAME | EMAIL. THERE IS A BUTTON NEXT EACH STUDENT TO ASK USER TO CLICK TO OPEN A FULL DETAILED SCREEN WITH 10 COLUMNS
        static void CreateAnObjectV3UsingAnonymousType()
        {
            Student s1 = new Student() { Id = "SE1", Name = "An Nguyen", Email = "ann@fpt.edu.vn", Gpa = 8.6, Yob = 2003 };
            
            Student s2 = new () { Id = "SE1", Name = "An Nguyen", Email = "ann@fpt.edu.vn", Gpa = 8.6, Yob = 2003 };
            
            var s3 = new Student() { Id = "SE1", Name = "An Nguyen", Email = "ann@fpt.edu.vn", Gpa = 8.6, Yob = 2003 };

            //CREATE A NEW OBJECT BUT USING A LITTLE PROPERTY
            //A FLEXSIBLE WAY TO CREATE AN SMALL OBJECT FROM A BIG ONE

            var newObj = new { Code = "DRK001", Name = "BongCha", Price = 10_000 }; //_ in a number to seperate the 000 000 thousand part

            Console.WriteLine(newObj); //gọi thầm tên em - Call ToString() implicitly
                                       //a ToString() is automatically created for you to use
            Console.WriteLine($"{newObj.Code} | {newObj.Name} | {newObj.Price}");

            Console.WriteLine("Make a projection select on the student object");
            var smallObj = new { s1.Id, s1.Name}; //take a part of existing object s1

            Console.WriteLine(smallObj); //ToString() implicitly

            //                 {Id = "SE1", Name = "An Nguyen"}
        }

        static void CreateAnObjectV2()
        {
            Student s = new Student() { Id = "SE1", Name = "An Nguyen", Email = "ann@fpt.edu.vn", Gpa = 8.6, Yob = 2003 };
            //create an object and assignn the properties at the same time
            //KEYWORD: OBJECT INITIALIZER
            Console.WriteLine("Check the object using object initializer");
            Console.WriteLine(s.ToString()); //pro guy never calls ToString() explicitly - tường minh, rõ ràng
            //pro guy just calls the object variable and the ToString() will be called inplicitly - gọi thầm tên em ToString() 

            Console.WriteLine("Call ToString() implicitly" );
            Console.WriteLine(s);
        }

        static void CreateAnObjectV1()
        {
            //we create an object using the traditional way
            //using empty constructor, and set the property later
            //in a seperately statement
            Student s = new Student();
            s.ShowAll();
            Console.WriteLine(s.ToString());

            //we will use Set() method viad Using Property
            s.Id = "SE1";
            s.Name = "An Nguyen";
            s.Yob = 2003;
            s.Email = "ann@fpt.edu.vn";
            s.Gpa = 8.6;
            Console.WriteLine("Check the object after setting: ");
            s.ShowAll();
            Console.WriteLine(s.ToString());
        }
    }
}
