using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi
{
    //internal, or without internal mean you don't want to show
    //this class outside
    //to public this class for external used, use public accessor
    //private, public, protected, no-mentioned - default, internal
    //-> ACCESSOR, ACCESS MODIFER, ACCESS SPECIFIER
    public class BmiCalculator
    {
        //SINGLETON PATTERN
        public static double GetBmi(double weight, double height) => weight / (height * height);

        public static string EvaluateHeathStatus(double bmi)
        {
            //quick way to evaluate your weight depends on height
            //1.7m = 170cm - 100 = 70kg
            if (bmi < 18.5)
                return "Underweight";
            //bmi at this place may be >= 18.5
            if (bmi < 25)
                return "You are perfect on in body shape...";
            //bmi at this place may be >= 25
            if (bmi < 30)
                return "Overweight"; //quá kí, thừa cân
            return "Obese"; //béo phì
        }
    }
}
