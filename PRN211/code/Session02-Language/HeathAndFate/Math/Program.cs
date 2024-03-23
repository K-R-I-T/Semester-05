using Bmi; //import java.util....;

namespace Math
{
    internal class Program
    {
        //svm tab -> to get the Main()
        //psvm tab in Java
        //static void Main(string[] args)
        //{
        //    //CheckTheReadOnlyPara(10);
        //    //Console.WriteLine($"The sum of all: {SumIntegerList}");

        //    int sumA;
        //    int sumE;

        //    sumA = SumIntegerList(out sumE);
        //    Console.WriteLine($"The sum of all: {sumA} | Sum even: {sumE}");
        //}

        //work with ref and out keyword, used on method parameter
        //Using ref, out, will make a variable as a outside changing
        //updating inside a method, a variable out side the change
        //this is so call: pass by reference
        //Modify some where, but the other some where is affected
        static void Main(string[] args)
        {
            int sumAll;
            int sumO = 2021;
            //you must initialize a value, a default value
            //for the ref variable before using it
            //beacause the method doesn't promise to produce a
            //value of ref variable since the assign statement
            //for this ref variable is not mandatory
            sumAll = sumOddList(ref sumO);
            Console.WriteLine($"SumO: {sumO}");

        }

        public static int sumOddList(ref int sumOdd)
        {
            int sumAll = 0, sumO = 0;

            for (int i = 1; i <= 10; i++)
            {
                sumAll += i;

                if (i % 2 != 0)
                    sumO += i;
            }
            //with ref Event Keyword, it doesn't require a assign
            //the ref variable, it is optional
            sumOdd = sumO; //not mandatory, but you should do this
            //to throw/return the value outside

            return sumAll;
        }

        //write a method to caculate the sum of an integer list
        //1 + 2 + 3 + 4 + 5 + ... + 10
        public static int SumIntegerList()
        {
            int sumAll = 0;

            // for tab twice in quickly

            for (int i = 1; i <= 10; i++)
                sumAll += i;
            return sumAll;
        }

        //OVERLOAD, OVERLOADING - QUÁ TẢI HÀM

        //OVERLOAD/OVERLOADING VS. OVERRIDE/OVERRIDING

        //OVERLOAD CAN OCCUR/HAPPEN IN ANY CLASS WHERE THERE ARE MULTIPLE METHODS USE/SHARE THE SAME NAME
        //BUT DIFFERING IN THE PARAMETERS BY DATA TYPE
        //WE FOCUS ON THE DIFFERENCE OF PARAMETER DATA TYPE
        //WE DON'T CARE ABOUT THE DIFFERENCE OF PARAMETER NAME

        //OVERRIDE: OCCURS ONLY ON INHERITANCE, IN CHILD CLASS
        //WHERE THE CHILD CLASS HAS A METHOD WITH THE SAME SIGNATURE
        //WITH PARENT (SIGNATURE OF A METHOD: THE NAME + PARAMETERS)
        //100% METHOD NAME IS EQUALS WITH PARENT

        //OKIE
        void FRight(int n) { } //(5), (6)
        void FRight(double n) { } //(5.0)

        //wrong
        //void FWrong(int n) { }; //this method requires an integer
        //void FWrong(int a) { }; //this method also requires an integer

        //2 + 4 + 6 + 8 + 10 = 30
        //1 + 2 + 3 + 4 + 5 + ... + 10 = 45
        public static int SumIntegerList(out int sumEven)
        {
            int sumAll = 0, sumE = 0;

            // for tab twice in quickly

            for (int i = 1; i < 10; i++)
            {
                sumAll += i; //caculate sumAll
                if (i % 2 == 0)
                    sumE += i; //caculate sumE
            }

            //if a parameter has out keyword, in the method
            //MUST HAVE A STATEMENT TO ASSIGN A VALUE FIR THIS PARAMETER
            //I PROMISE TO SEND OUT A VALUE, SEND A VALUE OUTSIDE
            //A MUST HAVE STATEMENT
            sumEven = sumE; //a must have

            return sumAll;
        }


        //mantra: static play with static
        //in means: read only  variable
        //TODO AT HOME: static void CheckTheReadOnly(in Student s)
        static void CheckTheReadOnlyPara(in int n)
        {
            //pass a number to the method, print it, change it
            Console.WriteLine($"Before modification, n is {n}");
            //n = 2024;
            Console.WriteLine($"After changing, n is {n}");
        }


        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");

        //    double bmi = BmiCalculator.GetBmi(60, 1.71);
        //    string healthStatus = BmiCalculator.EvaluateHeathStatus(bmi);
        //    Console.WriteLine("Your health status is {0}", healthStatus);

        //    Console.WriteLine("Press any key to exit...");
        //    Console.ReadLine();
        //}

    }
}
