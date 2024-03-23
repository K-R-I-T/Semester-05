namespace PassByDelegateV2
{
    //C#4: HÃY IN RA CÁC BÀI HÁT CỦA TAYLOR. CÓ 1 CLASS LƯU TRỮ CÁC BÀI HÁT. HÃY GỌI HÀM TỪ CLASS NÀY ĐỂ IN. DÙNG DELEGATE LUÔN
    public class ShowBiz
    {
        //_banking fields, Properties, Ctor(), Get/Set(), ToString() và các hàm khác
        //hàm, và properties, _fields có thể là: public, private, protected. STATIC VÀ NON_STATIC

        public void PrintSongLyricThe1()
        {
            Console.WriteLine("The song The 1 - by Taylor Swift");
            Console.WriteLine();
            Console.WriteLine(@"I'm doing good, I'm on some new shit
Been saying ""yes"" instead of ""no""
I thought I saw you at the bus stop, I didn't though
I hit the ground running each night
I hit the Sunday matinée
You know the greatest films of all time were never made
...
");
        }

        public static void PrintSongLyricLover()
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
...
");
        }

    }
    //các class ngang cơ nhau, ở chung 1 namesapce okie!!!
    //chung tập tin vật lí hoặc khác tập tin vật lí okie luông
    internal class Program
    {
        static void Main(string[] args)
        {
            //C#4 - gọi hàm từ class khác
            Console.WriteLine("C#4: call method from another class");
            Action f = ShowBiz.PrintSongLyricLover; //kí hợp đồng luật sư = thân chủ
            f();
            //in bài The 1 - nó là non-static của class ShowBiz
            //non thì phải new rồi
            ShowBiz song = new ShowBiz(); //xài default ctor
            f += song.PrintSongLyricThe1; //vì The1 is non-static
            //luật sư run()
            f();
        }
    }
}
