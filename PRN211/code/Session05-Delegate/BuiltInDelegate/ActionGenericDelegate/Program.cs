namespace ActionGenericDelegate
{
    //CHALLENGE #1: VIẾT HÀM NHẬN VÀO 1 CON SỐ, IN RA BÌNH PHƯƠNG CỦA NÓ
    //CHALLENGE #2: VIẾT HÀM NHẬN VÀO 1 CON SỐ, IN RA LŨY THỪA BỘI CỦA NÓ; DÙNG DELEGATE
    internal delegate void OneInputNoOutputDelegate(int n);
    //                     Action<int>
    //                     Action<string, int>
    //                     Action<int, int, int, int, int ,int, double, char>
    //
    internal class Program
    {

        static void Main(string[] args)
        {
            //ComputeNumber(5);
            OneInputNoOutputDelegate f1 = ComputeNumber;
            f1(5); //25

            Action<int> f2 = ComputeNumber;
            f2.Invoke(10); //f2(10) y chang

            //CHALLENGE #3: VIẾT HÀM MŨ 3, KO DÙNG HÀM TRUYỀN THỐNG
            //PHẢI DÙNG LUÔN ACTION<>
            Action<int> f3 = delegate (int x)
            {
                Console.WriteLine($"{x}^3 = {x * x * x}");
            };

            f3(10); //1000

            Action<int> f4 = x => Console.WriteLine($"{x}^3 = {x * x * x}");
            f4(15); //3375

            //CHALLENGE #4: VIẾT HÀM TÍNH DIỆN TÍCH HÌNH CHỮ NHẬT VÀ IN RA KQ
            Action<double, double> f5 = ComputeArea;

            Action<double, double> f6 = delegate (double w, double l)
            {
                Console.WriteLine($"Area {w} x {l} = {w * l}");
            };

            Action<double, double> f7 = (w, l) => Console.WriteLine($"Area {w} x {l} = {w * l}");
        }

        static void ComputeArea(double w, double l) => Console.WriteLine($"Area {w} x {l} = {w * l}");

        //HÀM TRUYỀN THỐNG
        static void ComputeNumber(int x)
        {
            Console.WriteLine($"{x}^2 = {x * x}");
            Console.WriteLine($"{x}^2 = {Math.Pow(x, 2)}");
        }
    }
}
