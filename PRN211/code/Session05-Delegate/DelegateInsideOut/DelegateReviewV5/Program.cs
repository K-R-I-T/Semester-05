namespace DelegateReviewV5
{
    //hàm 2 tham số, trả về giá trị
    delegate double TwoInputOneOutputDelegate(double x, double y);
    internal class Program
    {
        static void Main(string[] args)
        {
            //viết giùm tui hàm tính diện tích hình chữ nhật có 2 cạnh width và length. Hàm trả về con số
            //double area = ComputeRectangleArea(5, 10);
            //Console.WriteLine("Area 1 (5x10): " + area);
            //Console.WriteLine("Area 2 (10x10): " + ComputeRectangleArea(10, 10));

            //chơi lambda
            TwoInputOneOutputDelegate f = (width, length) => width * length;

            double area = f(20, 20);

            Console.WriteLine("Area3 (20x20): {0}", f(20, 20));

            Console.WriteLine($"Area4 (20x20): {f(20, 20)}");

            //thách thức cuối:
            //in ra x ^ y Dùng Math.Pow(x, y)

            f = (x, y) => Math.Pow(x, y);

            f = (haiTu, sep) => Math.Pow(haiTu, sep);

            Console.WriteLine("Exponent sep^haiTu: " + f(2, 10)); //1024

        }

        static double ComputeRectangleArea(double width, double length) => width * length;

        //static double ComputeRectangleArea(double width, double length)
        //{
        //    return width * length;
        //}
    }
}
