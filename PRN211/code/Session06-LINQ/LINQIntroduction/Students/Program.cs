namespace Students
{
    //THÁCH THỨC DANH HÀI: TA CÓ DANH SÁCH SINH VIÊN...
    //LIST<Student> arr = new List<Student>() {new Student(){Id = "SE1", Name = "An",
    //                                         new Student(){Id = "SE2", Name = "Binh",
    //                                         new Student(){Id = "SE3", Name = "Cuong",
    //                                         new Student(){Id = "SE4", Name = "Dung",
    //                                        };
    //TA IN TOÀN BÔ SV, TA IN SV Ở TỈNH NÀY, TA IN SV CÓ ĐIỂM GPA >= 8, GPA >= 8 Ở BÌNH DƯƠNG
    //ĐƯA LAMBDA VÀO ARR.WHERE( s => {s.Id s.Gpa});
    //TAO LÀ HÀM .WHERE() CỦA LIST ARR, VÀ TAO CÓ RẤT NHIỀU SV TRONG TAY
    //TAO THẢY TỪNG SV TÊN LÀ S CHO HÀM CỦA MÀY ĐƯA VÀO. MÀY MÚN LÀM GÌ VỚI S THÌ MÀY LÀM
    //2 CƠ CHẾ XỬ LÍ: TAO LIST ĐƯA TỪNG ĐỨA, TỪNG OBJECT, CON SỐ CHO HÀM NGOÀI, BÊN NGOÀI LÀM GÌ THÌ LÀM -> ACTION<>: FOREACH...
    //                TAO LIST ĐƯA TỪNG ĐỨA CHO CHÚNG MÀY HÀM NGOÀI, HÀM NGOÀI BÁO TAO KU ĐÓ
    //                CÓ HỢP LỆ KO, TAO LIST KIỂM SOÁT TRỞ LẠI: SUM, COUNT, WHERE...
    
    //LINQ: Language Integrated Query: KĨ THUẬT TRUY VẤN DATA TRONG RAM THEO 2 STYLE
    //HÀM LAMBDA - GỐC          - METHOD SYNTAX
    //CÂU "SQL" VIẾT NGƯỢC      - QUERY SYNTAX
    //MERGE
    //.XÀI CHUỖI . . . . BẢN CHẤT LÀ TRẢ VỀ OBJECT CHẤM TIẾP ĐC

    //JAVA: STREAM API, ĐẦU VÀO CỦA HÀM TRAI BAO() SẼ LÀ OBJECT XUẤT PHÁT TỪ INTERFACE CHỈ CÓ DUY NHẤT 1 HÀM - INTERFACE CHỈ CHO PHÉP CÓ TỐI ĐA 1 HÀ ABSTRACT
    //FUNCTIONAL INTERFACE
    //@FunctionalInterface
    //public interface DeathRacer
    //lambda Java ->   C# =>
    //LINQ ~ STREAM API (KO NHẦM LẪN VỚI I/O STREAM - TẬP TIN)
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
