using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearStory
{
    internal class Menu
    {
        static bool check;
        public static void ShowMenu(out int choice)
        {
            do
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("1. Compute the BMI indicator");
                Console.WriteLine("2. Get the Zodiac sign in (VI, EN, FR, JP,...)");
                Console.WriteLine("3. Quit");
                Console.Write("Input your choice (1...3): ");
                check = Validation.CheckInput(out choice, 3);
            } while (!check);
        }

        public static void ShowMenu(out double weight, out double height)
        {
            do
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.Write("Input your weight (kg): ");
                check = Validation.CheckInput(out weight);
            } while (!check);
            do
            {
                Console.Write("Input your height (m): ");
                check = Validation.CheckInput(out height);
            } while (!check);
        }

        public static void ShowMenu(out int month, out int day)
        {
            do
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.Write("Input your month: ");
                Validation.CheckInput(out month, 12);
            } while (!check);
            do
            {
                Console.Write("Input your day: ");
                int temp = 0;
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Validation.CheckInput(out temp, 31);
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Validation.CheckInput(out temp, 30);
                        break;
                    case 2:
                        Validation.CheckInput(out temp, 28);
                        break;
                }
                day = temp;
            } while (!check);
        }
    }
}
