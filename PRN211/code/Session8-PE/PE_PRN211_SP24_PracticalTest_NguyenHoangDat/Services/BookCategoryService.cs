using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookCategoryService
    {
        //CUNG CẤP DATA CHO FORM, THỰC RA LÀ CUNG CẤP DATA CHO CÁI DROPDOWN, BẤM XỔ, COMBOBOX
        //public List<BookCategory> GetAllBookCategories()
        //{
        //    List<BookCategory> arr = new List<BookCategory>();

        //    arr.Add(new BookCategory()
        //    {
        //        BookCategoryId = 1,
        //        BookCategoryName = "Programming",
        //        BookCategoryDescription = "Programming Books"
        //    });

        //    arr.Add(new BookCategory()
        //    {
        //        BookCategoryId = 2,
        //        BookCategoryName = "Database",
        //        BookCategoryDescription = "Database Books"
        //    });

        //    arr.Add(new BookCategory()
        //    {
        //        BookCategoryId = 3,
        //        BookCategoryName = "Network",
        //        BookCategoryDescription = "Network Books"
        //    });

        //    arr.Add(new BookCategory()
        //    {
        //        BookCategoryId = 4,
        //        BookCategoryName = "Security",
        //        BookCategoryDescription = "Security Books"
        //    });

        //    return arr;
        //}

        public List<BookCategory> GetAllBookCategories()
        {
            BookCategoryRepository repo = new BookCategoryRepository();
            return repo.GetBookCategories();
        }

    }
}
