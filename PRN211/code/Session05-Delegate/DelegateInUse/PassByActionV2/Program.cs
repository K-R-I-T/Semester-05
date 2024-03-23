namespace PassByActionV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TÍNH TỔNG CHẴN
            Console.WriteLine("Sum of evens");
            SumOnDemand(CheckEven);

            //TÍNH TỔNG LẺ
            Console.WriteLine("Sum of odds");
            SumOnDemand(x => x % 2 != 0);

            //TÍNH TỔNG CỦA TẤT CẢ
            Console.WriteLine("Sum all");
            SumOnDemand(x => true);
            //đưa x nào cũng là true, hàm trả về true cho mọi x
        }

        static bool CheckEven(int x) => x % 2 == 0;

        //CHALLENGE: VIẾT HÀM TÍNH TỔN CỦA 1 DÃY SỐ CHO TRƯỚC
        //           VẪN DÃY SỐ ĐÓ, TÍNH TỔNG CỦA SỐ CHẴN
        //           VẪN DÃY SỐ ĐÓ, ĐÉM CÁC SỐ LẺ
        //           5 10 15 20 2 4 6 8 1 3 5 7 9

        static void DoOnDemand(Predicate<int> f) 
        {
            List<int> arr = new List<int> { 5, 10, 15, 20, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
        }

        //TÍNH TOÁN THEO ĐIỀU KIỆN ĐƯA VÀO:
        //SUM: SUM CÁI GÌ (ĐK ĐƯA VÀO): SUM CHẴN, SUM LẺ, SUM NGUYÊN TỐ
        //COUNT: COUNT CÁI GÌ
        static void SumOnDemand(Func<int, bool> f) //= hàm bool F(int x)
                                                  //      CheckEven(int x) -> true false
        {
            List<int> arr = new List<int> { 5, 10, 15, 20, 2, 4, 6, 8, 1, 3, 5, 7, 9 };

            int result = 0;

            foreach (var n in arr)
            {   //if đúng con x (tiêu chí nào đó) thì
                //mình hàm TraiBao giành lại con x để làm gì tiếp
                if (f(n) == true) //CheckEven(n) == true
                    result += n;
            }
            Console.WriteLine("Sum: " + result);
        }


        static void DoOnDemand()
        {
            List<int> arr = new List<int> { 5, 10, 15, 20, 2, 4, 6, 8, 1, 3, 5, 7, 9 };

            int result = 0;

            foreach (var n in arr)
            {
                result += n; //con x luôn đúng chả xét tiêu chí gì cả
            }

            result = 0;
            foreach (var n in arr)
            {
                if (n % 2 == 0) //if đúng con x (tiêu chí nào đó) thì
                    result += n;
            }

            result = 0;
            foreach (var n in arr)
            {
                if (n % 2 != 0)
                    result++;
            }
        }
    }
}
