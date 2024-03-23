using Repositories;
using Repositories.Entities;

namespace Services
{
    //3-layer Architecture:
    //UI-Forms ------- Services ------- Repositories ------- Database
    //MainUI           BookService       BookRepository       BookTable
    //request/response
    //đưa data xuống DB                  chơi trực tiếp DB: lên, xuống
    //lấy data từ DB show                                   CRUD table thực sự
    // RAM                                          DB ĐĨA CỨNG HDD/SSD
    public class BookService
    {
        private BookRepository _repo = new();

        public List<Book> GetAllBooks()
        {
            return _repo.GetBooks();
        }

        public void AddBook(Book b)
        {
            _repo.AddBook(b);
        }

        public void UpdateBook(Book b)
        {
            _repo.UpdateBook(b);
        }

        public void DeleteBook(Book b)
        {
            _repo.DeleteBook(b);
        }

        //Class này trung chuyển dữ liệu giữa Forms UI và CSDL
        //Nó chứa data trong RAM, xử lí mọi thứ thuật tonas nếu cần  rồi đẩy lên UI
        //hoặc cất xuống DB
        //chứa list các Book đọc từ DB
        //chứa info cuốn sách lấy từ màn hình UI dự định cập nhật xuống DB

        //THƯỜNG SẼ CHỨA CÁC HÀM CRUD NHƯNG CHỈ TRONG RAM - LINQ CÓ THỂ NHẢY VÀO

        //giả bộ đã dọc data từ DB lên rồi, giờ show ra màn hình UI
        //tạm thời hard-coded danh sách các cuốn sách trong RAM
        //lấy xong thì cx phải có n cuốn sách trả về trong RAM

        //    public List<Book> GetAllBooks()
        //    {
        //        //gọi Repository, chính xác là gọi class BookRepository trả về sách từ DB
        //        List<Book> arr = new List<Book>();

        //        arr.Add(new Book()
        //        {
        //            BookId = 1,
        //            BookName = "C# Programming",
        //            Author = "John Smith",
        //            Description = "C# Programming for beginners",
        //            Price = 100,
        //            PublicationDate = "2021-01-01",
        //            Quantity = 10,
        //            BookCategoryId = 1
        //        });

        //        arr.Add(new Book()
        //        {
        //            BookId = 2,
        //            BookName = "Java Programming",
        //            Author = "John Smith",
        //            Description = "Java Programming for beginners",
        //            Price = 100,
        //            PublicationDate = "2021-01-01",
        //            Quantity = 10,
        //            BookCategoryId = 1
        //        });

        //        arr.Add(new Book()
        //        {
        //            BookId = 3,
        //            BookName = "Python Programming",
        //            Author = "John Smith",
        //            Description = "Python Programming for beginners",
        //            Price = 100,
        //            PublicationDate = "2021-01-01",
        //            Quantity = 10,
        //            BookCategoryId = 1
        //        });

        //        arr.Add(new Book()
        //        {
        //            BookId = 4,
        //            BookName = "C# Programming",
        //            Author = "John Smith",
        //            Description = "C# Programming for beginners",
        //            Price = 100,
        //            PublicationDate = "2021-01-01",
        //            Quantity = 10,
        //            BookCategoryId = 2
        //        });

        //        arr.Add(new Book() { BookId = 5, BookName = "Java Programming", Author = "John Smith", Description = "Java Programming for beginners", Price = 100, PublicationDate = "2021-01-01", Quantity = 10, BookCategoryId = 2 });

        //        arr.Add(new Book() { BookId = 6, BookName = "Python Programming", Author = "John Smith", Description = "Python Programming for beginners", Price = 100, PublicationDate = "2021-01-01", Quantity = 10, BookCategoryId = 2 });

        //        arr.Add(new Book() { BookId = 7, BookName = "C# Programming", Author = "John Smith", Description = "C# Programming for beginners", Price = 100, PublicationDate = "2021-01-01", Quantity = 10, BookCategoryId = 3 });

        //        arr.Add(new Book() { BookId = 8, BookName = "Java Programming", Author = "John Smith", Description = "Java Programming for beginners", Price = 100, PublicationDate = "2021-01-01", Quantity = 10, BookCategoryId = 3 });

        //        arr.Add(new Book() { BookId = 9, BookName = "Python Programming", Author = "John Smith", Description = "Python Programming for beginners", Price = 100, PublicationDate = "2021-01-01", Quantity = 10, BookCategoryId = 3 });

        //        arr.Add(new Book() { BookId = 10, BookName = "C# Programming", Author = "John Smith", Description = "C# Programming for beginners", Price = 100, PublicationDate = "2021-01-01", Quantity = 10, BookCategoryId = 4 });

        //        arr.Add(new Book() { BookId = 11, BookName = "Java Programming", Author = "John Smith", Description = "Java Programming for beginners", Price = 100, PublicationDate = "2021-01-01", Quantity = 10, BookCategoryId = 4 });

        //        return arr;
        //    }

        //gọi Repo để lấy data từ DB
        //làm ẩu thì có thể gọi trực tiếp từ DbContext
        //làm 3-layer thì gọi từ Repo, repo gọi từ DbContext, dbContext chứa kết nối CSDL
        //nhờ ai giúp thì phải khai báo người đó

    }
}
