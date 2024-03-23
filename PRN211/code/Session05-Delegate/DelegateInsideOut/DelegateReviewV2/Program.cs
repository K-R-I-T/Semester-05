namespace DelegateReviewV2
{
    public delegate void NoInputNoOutputDelegate();

    internal class Program
    {
        static void Main(string[] args)
        {
            //xài class, data type qua biến!
            NoInputNoOutputDelegate f = PrintNumbers;
            f(); //~ PrintNumbers();

            //Tui mún in ra các số lẻ từ 1...100
            //A: Viết 1 hàm in số lẻ như bình thường, rồi sau đó gắn vào biến nick name f
            //gọi f() hoặc f.Invoke() hay gọi chính chủ PrintOddNumbers()
            f = delegate ()
            {
                Console.WriteLine("The list of odd numbers from 1..100");
                for (int i = 1; i <= 100; i += 2)
                {
                    if (i % 2 != 0)
                        Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }; //KĨ THUẬT HÀM ẨN DANH, BÁN TÊN HÀM CHO CHỮ F
               //HÃY GỌI EM LÀ F THAY VÌ GỌI EM THEO TÊN GỐC KHI KO CHƠI TRÒ ẨN DANH

            f();

            //NÂNG TIẾP: HÃY VIẾT HÀM IN RA CÁC SỐ CHẴN
            //KO CHƠI TRÒ LÀM HÀM LẺ, VẬY CHỈ CÒN CÁCH HÀM ẨN DANH
            f = delegate ()
            {
                Console.WriteLine("The list of even numbers from 1..100");
                for (int i = 2; i <= 100; i += 2)
                {
                    if (i % 2 == 0)
                        Console.Write("{0} ", i);
                }
                Console.WriteLine();
            };
            //hợp đồng bán mình cho quỷ đã xong,
            f();

        }

        static void PrintOddNumbers()
        {
            Console.WriteLine("The list of odd numbers from 1..100");
            for (int i = 1; i <= 100; i += 2)
            {
                if (i % 2 != 0)
                    Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

        //cần vài hàm để luật sư - thân chủ
        //in ra các số từ 1...100
        static void PrintNumbers()
        {
            Console.WriteLine("The list of numbers from 1..100");
            for (int i = 0; i <= 100; i++)
            {
                //Console.WriteLine(i + " ");
                //Console.WriteLine($"{i} ");
                Console.Write("{0} ", i);
            }
            Console.WriteLine(); //xuống hàng sau khi in dàn ngang để tránh ảnh hưởng lệnh in sau đó!!!
        }
    }
}
