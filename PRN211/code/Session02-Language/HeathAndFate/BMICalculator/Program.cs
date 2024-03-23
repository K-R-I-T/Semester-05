namespace Bmi //IN JAVA, NAMESPACE CAN BE CONSIDERED AS PACKAGE
{               //in java package bmicalculator;
    internal class Program  //internal means no one/no outside class
                            //(in another namespace) can access this class
                            //to make a class (inside a namespace) available
                            // to be accessed outside, you have to set this
                            //class as PUBLIC
                            //internal, no internal means: this class is used
                            //by another class but they must be in the same namespace
                            //ENCAPSULATION REGARDING TO NAMESPACE LEVEL
                            //BY DEFAULT, ENCAPSULATION TIGHTS WITH CLASS
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double bmi = GetBmi(60, 1.71);
            Console.WriteLine("1. Your BMI is " + bmi); //CONCATENATE (ghép chuỗi) by using + 
            Console.WriteLine("2. Your BMI is {0}", bmi); //place holder
            Console.WriteLine("3. Your BMI is {0} | {1}", bmi, 2024);   //start with 0, 1, 2
            Console.WriteLine($"4. Your BMI is {bmi}"); //interpolation
                                                        //runtime try to find out where is the variable
                                                        //and replace it with corresponding value
                                                        //call the method in the other class
            Console.WriteLine($"5. Your BMI is {BmiCalculator.GetBmi(60, 1.71)}");

            //String, string are the same meaning
            string weightStatus = BmiCalculator.EvaluateHeathStatus(bmi);
            Console.WriteLine($"You are in 60kg, 1.71m and for you, \nyour weight status is {weightStatus}");
            Console.WriteLine($"You are in 60kg, 1.71m and for you, " +
                $"\nyour weight status is {weightStatus}");
            
            //raw string
            //@ in a leading string will ask the runtime to
            //show the string as it appears in the code
            //what you type is what you see in the end-user screen
            //TECHNIQ: VERBATIM
            Console.WriteLine(@$"You are in 60kg, 1.71m 
and for you, 
<html>
    <head>

                your weight status is {weightStatus}");
        }

        //METHOD HERE
        public static double GetBmi(double weight, double height) => weight / (height * height);
        //for a method that has ONLY STATEMENT
        //we can shortent the method by using => keyword
        //without return, no return
        //don't make a mistake this with LAMDA EXPRESSION. BOTH OF THEM SHARE THE SAME
        //BUT IN DEFFERENT CONTEXT

        //=> IN THIS CASE IS SO CALLED: BODY EXPRESSION

        //public static double GetBmi(double weight, double height)
        //{
        //   return weight / (height * height);
        //}
        //Ctrl K C to comment a block of code
        //Ctrl K U to un-comment a block of code
        //Ctrl K D to format the code  (Alt Shift F)
    }
}
