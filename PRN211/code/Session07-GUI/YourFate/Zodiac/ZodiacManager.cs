using Services;

namespace Zodiac
{
    //Class Form1 chính là class kế thừa (inherit/inheritance) cái class gốc mà Windows cung cấp để render ra cửa sổ tương tác
    //Form là class Cha, Parent, class gốc có khả năng render 1 HCN ~ web page để cung cấp mặt sàn tương tác với user
    //Ta lập trình app GUI, app Desktop, tức là cái app chạy trêm nền Desktop, có icon biểu tượng trên thanh Taskbar, chính là tạo ra 1 class kế thừa class Form,
    //                             Con extends Cha
    //                             Con kế thừa Cha
    //                             Dog extends Pet
    //                             Cat extends Pet
    //                             Rectangle extends Shape
    //                             chữ kế thừa trong Java là extends
    //                             chữ kế thừa trong C# là :
    public partial class ZodiacManager : Form
    {
        public ZodiacManager()
        {
            InitializeComponent();
        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"signs\hotgirl.jpg");
            //đường dẫn đến bức ảnh dùng dấu \ với Windows
            //dấu / với Linux, MacOS
            //dấu \ lại còn đóng vai trò biểu diễn kí tự đặc bieetk \n: xuống hàng, \t: tab
            //do đó ta phải \\ để cho Win biết rằng ta đang xài \ theo style bình thường

            //2. Show ảnh <img src="...">
            picImage.Image = img;
        }

        private void picImage_Click(object sender, EventArgs e)
        {

        }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //gọi thư viện để trả về cung hoàng đạo
            //trước đó cần lấy đc ngày, tháng sinh đang nằm trong 2 ô text. Toàn bộ gõ từ bàn phím là text
            //ta phải convert về số. Java: Integer.parseInt(string)

            int day = int.Parse(txtDay.Text); //gọi Text {get;}
            int month = int.Parse(txtMonth.Text); //gọi Text {get;}

            string zodiacEN = ZodiacCalculator.GetZodiacEnglish(month, day);

            string zodiacVN = ZodiacCalculator.GetZodiacVietnamese(zodiacEN);

            //string zodiacImage = "signs/" + zodiacEN + ".jpg";

            string zodiacImage = "signs/" + zodiacEN + ".jpg";

            //load ảnh và cập nhật status - cung gì

            Image img = Image.FromFile(zodiacImage);
            picImage.Image = img;

            lblZodiac.Text = "Your zodiac sign is - Cung Hoàng đạo của bạn là: " + zodiacEN + " | " + zodiacVN;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //HỎI XÁC NHẬN MUỐN THOÁT HAY KHÔNG
            DialogResult answer = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //hàm này trả về giá trụ lựa chọn của user khi user bấm nút Yes|no|Ok|Cancel... -> giá trị này thuộc data type DialogResult
            //Dialog: đoạn hội thoại
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
