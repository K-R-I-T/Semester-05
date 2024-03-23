namespace PassByDelegateV4
{
    //C#8: VIẾT HÀM NHẬN VÀO 1 CON SỐ, IN RA CON SỐ ĐÓ
    //C#9: VIẾT HÀM NHẬN VÀO 1 CON SỐ, IN RA CON SỐ ĐÓ NẾU LẦ SỐ CHẴN
    //C#10: VIẾT HÀM NHẬN VÀO 1 CON SỐ, IN RA CON SỐ ĐÓ NẾU LẦ SỐ LẺ

    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintEvenNumber(100);

            //PrintEvenNumber(101);   //éo in
            //PrintEvenNumber(102);

            //PrintOddNumber(103);
            //PrintOddNumber(104);    //éo in
            ////màn hình có gì???

            ////4 hàm cùng 1 style: Action<int>
            //Action<int> f = PrintEvenNumber;
            ////run
            //f(6868);

            PrintNumbers(PrintOddNumber);

            //C#12: DÃY 5 10 15 20, TUI MÚN IN CÁC SỐ > 10
            //MÀ LẠI PHẢI XÀI PRINTNUMBERS() Ở TRÊN

            Console.WriteLine("C#12");
            PrintNumbers(n =>
            {
                if (n > 10)
                    Console.WriteLine(n);
            });

            //C#13: IN RA CÁC SỐ NGUYÊN TỐ
            Console.WriteLine("C#13");
            PrintNumbers(n =>
            {
                if (n > 1)
                {
                    for (int i = 2; i < n; i++)
                    {
                        if (n % i == 0)
                            return;
                    }
                    Console.WriteLine(n);
                }
            });
        }

        //C#11 - VIẾT HÀM IN RA CÁC SỐ CHẴN SỐ LẺ DỰA THEO GIÁ TRỊ ĐƯA VÀO ĐỂ IN
        static void PrintNumbers(Action<int> f)
        {
            //cần phải thêm đầu vào cho f(số nào đó) do f thuộc style cần con số nguyên
            //nếu ta có 1 mảng số, nhồi từng con [i] vào là ngon
            //ta in đc 1 mảng các số chẵn trong những con số đưa vào

            //chưa có mảng thì ta hard-code, code cứng value có sẵn
            f(5);
            f(10);
            f(15);
            f(20);
        }

        static void PrintNumber(int n) => Console.WriteLine(n);

        static void PrintEvenNumber(int n)
        {
            if (n % 2 == 0)
                Console.WriteLine(n);
        }

        static void PrintOddNumber(int n)
        {
            if (n % 2 != 0) //nếu lẻ thì in; ko lẻ thì th
                Console.WriteLine(n);
        }

    }
}
