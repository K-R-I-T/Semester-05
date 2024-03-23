namespace PassByAction
{
    //CHALLENGE: VIẾT HÀM THẦU CÁC HÀNH ĐỘNG NÀO ĐÓ BÊN NGOÀI
    //           HÀM THẦU CÁC DỊCH VỤ IN ẤN NÀO ĐÓ: IN BÀI HÁT, IN SỐ, IN DÃY SỐ...
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sqrt(25);  //run
            DoOnDemand(delegate ()
                {
                    Console.WriteLine("Cầm tay anh, dựa vai anh");
                    Console.WriteLine("Code cùng anh, nơi này có C#");
                }
            );
            DoOnDemand(() =>
                {
                    Console.WriteLine("Chúng ta không thuộc về nhau");
                    Console.WriteLine("C# chắc có là của nhau");
                }
            );
        }
        //          DoSomething(int n)
        static void DoOnDemand(Action f) // = hàm nào đó có style void F()
                                         // = hàm ẩn danh hay hàm lambda
        {
            Console.WriteLine("Do - while - for - code as normal");

            //later, call back f
            f(); //f.Invoke();
        }

        static void F()
        {
            return;
        }
    }
}
