namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        double bmi = BMICalculator.GetBMI(60,1.71);
	Console.WriteLine("My BMI is: " + bmi);
    }
}
