using Bmi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zodiac;

namespace NewYearStory
{
    internal class Methods
    {
        public static void ComputeBMI(double weight, double height)
        {
            double bmi = BmiCalculator.GetBmi(weight, height);
            string status = BmiCalculator.EvaluateHeathStatus(bmi);
            Console.WriteLine("Your BMI is: {0}", bmi);
            Console.WriteLine("Your health status is: {0}", status);
        }

        public static void GetZodiac(int month, int day)
        {
            string enZodiac = ZodiacCaculator.GetZodiacEnglish(month, day);
            string viZodiac = ZodiacCaculator.GetZodiacVietnamese(enZodiac);
            Console.WriteLine("Your zodiac is: {0}", enZodiac);
            Console.WriteLine("Your zodiac in Vietnamese is: {0}", viZodiac);
        }
    }
}
