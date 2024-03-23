using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookRepository
    {
        //class này chơi trực tiếp với SQL Server qua DbContext
        //class này sẽ bị gọi bởi class BookService
        //UI <-----> BookService <-----> BookRepository <-----> DbContext <-----> Table

        //TA Ở ĐÂY BỊ SERVICE GỌI
        //TA Ở ĐÂY ĐI GỌI DBCONTEXT
        //AddBook() UpdateBook() DeleteBook() GetAllBooks() GetBookById() GetBooksByCategory()
        private BookManagementDbContext _context;
        //ko new, sẽ new ở từng hàm trong Repo!!!

        public List<Book> GetBooks()
        {
            _context = new();
            return _context.Books.ToList();
        }

        public void UpdateBook(Book b)
        {
            _context = new();
            _context.Books.Update(b);
            _context.SaveChanges();
        }

        public void AddBook(Book b)
        {
            _context = new();
            _context.Books.Add(b);
            _context.SaveChanges();
        }

        public void DeleteBook(Book b)
        {
            _context = new();
            _context.Books.Remove(b);
            _context.SaveChanges();
        }
    }
}
