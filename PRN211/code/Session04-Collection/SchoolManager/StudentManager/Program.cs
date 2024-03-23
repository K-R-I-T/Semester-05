using StudentManager.Entities;
using StudentManager.Services;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet seBox = new Cabinet();
            Cabinet bizBox = new Cabinet();

            seBox.AddNewProfile("SE1", "An", "an@", 2003, 8.6);
            seBox.AddNewProfile("SE2", "Binh", "binh@", 2004, 6.8);

            bizBox.AddNewProfile("SS1", "Cuong", "cuong@", 2005, 8.8);
            bizBox.AddNewProfile("SS2", "Dung", "dung@", 2006, 6.6);

            Console.WriteLine("The Biz students");
            bizBox.PrintStudentList();

            Console.WriteLine("The Se students");
            seBox.PrintStudentList();

            //<Student>         <Lecturer>

            //PlayWithValueTypeArray();
            //PlayWithValueTypeArrayV2();
            //PlayWithObjectValue();
        }

        //CHALLENGE AT HOME: 
        //PRINT OUT THE STUDENT LIST BY NAME IN ASCENDING ORDER
        //PRINT OUT THE STUDENT LIST BY GPA IN DESCENDING ORDER
        //PRINT OUT THE STUDENT LIST BY YOB IN ASCENDING ORDER

        static void PlayWithObjectValue()
        {
            //WE WILL STORE MULTIPL STUDENT PROFILES
            //there are two ways to store multiple objects
            //1. Declare concrete variables/pointer - khai báo biến lẻ
            //Student s1,s2, s3, s4, s5, s6, s7, s8, s9, s10;
            //assign the value for each variable by using new Student(...)
            //s1 = new Student() {Id = "SE1", Name = "An", Mark = 9.5};
            //s2 = new Student() ...

            //2. Using Array, Collection (List, ArrayList, Set, Map,...)
            //int[] arr = new int[10];
            Student[] arr = new Student[10]; //[] to declare multiple variables, not actual value to store

            //arr[0] ~~~ Studen s1;
            //arr[1] ~~~ Studen s2;

            //store the Student value, new Student(...) {...}
            arr[0] = new Student();
            arr[1] = new Student() { Id = "SE10", Name = "An", Gpa = 10.0, Email = "an@fpt.edu.vn", Yob = 2000 }; //object initializer
            //named arguments: (id = ???, name = ???, gpa = ???, email = ???, yob = ???) -> must use with parameter constructor - constructor with parameters
            arr[2] = new Student() { Id = "SE20", Name = "Binh", Gpa = 9.5, Email = "binh@fpt.edu.vn", Yob = 2000 };
            arr[3] = new Student() { Id = "SE30", Name = "Cuong", Gpa = 9.0, Email = "cuong@fpt.edu.vn", Yob = 2000 };
            arr[4] = new Student() { Id = "SE40", Name = "Dung", Gpa = 8.5, Email = "dung@fpt.edu.vn", Yob = 2000 };

            Console.WriteLine("The student list printed by using traditional for");
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.WriteLine(arr[i]);
                Console.WriteLine(arr[i]); //call ToString() in background
            }
        }

        static void PlayWithValueTypeArrayV2()
        {
            //we define an array and init all if values at the same time
            //Student s - new Student() {Id = "SE1", Name = "An", Mark = 9.5}

            int[] arr = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            //we have an array, we have declared 10 int variables
            //          arr[0] arr[1] arr[2] arr[3] ...
            //we init, assign the value for each int variable within the array
            //Khai báo biến, gán luôn giá trị cho 10 biến int trong mảng
            //arr: general variable to manage all of its members, its members also are variables, a list of variables as normal
            //arr: biến má mì, biến mama tổng quản lý 10 đứa dưới quyền

            //using for each like in the Math subject (in high school) to scan the whole of the array
            //what ever you declare an array, i dont care how you declare an array, i know that an array is a set of values, i use for each for the array in overall
            Console.WriteLine("The array has values of:");
            foreach (int x in arr)
                        //int x = arr[0], int x = arr[1], int x = arr[2], ...
            {
                Console.WriteLine(x); //x will take each of value in the array
            }
            foreach (var x in arr)
            //int x = arr[0], int x = arr[1], int x = arr[2], ...
            {
                //Console.Write(x + " "); //x will take each of value in the array
                //Console.Write($"{x} "); //x will take each of value in the array
                Console.Write("{0} ", x); //x will take each of value in the array
            }
        }

        //work with multiple values, multiple objects
        //how to manage many objects/values in an effectively way
        //ARRAY             |COLLECTION
        //EASY TO USE       |EASY TO USE (A LITTLE TECHNIC REQUIRED)
        //SOME LIMITATION   |EFFECTIVE
        //Java: there are 2 different data type - the way we store data
        //1. Primitive data type: int, double, float, char, boolean
        //          Take onll 1 ram/memory block to store value

        //2. Reference data type/Object data type/"Pointer": String, Array, Collection, Class, Object
        //          Take 2 ram/memory block to store value
        //          one: variable/pointer
        //          one: object, the new segment to store actual value of an object

        //C# OFFER 2 WAYS TO STORE VALUES, 2 DATA TYPES LIKE JAVA
        //1. VALUE TYPE (~~~ PRIMITIVE): int, double, float, char, boolean
        //2. REFERENCE TYPE (~~~ OBJECT) - THE SAME WITH JAVA: String, string, Array, Collection, Class, Object
        static void PlayWithValueTypeArray()
        {
            //I want to store 10, or 100, 1000 numbers, how???
            //I want to compute the sum of them???

            //1st answer: declare abitrary/concrete varaibles, KHAI BÁO BIẾN LẺ
            //          RETAILS - BÁN LẺ
            int a1 = 5, a2 = 10, a3 = 15, a4 = 20, a5 = 25, a6 = 30, a7 = 35, a8 = 40, a9 = 45, a10 = 50;
            //how to store 1000 numbers??? you have to manually declare 1000 variables
            int sum = a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10;

            //2nd answer: declare an array, KHAI BÁO MẢNG
            //A SET OF, A LIST OF - 1 DÃY       WHOLE SALE - BÁN SỈ

            int[] arr = new int[10];
            //we have 10 variables
            //arr[0] , arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], arr[8], arr[9]
            // a1 ,      a2,     a3,     a4,     a5,     a6,     a7,     a8,     a9,     a10

            //THE NAME OF A VARIABLE FOR NOW A LITTLE COMPLEX, WITH []
            //[INDEX, THE ORDER OF EACH VARIABLE, WE COUNT THE ODER OF EACH VAR
            //FROM 0, 1, 2]
            //[0]: 1st var
            //[1]: 2nd var
            //...

            arr[0] = 5;
            arr[1] = 10;
            arr[2] = 15;
            arr[3] = 20;
            arr[4] = 25;
            arr[5] = 30;
            arr[6] = 35;
            arr[7] = 40;
            arr[8] = 45;
            arr[9] = 50;

            Console.WriteLine("The array has values of: ");
            
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], arr[8], arr[9]);

            Console.WriteLine($"{arr[0]} {arr[1]} {arr[2]} {arr[3]} {arr[4]} {arr[5]} {arr[6]} {arr[7]} {arr[8]} {arr[9]}");

            Console.WriteLine("The array printed by using traditional for");
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.Write(arr[i] + " ");
                //Console.Write("{0} ", arr[i]);
                Console.Write($"{arr[i]} ");
            }

            //for each, delegate!!!!
            //generic ArrayList<Student>
        }
    }
}
