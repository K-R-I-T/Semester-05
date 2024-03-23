namespace DelegateReviewV3
{
    public delegate void NoInputNoOutputDelegate();

    internal class Program
    {
        static void Main(string[] args)
        {
            //hãy viết hàm in ra tổng các số từ 1...100 -> 5050
            //ko chơi trò hàm nguyên bản truyền thống
            NoInputNoOutputDelegate f = delegate ()
            {
                int sum = 0;
                for (int i = 1; i <= 100; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"The sum of numbers from 1 to 100 is {sum}");
            };

            //run hàm qua tên f()
            f();

            f = () =>
            {
                int sum = 0;
                for (int i = 1; i <= 100; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"The sum of numbers from 1 to 100 is {sum}");
            };
            //run hàm qua tên f()
            f(); //biểu thức Lambda

            //EXPRESSION BODY CHƠI VỚI HÀM BÌNH THƯỜNG, FULL NAME NHƯ TRUYỀN THỐNG
            //VÀ CHỈ CÓ 1 CÂU LỆNH
            //LAMBDA EX CHỈ CHƠI VỚI DELEGATE; HÀM VẪN CÓ THỂ CÓ N CÂU LỆNH
            //LAMBDA EX LÀ 1 DẠNG HÀM ẨN DANH, NHƯNG VIẾT CẮT BỚT NHỮNG KÍ TỰ DƯ THÙA
            //CHỈ ĐỂ TẬP TRUNG VÀO CODE XỬ LÍ CỦA HÀM DẸP CÁC KÍ TỰ RÂU RIA
            //LAMBDA EX ~ CHỈ CÒN CÁI DÂY NỊT - RÚT GỌN ĐẾN TỐI THIỂU

            //TUI MÚN HÀM IN RA CHỮ NHÃ PHƯƠNG VÀ NAM EM!!!

            //f = MakeDrama;
            //f = delegate ()
            //{
            //    Console.WriteLine("Nam Em vs. Nhã Phương");
            //};
            //f = () => { Console.WriteLine("Nam Em vs. Nhã Phương"); };

            f = () => Console.WriteLine("Nam Em vs. Nhã Phương");
        }

        //static void MakeDrama()
        //{
        //    Console.WriteLine("Nam Em vs. Nhã Phương");
        //}

        static void MakeDrama() => Console.WriteLine("Nam Em vs. Nhã Phương");
    }
}
