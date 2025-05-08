/*
 * static
    * Được khởi tạo 1 lần duy nhất ngay khi biên dịch chương trình.
 */

using Asterisk.MyTek.Extensions;

namespace Asterisk.MyTek.LearnNote.Common;

public class StaticExample
{
    static int x = y; /* you can initialize a static field by using another static field that is not yet declared. */
    static int y = 5;

    public static void StaticVariable()
    {
        /*
         * Nó được khởi tạo vùng nhớ 1 lần duy nhất ngay khi chương trình được nạp vào bộ nhớ để thực thi và huỷ khi kết thúc chương trình.
         * Ngoài biến tĩnh ra thì hằng số cũng có thể được gọi thông qua tên lớp và không cần khởi tạo đối tượng
         nhưng biến tĩnh linh hoạt hơn đó là có thể thay đổi giá trị khi cần thiết.
         */

        var constOOO = Boxing_Unboxing.ooo;
    }

    public static void StaticMethod()
    {
        /* Hàm tĩnh là 1 hàm dùng chung của lớp. Được gọi thông qua tên lớp và không cần khởi tạo bất kỳ đối tượng nào,
        từ đó tránh việc lãng phí bộ nhớ */

        /* 
         * Được gọi thông qua tên lớp, không cần new.
         */
        Boxing_Unboxing.StaticMethod();

        /*
         * Hỗ trợ trong việc viết các hàm tiện ích(extension method) để sử dụng lại.
         */
        var lists = new List<string>();
        foreach (var (item, index) in lists.WithIndex())
        {
        }
    }

    public static void StaticClass()
    {
        /* 
         * Chỉ chứa các thành phần tĩnh (biến tĩnh, phương thức tĩnh).
         * Không thể khai báo, khởi tạo 1 đối tượng thuộc lớp tĩnh.
         * Ràng buộc các thành phần bên trong lớp phải là static.
         * Không cho phép tạo ra các đối tượng dư thừa làm lãng phí bộ nhớ.
         * Mọi thứ đều được truy cập thông qua tên lớp.
         */
    }

    public static string MauChuDao_Wrong = "Red"; // -> it's a no no from me
    public static string MauChuDao;

    public string SetMauChuDao()
    {
        /* switch expression */

        DateTime now = DateTime.UtcNow;
        return now.DayOfWeek switch
        {
            DayOfWeek.Friday => "Black",
            DayOfWeek.Monday => "Blue",
            DayOfWeek.Saturday => "Green",
            DayOfWeek.Sunday => "Yellow",
            DayOfWeek.Thursday => "Pink",
            DayOfWeek.Tuesday => "Red",
            DayOfWeek.Wednesday => "Purple",
            _ => throw new NotImplementedException(), // Discard pattern
        };
    }

    public string SetMauChuDaoAnotherVersion(DayOfWeek dayOfWeek) => dayOfWeek switch
    {
        /* switch expression */

        DayOfWeek.Friday => "Black",
        DayOfWeek.Monday => "Blue",
        DayOfWeek.Saturday => "Green",
        DayOfWeek.Sunday => "Yellow",
        DayOfWeek.Thursday => "Pink",
        DayOfWeek.Tuesday => "Red",
        DayOfWeek.Wednesday => "Purple",
        _ => throw new NotImplementedException(), // Discard pattern
    };

    static StaticExample()
    {
        /*
         * Constructor tĩnh sẽ được gọi 1 lần duy nhất khi chương trình được nạp vào bộ nhớ để thực thi như là 1 cách để ta thiết lập một số thông số
         theo ý muốn trước khi có bất kỳ đối tượng nào được tạo ra.
         */

        /* switch statement */
        /* */
        DateTime now = DateTime.UtcNow;
        switch (now.DayOfWeek)
        {
            case DayOfWeek.Friday:
                MauChuDao = "Black";
                break;
            case DayOfWeek.Monday:
                MauChuDao = "Blue";
                break;
            case DayOfWeek.Saturday:
                MauChuDao = "Green";
                break;
            case DayOfWeek.Sunday:
                MauChuDao = "Yellow";
                break;
            case DayOfWeek.Thursday:
                MauChuDao = "Pink";
                break;
            case DayOfWeek.Tuesday:
                MauChuDao = "Red";
                break;
            case DayOfWeek.Wednesday:
                MauChuDao = "Purple";
                break;
        }
    }

    public void StaticConstructor()
    {
        /* 
         * Không được phép khai báo phạm vi truy cập. Nếu cố tình làm điều này C# sẽ báo lỗi khi biên dịch,
         no public, private before constructor.
         * Constructor tĩnh cũng giống phương thức tĩnh nên không thể gọi các thuộc tính không phải static.
         */
    }

    public static void StaticInitialization()
    {
        Console.WriteLine(x); // 0
        Console.WriteLine(y); // 5
        x = 99;
        Console.WriteLine(x); // 99
    }
}