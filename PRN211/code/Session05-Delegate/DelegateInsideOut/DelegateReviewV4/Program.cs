namespace DelegateReviewV4
{
    internal class Program
    {
        public delegate void OneInputNoOutputDelegate(int x);
        //                      void F(int x)
        static void Main(string[] args)
        {
            //tui mún viết hàm in ra các số từ 1...n
            PrintNumbers(1000);

            OneInputNoOutputDelegate f = delegate (int n)
            {
                Console.WriteLine($"The list of numbers from 1 to {n}");
                if (n < 1)
                {
                    Console.WriteLine("N must be >= 1");
                    return; //ko gì cả
                }
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine(); //xuống hàng sau khi in dàn ngang
            };

            f = (int n) =>
            {
                Console.WriteLine($"The list of numbers from 1 to {n}");
                if (n < 1)
                {
                    Console.WriteLine("N must be >= 1");
                    return; //ko gì cả
                }
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine(); //xuống hàng sau khi in dàn ngang
            }; //V2: LAMBDA

            f = (n) =>
            {
                Console.WriteLine($"The list of numbers from 1 to {n}");
                if (n < 1)
                {
                    Console.WriteLine("N must be >= 1");
                    return; //ko gì cả
                }
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine(); //xuống hàng sau khi in dàn ngang
            }; //LAMBDA V2

            f = n =>
            {
                Console.WriteLine($"The list of numbers from 1 to {n}");
                if (n < 1)
                {
                    Console.WriteLine("N must be >= 1");
                    return; //ko gì cả
                }
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine(); //xuống hàng sau khi in dàn ngang
            }; //LAMBDA V3

            f = ngocTrinh =>
            {
                Console.WriteLine($"The list of numbers from 1 to {ngocTrinh}");
                if (ngocTrinh < 1)
                {
                    Console.WriteLine("N must be >= 1");
                    return; //ko gì cả
                }
                for (int i = 1; i <= ngocTrinh; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine(); //xuống hàng sau khi in dàn ngang
            }; //LAMBDA V3
            f(1000);
        }

        static void PrintNumbers(int n)
        {
            Console.WriteLine($"The list of numbers from 1 to {n}");
            if (n < 1)
            {
                Console.WriteLine("N must be >= 1");
                return; //ko gì cả
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine(); //xuống hàng sau khi in dàn ngang
        }
    }
}
