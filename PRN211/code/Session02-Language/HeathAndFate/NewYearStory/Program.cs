using Zodiac;

namespace NewYearStory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string enZodiac = ZodiacCaculator.GetZodiacEnglish(1, 10);
            //Console.WriteLine($"Zodiac in English: {enZodiac}");

            ////var means that we don't need to specify the data type of a variable at the time of its declaration
            ////During the compilation time, the compiler will automatically decide the data type of the variable based on the value assigned to it.
            ////THIS TECHNIC IS SO CALLED INFERRENT - SỰ SUY LUẬN KIỂU
            //var viZodiac = ZodiacCaculator.GetZodiacVietnamese(enZodiac);
            //Console.WriteLine($"Zodiac in Vietnamese: {viZodiac}");

            int select = 0;
            do
            {
                Menu.ShowMenu(out int choice);
                select = choice;
                switch (choice)
                {
                    case 1:
                        Menu.ShowMenu(out double weight, out double height);
                        Methods.ComputeBMI(weight, height);
                        break;
                    case 2:
                        Menu.ShowMenu(out int month, out int day);
                        Methods.GetZodiac(month, day);
                        break;
                    case 3:
                        Console.WriteLine("Goodbye!");
                        break;
                }
            } while (select != 3);
        }
    }
}

//ASSIGNMENT #2
//DO NOT NEED TO CREATE A NEW SOLUTION/PROJECT
//JUST UPDATE THIS CLASS TO DO THE FOLLOWING FEATURES FOR NewYearStory APP
//WHEN RUNNING THIS APP, IT SHOWS A MENU:
//1. Compute the BMI indicator
//2. Get the Zodiac sign in (VI, EN, FR, JP,...)
//3. Quit
//Input your choice (1...3):
//If user chooses 1, then it will ask user to input the weight and height, then it will show the BMI indicator
//If user chooses 2, then it will ask user to input the month and day, then it will show the Zodiac sign in English
//3 to quit the app

//TAKE YOUR TIME TO DO THE VALIDATION IN INPUT VALUE
//TRY WITH THE VALIDATION YOU THINK THAT IS IMPORTANT

//30 FEBRUARY AHIHI :)))

//CLEAN THE SOLUTION, COMPRESS IT UNDER .ZIP .RAR
//DEADLINE: TUESDAY 23/01/2024 9:30

//HINT FOR YOU
//USE: DO-WHILE TO MAKE A MENU
//DO {
//PRINT MENU CW("1....");
//SWITCH (choice) {}
//WHILE (EXIT GATE CHOICE != 3);

//How to get the input from keyboard
//Console.Readline() -> string -> convert to number
//int.
//double.  ~Integer.ParseInt()