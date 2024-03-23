namespace PassByDelegateV3
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //C#5: GỌI 2 HÀM IN 2 BÀI HÁT QUA THAM SỐ HÀM!!!!!!!!!!! NEW!!!!
        //    PrintSongLyricLover();
        //    PrintSongLyricThe1(); //style Action cho cả 2

        //    Action f = PrintSongLyricThe1;
        //    f = PrintSongLyricLover;
        //    f = () => { };

        //    //BIẾN DELEGATE = HÀM NÀO ĐÓ CỤ THỂ CÓ SẴN, = 1 BIỂU THỨC LAMBDA
        //    //              = 1 ĐOẠN CODE NÀO ĐÓ!!!

        //    //ĐIỀU GÌ XẢY RA NẾU KHAI BÁO THAM SỐ CỦA HÀM LÀ 1 DELEGATE
        //    //TÊN HÀM & CODE TƯƠNG ỨNG ĐC PASS VÀO 1 HÀM KHÁC!!!!!!!!!!

        //    //int a = 10;   void F(int a)       F(5), F(6)
        //    //                         đưa vào 1 con giá trị để gán cho a
        //    //                         do a là con số nguyên

        //    //              void F(Action f)    F(
        //    //                   đưa vào 1 con giá trị cho f để gán cho F
        //    //                   con giá trị này là HÀM KHÁC
        //    //                   DO F = TÊN HÀM!!!

        //    f();
        //}

        static void Main(string[] args)
        {
            //PrintSongs();

            //PrintSongs(Action f); = 1 hàm cụ thể nào đó style Action
            Action f = PrintSongLyricThe1;
            f += PrintSongLyricLover;

            PrintSongs(f);

            //C#5 - HÃY IN TIẾP BÀI HÁT AUGUST, IN 1 MÌNH CX ĐC

            //CẤM CHƠI HÀM LẺ; HÃY XÀI PRINTSONGS();

            f = () =>
            {
                Console.WriteLine("The song August - by Taylor Swift");
                Console.WriteLine("I never needed anthing more...");
            };
            Console.WriteLine("C#5: PASS DELEGATE AS PARAMETER");
            PrintSongs(f);

            //C#6: IN BÀI HÁT IS IT OVER NOW?
            Console.WriteLine("C#6: PASS DELEGATE AS PARAMETER");
            
            PrintSongs(() => { });

            PrintSongs(delegate ()
            {
                Console.WriteLine("The song Is It Over Now? - by Taylor Swift");
                Console.WriteLine("I slept all alone (Uh-huh)");
            });

            //C#7: VIẾT VÀ IN RA CÁC SỐ TỪ 1...1000
            
            //DÙNG HÀM PRINTSONGS() VÃI!!!!!!

            PrintSongs(() =>
            {
                for (int i = 1; i <= 1000; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();    //sống có trách nhiệm - in dàn ngang xong rồi xuống hàng
            });
        }

        static void PrintSongs()
        {
            PrintSongLyricLover();
            PrintSongLyricThe1();
        }

        static void ProcessNumber(int n) //xài hàm: ProcessNumber(500)
        {
            int result = n * n;
        }

        static void PrintSongs(Action f) //xài hàm PrintSongs(cần 1 value đưa vào
                                         //                   1 hàm khác style Action)
        {


            f(); //run hàm f() nào đó, luật sư đang nói!!!
                 // nói cho thân chủ nào, thì lúc chạy PrintSongs(đưa vào thân chủ)

            //PrintSongLyricLover();
            //PrintSongLyricThe1();
        }

        public static void PrintSongLyricThe1()
        {
            Console.WriteLine("The song The 1 - by Taylor Swift");
            Console.WriteLine();
        }

        public static void PrintSongLyricLover()
        {
            Console.WriteLine("The song Lover - by Taylor Swift");
            Console.WriteLine();
        }
    }
}
