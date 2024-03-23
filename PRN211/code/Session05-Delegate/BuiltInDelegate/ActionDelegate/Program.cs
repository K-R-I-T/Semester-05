namespace ActionDelegate
{
    //CHALLENGE 1: VIẾT HÀM IN RA 1 CÂU THÔNG BÁO. "NAM EM ĐÃ RA VIỆN"
    //CHALLENGE 2: VIẾT HÀM IN RA 1 CÂU THÔNG BÁO. "NAM EM ĐÃ RA VIỆN"
    //             ko theo style hàm truyền thống - viết hàm rõ ràng

    //CHALLENGE 3: VẪN HÀM NHƯ TRÊN, NHƯNG KO XÀI DELEGATE CỦA MÌNH MÀ XÀI
    //             DELEGATE CÓ SẴN ĐC CUNG CẤP BỞI MS - NHA SĨ KHUYÊN DÙNG!!!

    public delegate void NoInputNoOutputDelegate();
    //             1 data type, tên gọi chung, style hàm y chang Student, int
    //Action: là 1 delegate có sẵn, đại diện cho 1 style hàm ko vào ko ra
    //THAY VÌ PHẢI NGHĨ RA TÊN STYLE CHO NHÓM HÀM, DÙNG ACTION ĐÃ LÀ ĐỦ
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //RUN HÀM
        //    //ShowMessage();

        //    //NoInputNoOutputDelegate f = ShowMessage;
        //    ////             luật sư    = thân chủ
        //    ////             nick name - 1 hàm có 2 tên
        //    //f();

        //    NoInputNoOutputDelegate f = delegate ()
        //    {
        //        Console.WriteLine("NAM EM ĐÃ RA VIỆN!!!");
        //    }; //vip
        //    //             luật sư    = thân chủ ko tên
        //    f();

        //    //LAMBDA
        //    NoInputNoOutputDelegate f1 = () =>
        //    {
        //        Console.WriteLine("NAM EM ĐÃ RA VIỆN!!!!");
        //    };//vip
        //    //             luật sư    = thân chủ ko tên
        //    f1 = () => Console.WriteLine("NAM EM ĐÃ RA VIỆN!!!!");//vip

        //    f1();
        //}

        static void Main(string[] args)
        {
            //NoInputNoOutputDelegate f = ???; hàm nào đó - có sẵn hoặc anonymous hoặc lambda expression

            //Action f = ???; hàm ko vào ko ra nào đó, hoặc ano, hoặc lambda

            NoInputNoOutputDelegate f1 = ShowMessage;
            Action f2 = ShowMessage;

            f2.Invoke();
            f2();

            //CHALLENGE 4: VIẾT HÀM IN RA CÂU: "8-3: CHÚNG TA CỦA TƯƠNG LAI"

            Action f3 = delegate ()
            {
                Console.WriteLine("8-3: CHÚNG TA CỦA TƯƠNG LAI");
            };

            f3();

            //CHALLENGE 5: VIẾT HÀM IN RA CÂU: "8-3: SƠN TÙNG & HẢI TÚ CHÚNG TA CỦA TƯƠNG LAI"
            Action f4 = () => Console.WriteLine("8-3: SƠN TÙNG & HẢI TÚ CHÚNG TA CỦA TƯƠNG LAI");
            f4();

        }

        static void ShowMessage() => Console.WriteLine("NAM EM ĐÃ RA VIỆN!!!");

        //static void ShowMessage()
        //{
        //    Console.WriteLine("NAM EM ĐÃ RA VIỆN!!!");
        //}
    }
}
