namespace FuncDelegate
{
    //CHALLENGE 1: VIẾT HÀM TÍNH DIỆN TÍCH HÌNH CHỮ NHẬT. TRẢ VỀ KQ
    internal class Program
    {
        delegate double TwoInputOneOutputDelegate(double w, double l);
        //                     Func<double, double, double> 2 vào 1 ra
        //                     Func<string, string> 1 vào 1 ra
        //                     Func<long> 0 vào 1 ra
        //                     TỐI ĐA 16 ĐẦU VÀO + 1 KO VÀO => 17
        //                     đầu ra của hàm quy ước bên phải cùng
        static void Main(string[] args)
        {
            TwoInputOneOutputDelegate f1 = ComputeArea;

            double area = f1(5, 10);
            Console.WriteLine("5x10 = " + area);

            Console.WriteLine("5x10 = " + f1(5, 10));

            TwoInputOneOutputDelegate f2 = (w, l) => w * l;
            Console.WriteLine("5x10" + f2(5, 10));

            Func<double, double, double> f3 = (w, l) => w * l;
            Console.WriteLine("20x20 = " + f3(20, 20));

            //CHALLENGE 2: VIẾT HÀM KIỂM TRA ĐIỂM GPA ĐƯA VÀO CÓ LỚN HƠN HOẶC BẰNG 8 HAY KO

        }

        static double ComputeArea(double w, double l) => w * l;

        //static double ComputeArea(double w, double l)
        //{
        //    return w * l;
        //}
    }
}
