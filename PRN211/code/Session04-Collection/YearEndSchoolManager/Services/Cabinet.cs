using Repositories.Entities;

namespace Services
{
    public class Cabinet<T> //Type - data type as a parameter - GENERIC
        //Java: List<Student> list = new ArrayList<Student>();
        //Cabinet<Student> seBox = new Cabinet();
        //Cabinet<Lecturer> leBox = new Cabinet();
    {
        //private Student[] _list1 = new Student[300];
        //private Lecturer[] _list2 = new Lecturer[300];
        //private int _count1 = 0;
        //private int _count2 = 0;

        private T[] _list = new T[300];
        private int _count = 0; //to count the current number of elements in the array

        //CRUD METHODS
        public void AddItem(T item)
        {
            //TODO: CHECK THE LIMIT OF THE ARRAY OR YOU WILL RECEIVE THE OUT OF BOUND EXCEPTION
            _list[_count] = item; //_list[299] okie _list[300] -> EXCEPTION,
            _count++;
        }

        public void PrintAll()
        {
            Console.WriteLine($"There is/are {_count} item(s) in the list");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_list[i]); //gọi thầm tên em - call ToString() implicitly
            }
        }
    }
}
