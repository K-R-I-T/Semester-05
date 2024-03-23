using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerology
{
    internal class NumberService
    {
        static private List<int> _arr = new List<int>() { -5, -10, -1, 5, 10, 15, 20, 1, 3, 5, 7, 100, 101 };

        public static void PrintNumbers(Action<int> f)
        {
            foreach (var n in _arr)
            {
                f(n); //tao lần lượt gửi data cho mày, cho hàm f() hàm f() làm gì với data kệ
                //nếu f() check n > 0 mới in, PrintNumbers() chính là hàm in ra các số > 0
            }
        }

        //style cũ: thiết kế đủ các loại hàm cung cấp data! Đủ cỡ nào cx ko là đủ, do nhu cầu tính toán khác nhau trên bộ data: có người tính chẵn, lẻ, âm dương, nguyên tố, chia hết 5, chia 10...

        //VIẾT HÀM ĐẾM CÁI GÌ ĐÓ TRONG DÃY SỐ TRÊN: ĐẾM CHẴN, ĐẾM LẺ, ĐẾM NGUYÊN TỐ
        //NHÓM: GIÀNH KIỂM SOÁT, OUTSOURCE 1 PHẦN
        public static void Count1(Func<int, bool> f) //= hàm CheckNT(int x)
        {
            int count = 0;
            foreach (var n in _arr)
            {
                //nếu điều gì đúng thi ta count. Đưa điều đó vào đây, hàm thích ứng mọi kiểu đếm
                if (f(n))
                    count++;
            }
            Console.WriteLine("Count: " + count);
        }

        public static void Count2(Predicate<int> f) //= hàm CheckNT(int x)
        {
            int count = 0;
            foreach (var n in _arr)
            {
                //nếu điều gì đúng thi ta count. Đưa điều đó vào đây, hàm thích ứng mọi kiểu đếm
                if (f(n))
                    count++;
            }
            Console.WriteLine("Count: " + count);
        }
    }
}
