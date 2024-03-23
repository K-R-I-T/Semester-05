using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_NguyenHoangDat
{
    public partial class BookDetailForm : Form
    {
        //vì DetailForm cx là 1 class nên nó có prop như bt. Hơn bt là nó là class có thể render (Bố/cha class Form của SDK lo phần render - mối quan hệ kế thừa)
        //public int Yob { get; set; } = 2023;
        public Book SelectedBook { get; set; } = null;
        //mặc định form này mở lên, ko có book nào cả
        //nếu muốn có book thì phải .SetSelectedBook(book) = cuốn muốn gán vào!!!
        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void lblBookName_Click(object sender, EventArgs e)
        {

        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            //MỞ MÀN HÌNH DETAIL THÌ TA SẼ:
            //1. FILL ĐẦY CATEGORY DROPDOWN - LẤY DATA TỪ TABLE CATEGORY
            //2. NẾU LÀ EDIT 1 CUỐN SÁCH THÌ FILL DATA CỦA CUỐN SÁCH MUỐN EDIT VÀO CÁC Ô TƯƠNG ỨNG
            //3. NẾU LÀ TẠO MỚI CUỐN SÁCH, THÌ CỨ ĐỂ MÀN HÌNH TRỐNG CHỜ USER NHẬP INFO - KO CẦN LÀM GÌ THÊM

            BookCategoryService service = new();
            //đổ full data vào dropdown
            cboCategory.DataSource = service.GetAllBookCategories();

            //chọn cột để hiển thị trên cbo
            cboCategory.DisplayMember = "BookGenreType";

            //chọn cột để lấy value thực sự cần dùng - what you see is not what you get
            //Chọn Self help dễ cho user -> code map sang value 5 của cột BookCategoryID, dùng làm FK đẩy vào tablee Book
            cboCategory.ValueMember = "BookCategoryID";

            //vi diệu
            //nhảy đến giá trị bất kì nào mình thích trong cbo
            //mặc định là đầu danh sách xổ 1
            cboCategory.SelectedValue = 5; //default với mình là sách Self Help

            //CHECK HÀNG, CO PHẢI LÀ EDIT HAY KO
            //CHECK BIẾN SELECTEDBOOK COI CÓ ĐC SET KHÁC NULL HA KO
            //NẾU CÓ SÁCH THÌ FILL VÀO CÁC Ô

            if (SelectedBook != null)
            {
                lblHeader.Text = "Update selected Book";
                txtBookId.Enabled = false;
                txtBookId.Text = SelectedBook.BookId.ToString();
                txtBookName.Text = SelectedBook.BookName;
                txtBookDescription.Text = SelectedBook.Description;
                dtpPublicationDate.Value = SelectedBook.PublicationDate;
                txtQuantity.Text = SelectedBook.Quantity.ToString();
                txtPrice.Text = SelectedBook.Price.ToString();
                txtAuthor.Text = SelectedBook.Author;
                cboCategory.SelectedValue = SelectedBook.BookCategoryId;
            }
            else
            {
                lblHeader.Text = "Create new Book";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book b = new()
            {
                BookId = int.Parse(txtBookId.Text),
                BookName = txtBookName.Text,
                Description = txtBookDescription.Text,
                PublicationDate = dtpPublicationDate.Value,
                Quantity = int.Parse(txtQuantity.Text),
                Price = double.Parse(txtPrice.Text),
                Author = txtAuthor.Text,
                BookCategoryId = int.Parse(cboCategory.SelectedValue.ToString())
            };
            BookService service = new();
            if (SelectedBook == null)
                service.AddBook(b);
            else
                service.UpdateBook(b);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
