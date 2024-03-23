using Repositories.Entities;
using Services;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BookManagement_NguyenHoangDat
{
    public partial class BookManagementMainUI : Form
    {
        //backing field
        private Book _selected = null; //chờ ai đó nhấn chọn 1 dòng trong grid/table thì nó đc gán = cuốn sách chọn. Đẩy nó sang màn hình update
        private BookService _service = new();

        public BookManagementMainUI()
        {
            InitializeComponent();
        }

        private void FillDataGridView()
        {
            dgvBookList.DataSource = null; //xóa trắng grid
            dgvBookList.DataSource = _service.GetAllBooks();
        }

        private void BookManagementMainUI_Load(object sender, EventArgs e)
        {
            //gọi Services để cung cấp data vào grid/table
            FillDataGridView();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //gọi màn hình Detail lên. Màn hình này bản chất là class BookDetailForm, khác truyền thống là nó có phần render bề mặt!!!
            //Nó 1 class nên nó sẽ có _field, propp, methods như bt
            //khai báo biến, new như bt
            //thêm phần render

            BookDetailForm f = new BookDetailForm();
            f.ShowDialog(); //render đi em
            //f.Show(); //nguy hiểm nhen, vì cứ new là có object, cửa sổ mới!!!
            FillDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //đẩy sang Form Detail để hiển thị
            //khai biến, new như bt
            //thằng form detail: mở lên, check selected khác null hem? khác null mode Edit, Show DATA ĐC GỬI SANG
            if (_selected == null)
            {
                MessageBox.Show("Please select a book to update", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            BookDetailForm f = new BookDetailForm();

            //đưa sách sang
            f.SelectedBook = _selected;
            f.ShowDialog();
            FillDataGridView();
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            //người dùng có thể chọn 1 dòng hay nhiều dòng - chìm chuột, cho nên ta sẽ lấy dòng đầu tiên đc chọn nếu người ta chọn nhiều dòng
            if (dgvBookList.SelectedRows.Count > 0)
            {
                //nếu chọn ít nhất 1 dòng, thì cứ dòng đầu tiên đc chọn là bốc nó r, đẩy sang màn hình detail
                _selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
                //lấy 1 dòng chính là kiểu object tổng quát, nhưng bản chất là book do lúc đầu .DataSource = service.GetAllBooks();
            }
            //TODO: nếu user chọn CEll thay vì nguyên hàng. Reset lại selected = null
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //ta sẽ lấy ra 2 chuỗi đang nằm trong txt
            //và ta where trên cái danh sách books đang có
            var books = new BookService().GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = books.Where(b => b.BookName.ToLower().Contains(txtBookName.Text.ToLower()) || b.Description.ToLower().Contains(txtBookDescription.Text.ToLower())).ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Please select a book to delete", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult answer = MessageBox.Show("Are you sure to delete this book?", "Delete book", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                _service.DeleteBook(_selected);
                FillDataGridView();
                _service = null;
            }
        }
    }
}
