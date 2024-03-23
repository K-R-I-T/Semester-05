using StudentManagerV1.Entities;

namespace StudentManagerV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an object from a mold/template
            //we need material to fill in (parameter for a method)
            //we need use the funnel - to call the constructor - the same 
            CreateAStudentV1();
        }

        static void CreateAStudentV1()
        {
            //We name everything around us. Ta có thói quen đặt tên cho mọi thứ xung quanh, even the thing is a single value or complex value - object
            //3.14 -> PI
            //10% -> VAT
            //9.8 -> g (gravity)
            //s = v * t (t time, v velocity, s distance)
            //Messi -> (name... dob... goals... awards... club...)
            //CR7 -> (name... dob... goals... awards... club...)
            //a name to make easy to communicate with
            Student an = new Student("SE1", "An Nguyen", 2003, "ann@fpt.edu.vn", 8.8);
            //an: the name of a complex value
            //new Student("SE1", "An Nguyen", 2003, "ann@fpt", 8.8); -> the value of an object, complex value
            an.ShowProfile();
        }

        static void CreateAStudentV2()
        {
            var an = new Student("SE1", "An Nguyen", 2003, "ann@fpt.edu.vn", 8.8);
            an.ShowProfile();
            //var an means an has the data tyoe of Student
            //runtime will update an data tyoe based on the assigned value
        }

        static void CreateAStudentV3()
        {
            Student an = new("SE1", "An Nguyen", 2003, "ann@fpt.edu.vn", 8.8);
            an.ShowProfile();
        }

        static void CreateAStudentV4()
        {
            Student an = new(gpa: 8.8, id: "SE1", name: "An Nguyen", yob: 2003, email: "ann@fpt.edu.vn");
            an.ShowProfile();
            //named argument: pass a parameter in a method in flexible
            //order, by given the name of parameter accompany with value
        }
    }
}
