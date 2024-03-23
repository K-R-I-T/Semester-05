namespace Numbers
{
    //CHALLENGE #1: LƯU TRỮ 1 DANH SÁCH SỐ NGUYÊN CHO TRƯỚC
    //              SAU ĐÓ IN RA: CÁC SỐ DƯƠNG
    //                            CÁC SỐ ÂM
    //                            IN RA TOÀN BỘ
    //                            IN RA CÁC SỐ CHIA HẾT CHO 5
    //                            ...
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //in tất
        //    Console.WriteLine("Print all");
        //    PrintListOnDemand(x => true); //đưa ai cũng true hết

        //    //in số +
        //    Console.WriteLine("Print +");
        //    PrintListOnDemand(x => x > 0); //x > 0 mới true
        //}

        static void Main(string[] args)
        {
            PlayWithBuiltOnDemandMethodsV2();
        }

        static void PlayWithBuiltOnDemandMethodsV2()
        {
            List<int> arr = new List<int> { -10, -100, 50, 2, 1, 5, 10, 13, -2 };

            var result = from x in arr  //với mọi x thuộc arr
                         where x > 0    //xem x nào > 0
                         select x;      //thì lấy x đó mà trả về để dùng tiếp
            //CÂU QUERY GIỐNG NHƯ SQL DÙNG ĐỂ TRUY VẤN DATA TRONG RAM - LINQ THEO STYLE QUERY SYNTAX

            //RUNTIME CHẠY THÌ CONVERT VỀ LAMBDA NHƯ ĐÃ VIẾT, .WHERE(X => X > 0) - LINQ THEO STYLE METHOD SYNTAX
            //METHOD SYNTAX

            Console.WriteLine("> 0 using QUERY");
            foreach (var x in result)
                Console.WriteLine(x);

            Console.WriteLine("Divisible by 2");
            result = from x in arr  //với mọi x thuộc tập arr
                     where x % 2 == 0 //xem x nào chẵn hay ko
                     select x;
            foreach (var x in result)
                Console.WriteLine(x);
        }

        static void PlayWithBuiltOnDemandMethods()
        {
            List<int> arr = new List<int> { -10, -100, 50, 2, 1, 5, 10, 13, -2 };
            //tui mún in tất cả dãy số
            //arr có sẵn 1 loạt các hàm để xử lí data mà nó cất giữ, thay vì ta phải tự làm. Hàm style on demand cũng cần Action, Action<>, Func<>, Predicate<> tùy loại hàm: in, tính tổng, count, trung bình,...

            //1. In toàn bộ con số
            Console.WriteLine("ALL =======================");
            arr.ForEach(x => Console.WriteLine(x));

            //2. In số âm
            Console.WriteLine("< 0 =======================");
            arr.ForEach(x => { if (x < 0) Console.WriteLine(x); });

            //3. Trả về các số dương cho tui 50, 2, 1, 5, 10, 13
            //HÀM DEMAND TRẢ VỀ LIST ĐỂ TA DÙNG TIẾP THAY VÌ CHỈ IN RA
            Console.WriteLine("> 0 LIST ======================");

            List<int> result = arr.Where(x => x > 0).ToList();
            result.ForEach(x => Console.WriteLine(x));
        }

        static void PrintListOnDemand(Predicate<int> f)
        {
            List<int> arr = new List<int> { -10, -100, 50, 2, 1, 5, 10, 13, -2 };

            foreach (var x in arr)
            {
                //2 cách: giao khoán hết ra ngoài in Action<int>
                //        chủ động in, nhưng nhờ bên ngoài check giá trị Predicate<int>
                if (f(x))                   //f(x) == true
                    Console.WriteLine(x);
            }
        }
    }
}
