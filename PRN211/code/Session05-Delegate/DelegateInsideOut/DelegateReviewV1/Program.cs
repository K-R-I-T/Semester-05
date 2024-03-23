namespace DelegateReviewV1
{
    //tạo delegate bản chất là giống như tạo mới 1 class giống như class Person, class Student
    //chỉ có điều class này thay vì lưu info như bt, nay nó chỉ lưu tên của các hàm mà nó dự định đại diện
    //tạo class delegate này ko dùng cs pháp public class X {...} như truyền thống mà viết tắt dùng keyword delegate
    //delegate void F() ~~~~ public class F [void F()] : Delegate
    //                       {
    //                           code; _lưu_name_của_các_hàm
    //                           ctor, các hàm như bt
    //                           void Invoke() đi lôi cổ các hàm mà nó lưu trữ
    //                                         và run các hàm này
    //                       }
    //MỘT HÀM KHI CHƠI VỚI CLASS NÀY THÌ HÀM TRỞ NÊN CÓ 2 TÊN GỌI
    //TÊN CHÍNH CHỦ CỦA HÀM NHƯ XƯA NAY
    //TÊN MỚI, NICK NAME - BIẾN DELEGATE - BIẾN LÀ TÊN GỌI CHO 1 VALUE, VALUE LÚC NÀY LÀ TÊN HÀM CHÍNH CHỦ

    //MỘT NAMESPACE - PACKAGE - HỘP - THƯ MỤC SOURCE CODE THÌ CÓ CHỨA NHIỀU CLASS

    public class Student
    {
        //...
    }

    //3 THẰNG NGANG CƠ NHAU, Ở NGANG NHAU ĐÓ LÀ: CLASS, INTERFACE (CLASS ĐẶC BIỆT), DELEGATE (CLASS ĐẶC BIỆT) - TA KHAI BÁO DELEGATE NẰM NGOÀI CÁC CLASS KHÁC NHƯNG PHẢI Ở TRONG NAMESPACE

    //public class X [void X()] : Delegate {...}
    public delegate void NoInputNoOutputDelegate();
    //                       tui đại diện cho, lưu trữ những hàm có style void F()


    internal class Program
    {


        static void Main(string[] args)
        {
            //NoInputNoOutputDelegate showMessage = value chính là 1 hàm nào đó khác
            //showMessage - new NoInputNoOutputDelegate(tên_hàm_nào_đó);
            //Student kuBao = new Student(...) { };

            NoInputNoOutputDelegate f1 = new NoInputNoOutputDelegate(SayToHer);
            NoInputNoOutputDelegate f2 = TellHer; //viết tắt, new ngầm
            //                  luật sư   thân chủ
            //                      f2 là nick name của hàm TellHer
            //                      f2 và TellHer đều là như nhau, cùng trỏ đến đoạn code
            //                    1 hàm có 2 tên gọi: chính chủ TellHer, nick f2
            //run TellHer() cũng như run f2()
            //                           f2.Invoke() triệu hồi cái hàm TellHer đang trỏ
            //
            f1();
            f2.Invoke(); //delegate chắc chắn dính đến kế thừa vì có sẵn hàm cho mình chấm
                         //GỌI GIÁN TIẾP, LUẬT SƯ LÀM VIỆC, PHÁT NGÔN

            f2 = SayToHer;    //biến thay đổi value, chuyện quen, int a = 10; a = 11;
            Console.WriteLine("f2 again");
            f2();

            Console.WriteLine("f2 again after +="); //f2 đang Say To Her 1. CSEOK
            f2 += TellHer;                 //f2 sẽ 2. XAEPHP
            f2 += MakeDrama;
            f2.Invoke();         //kết quả là gì????
                                 //+= TOÁN TỬ TÍCH LŨY, NHỒI THÊM VÀO
                                 // int a = 5; a += 10; => a = 15


        }

        //cần tạo ra vài hàm cùng style, sau đó chơi trò luật sư - thân chủ - tạo nick name cho 1 hàm
        static void MakeDrama() => Console.WriteLine("Nam Em vs. Nhã Phương");

        static void SayToHer()
        {
            Console.WriteLine("1. Cuộc sống em ổn không?");
        }
        static void TellHer() => Console.WriteLine("2. Xa anh em phải hạnh phúc!");
        //EXPRESSION BODY KO ĐC NHẦM LẪN VỚI LAMBDA EXPRESS
        //XÀI CHUNG CÚ PHÁP => NHƯNG KHÁC NGỮ NGHĨA!!!

    }
}
