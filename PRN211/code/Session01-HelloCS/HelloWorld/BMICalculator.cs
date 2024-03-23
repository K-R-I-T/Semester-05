namespace HelloWorld;
class BMICalculator
{
    //This method is to compute the BMI index based on weight, height
    // bmi = weight (kg) / height^2 (m)
    public static double GetBMI(double weight, double height) 
    {
	return weight / (height * height);
    }
}