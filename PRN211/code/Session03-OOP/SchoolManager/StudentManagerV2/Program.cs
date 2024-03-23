using StudentManagerV2.Entities;

namespace StudentManagerV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            //if a mold/class has no ctor, the SDK will automatically create an empty/a default ctor for your class
            //empty ctor has format of:
            //Student() without any parameter
            //          without the code in the body
            //Student() {}
            //if you use this funnel, default funnel, you will create
            //an empty/a default object, with "full-air" object
            //for every backing fields, they are filled as default value
            //number = 0, string => empty - nothing
            //bool = false
            s1.ShowProfile();

            s1.SetName("An Nguyen");
            s1.SetGpa(8.6);

            Console.WriteLine("After updating profile, no longer empty/default fields");
            s1.ShowProfile();
        }
    }
}
