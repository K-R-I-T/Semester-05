namespace Zodiac
{
    //today we will study how to makee a document/a guideline for using a library. -- comment in

    /// <summary>
    /// This class will compute and return a zodiac sign based on the day and month of birth. The zodiac sign in English, Vietnamese
    /// </summary>
    public class ZodiacCaculator
    {
        /// <summary>
        /// This method will return a zodiac sign in English based on the day and month of birth
        /// </summary>
        /// <param name="day">The day must be between 1 ... 31 </param>
        /// <param name="month">The month must be between 1 ... 12</param>
        /// <returns></returns>

        public static string GetZodiacEnglish(int month, int day)
        {
            switch (month)
            {
                case 1: //January
                    if (day <= 19)
                        return "Capricorn"; //Ma Kết
                    return "Aquarius"; //Bảo Bình
                case 2: //February
                    if (day <= 18)
                        return "Aquarius"; //Bảo Bình
                    return "Pisces"; //Song Ngư
                case 3: //March
                    if (day <= 20)
                        return "Pisces"; //Song Ngư
                    return "Aries"; //Bạch Dương
                case 4: //April
                    if (day <= 19)
                        return "Aries"; //Bạch Dương
                    return "Taurus"; //Kim Ngưu
                case 5: //May
                    if (day <= 20)
                        return "Taurus"; //Kim Ngưu
                    return "Gemini"; //Song Tử
                case 6: //June
                    if (day <= 21)
                        return "Gemini"; //Song Tử
                    return "Cancer"; //Cự Giải
                case 7: //July
                    if (day <= 22)
                        return "Cancer"; //Cự Giải
                    return "Leo"; //Sư Tử
                case 8: //August
                    if (day <= 22)
                        return "Leo"; //Sư Tử
                    return "Virgo"; //Xử Nữ
                case 9: //September
                    if (day <= 22)
                        return "Virgo"; //Xử Nữ
                    return "Libra"; //Thiên Bình
                case 10: //October
                    if (day <= 23)
                        return "Libra"; //Thiên Bình
                    return "Scorpio"; //Bọ Cạp
                case 11: //November
                    if (day <= 21)
                        return "Scorpio"; //Bọ Cạp
                    return "Sagittarius"; //Nhân Mã
                case 12: //December
                    if (day <= 21)
                        return "Sagittarius"; //Nhân Mã
                    return "Capricorn"; //Ma Kết
                default: //Wrong month
                    return "HotGirl"; //HotGirl
            }
        }

        /// <summary>
        /// This method converts/translate a zodiac sign in English to Vietnamese
        /// </summary>
        /// <param name="zodiacEnglish">The zodiac sign in English</param>"
        /// <returns>The zodiac sign in Vietnamese</returns>

        public static string GetZodiacVietnamese(string zodiacEnglish)
        {
            switch (zodiacEnglish)
            {
                case "Capricorn":
                    return "Ma Kết";
                case "Aquarius":
                    return "Bảo Bình";
                case "Pisces":
                    return "Song Ngư";
                case "Aries":
                    return "Bạch Dương";
                case "Taurus":
                    return "Kim Ngưu";
                case "Gemini":
                    return "Song Tử";
                case "Cancer":
                    return "Cự Giải";
                case "Leo":
                    return "Sư Tử";
                case "Virgo":
                    return "Xử Nữ";
                case "Libra":
                    return "Thiên Bình";
                case "Scorpio":
                    return "Bọ Cạp";
                case "Sagittarius":
                    return "Nhân Mã";
                default:
                    return "Ngọc Trinh";
            }
        }
    }
}
