namespace PredicateDelegate
{

    //CHALLENGE 1: VIẾT HÀM CHECK GPA >- 8 HAY KO

    //CHALLENGE 2: VIẾT HÀM CHECK GPA >- 8 HAY KO DÙNG FUNC

    //CHALLENGE 3: VIẾT HÀM CHECK GPA >- 8 HAY KO DÙNG PREDICATE

    delegate bool CheckGt8Delegate(double gpa);
    //                     Func<double, bool>
    //nếu hàm chỉ nhận vào 1 giá trị nào đó, 1 đầu vào
    //và trả về bool, đc quyền ko xài Func, mà xài Predicate
    //                     Predicate<double>
    //

    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, bool> f1 = gpa => gpa >= 8;
            Console.WriteLine("10 > 8? " + f1(10));

            Predicate<double> f2 = gpa => gpa >= 8;
            Console.WriteLine("4 > 8? " + f2(4));

            //câu lệnh dễ thương
            var f3 = (int a, int b, int c) => a + b + c;

        }

        static bool CheckHangGtEquals8(double gpa) => gpa >= 8;

        //static bool CheckHangGtEquals8(double gpa)
        //{
        //    return gpa >= 8;
        //}

        //static bool CheckHangGtEquals8(double gpa)
        //{
        //    if (gpa >= 8)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
