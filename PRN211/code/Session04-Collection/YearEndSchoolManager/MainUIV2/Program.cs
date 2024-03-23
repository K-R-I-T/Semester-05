namespace MainUIV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithIntegerList();
        }

        //store/save and print the 10 first integers begining with 1
        static void PlayWithIntegerList()
        {
            //int[] arr = new int[10];
            //arr[0] = 1;
            //arr[1] = 2; arr is a pointer, a variable to point to a big memory segment
            //            in big mem segment will consist of 10 other integer numbers/vars
            //            arr is a bag, a box, a container to store many variables/values

            int[] list = { 1, 2, 3, 4 };

            //Java: List<Integer> list = new ArrayList<Integer>();
            //Java: ArrayList<Integer> list = new ArrayList<Integer>();
            //arr also is a pointer, point to a big mem segment
            //arr is a bag to hold many things are put in
            // how to put?
            //arr.Add(???)
            //how to get one
            //arr.Get(pos)

            //C#: List ~~~~ ArrayList in Java
            //C#: List can new, and replaces for ArrayList in Java
            //C#: also offers ArrayList (focus in another time - it is not safe to use)

            List<int> arr = new List<int>();
            //arr is allso a pointer, point to a bag, big mem segment, 100% the same with Java
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);

            //how to get one???
            //how to print all???

            Console.WriteLine($"There is/are {arr.Count} item(s) in the list");
            //                                 .Size()
            Console.WriteLine("The list is:");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]); //use as an array [] to access each element
                                           //Indexer technic
            }

            Console.WriteLine("The list printed by using for each");
            foreach (var x in arr) //like for each in Math - toán tử với mọi trong Toán học
            {
                Console.WriteLine(x);
            }
        }
    }
}
