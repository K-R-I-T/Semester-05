using Repositories.Entities;
using Services;

namespace MainUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //by using Generic, we can create a flexible bag/room/container/cabinet
            //for now the box can hold Student
            //                can hold Lecturer
            //                can hold Student of SE dept, Biz dept, etc.
            //all of these are allocated in different memory segmentation like in the real life, we have many cabinets/boxes for seperate purposes
            //cross-function cabinet - tủ đa năng
            Cabinet<Student> seList = new Cabinet<Student>();
            //Java: ArrayList<Student> list = new ArrayList<Student>();

            Cabinet<Student> bizList = new Cabinet<Student>();

            Cabinet<Lecturer> seLecList = new Cabinet<Lecturer>();

            seList.AddItem(new Student() { Id = "SE001", Name = "An", Email = "an@...", Yob = 2000, Gpa = 3.0 });
            //obj initializer - khởi tạo đối tượng
            seList.AddItem(new Student() { Id = "SE002", Name = "Binh", Email = "binh@...", Yob = 2001, Gpa = 3.1 });
            
            bizList.AddItem(new Student() { Id = "BIZ001", Name = "Bao", Email = "bao@...", Yob = 2002, Gpa = 3.2 });
            
            seLecList.AddItem(new Lecturer() { Id = "L001", Name = "Lan", Email = "lan@...", Yob = 1980, Salary = 1000 });
            
            seLecList.AddItem(new Lecturer() { Id = "L002", Name = "Linh", Email = "linh@...", Yob = 1981, Salary = 1100 });

            //print all bags: 2 SE students, 1 Biz student, 2 lecturers
            Console.WriteLine("The SE student list");
            seList.PrintAll();      //2
            
            Console.WriteLine("The BIZ student list");
            bizList.PrintAll();     //1
            
            Console.WriteLine("The SE lecturer list");
            seLecList.PrintAll();   //2
        }
    }
}
