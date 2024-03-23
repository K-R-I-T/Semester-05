namespace PassByDelegateV1
{
    //CHALLENGE #1: VIẾT HÀM IN RA CÁC BÀI HÁT CỦA TAYLOR SWIFT, MỖI BÀI MỘT HÀM
    //SOLUTION: DÙNG HÀM LẺ BÌNH THƯỜNG

    //C#2: DÙNG DELEGATE ĐỂ IN RA 2 BÀI HÁT

    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintSongLyricThe1();
            //PrintSongLyricLover();
            //2 hàm cùng style là void F() => thuộc nhóm Action

            //C#2
            Console.WriteLine("C#2: The song lyrics printed by using delegate");
            Action f = PrintSongLyricThe1;
            f += PrintSongLyricLover;
            f.Invoke(); //hoặc f() gọi luật sư phát ngôn giùm thân chủ đã gán qua = hoặc +=

            //C#3: IN RA BÀI HÁT THỨ 3 CỦA TAYLOR - DÙNG ANONYMOUS | LAMBDA
            //f += bài hát 3 đc nối vào
            //f = bắt đầu lại từ đầu | chỉ có bài đang gán vào!!!

            f = delegate ()
            {
                Console.WriteLine("The song Carolina - by Taylor Swift");
                Console.WriteLine(); //1 dòng trắng cách tên bài hát
                Console.WriteLine(@"[Verse 1]
Oh, Carolina creeks running through my veins
Lost I was born, lonesome I came
Lonesome I'll always stay
Carolina knows why, for years, I roam
Free as these birds, light as whispers
Carolina knows

[Pre-Chorus]
And you didn't see me here
No, they never did see me here
And she's in my dreams
...");
            };
            //gọi hàm in hoy
            f();

            f += () =>
            {
                Console.WriteLine("The song August - by Taylor Swift");
                Console.WriteLine();
                Console.WriteLine(@"[Verse 1]
Salt air, and the rust on your door
I never needed anything more
Whispers of ""Are you sure?""
""Never have I ever before""

[Chorus]
But I can see us lost in the memory
August slipped away into a moment in time
'Cause it was never mine
And I can see us twisted in bedsheets
August sipped away like a bottle of wine
'Cause you were never mine
...
");

            };
            //in 2 bài hát Carolina va August
            Console.WriteLine("CHALLENGE #3: 2 SONGS");
            f();
        }

        static void PrintSongLyricLover()
        {
            Console.WriteLine("The song Lover - by Taylor Swift");
            Console.WriteLine();
            Console.WriteLine(@"We could leave the Christmas lights up 'til January
And this is our place, we make the rules
And there's a dazzling haze, a mysterious way about you, dear
Have I known you twenty seconds or twenty years?

[Chorus]
Can I go where you go?
Can we always be this close?
Forever and ever, ah
Take me out and take me home
You're my, my, my, my lover
...");
            Console.WriteLine();
        }

        static void PrintSongLyricThe1()
        {
            Console.WriteLine("The song The 1 - by Taylor Swift");
            Console.WriteLine();
            Console.WriteLine(@"I'm doing good, I'm on some new shit
Been saying ""yes"" instead of ""no""
I thought I saw you at the bus stop, I didn't though
I hit the ground running each night
I hit the Sunday matinée
You know the greatest films of all time were never made
...");
            Console.WriteLine();
        }
    }
}
