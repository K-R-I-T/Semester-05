namespace Numerology
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. IN HẾT DÃY SỐ CÓ TRONG NUMBER SERVICE
            NumberService.PrintNumbers(n => Console.Write(n + " "));

            //2. IN CÁC SỐ ÂM TRONG KHO
            Console.WriteLine();
            NumberService.PrintNumbers(n => { if (n < 0) Console.Write(n + " "); });
            Console.WriteLine("------------------------");

            //ĐẾM SỐ DƯƠNG
            Console.WriteLine("> 0: ");
            NumberService.Count1(n => n > 0);

            Console.WriteLine("< 0: ");
            NumberService.Count2(n => n < 0);
        }

        //hàm lẻ nhận vào x làm gì với x kệ void F(int x) {... hay in luôn}
    }
}
