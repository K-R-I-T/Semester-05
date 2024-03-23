using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearStory
{
    internal class Validation
    {
        public static bool CheckInput(out int number, int max)
        {
            string? input = Console.ReadLine();
            bool check = int.TryParse(input, out number);
            if (!check)
            {
                Console.WriteLine("Please input a number");
            }
            else if (number < 1 || number > max)
            {
                Console.WriteLine("Please input a number from 1 to {0}", max);
                check = false;
            }
            return check;
        }

        public static bool CheckInput(out double number)
        {
            string? input = Console.ReadLine();
            bool check = double.TryParse(input, out number);
            if (!check)
            {
                Console.WriteLine("Please input a number");
            }
            else if (number < 0)
            {
                Console.WriteLine("Please input a positive number");
                check = false;
            }
            return check;
        }
    }
}
