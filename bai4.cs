using System;

class Program
{
    static void Main()
    {
        // Kiểm tra hàm Max với các kiểu dữ liệu khác nhau
        int maxInt = Max(5, 10);
        Console.WriteLine($"Max của 5 và 10 là: {maxInt}");

        double maxDouble = Max(3.5, 9.2);
        Console.WriteLine($"Max của 3.5 và 9.2 là: {maxDouble}");

        string maxString = Max("apple", "banana");
        Console.WriteLine($"Max của 'apple' và 'banana' là: {maxString}");

        Console.WriteLine();

        // Thêm một số kiểm tra khác nếu muốn

        // Ví dụ thêm một ví dụ với DateTime
        DateTime maxDateTime = Max(DateTime.Now, DateTime.Now.AddDays(1));
        Console.WriteLine($"Max của ngày hôm nay và ngày mai là: {maxDateTime}");
    }

    // Hàm generic để tìm giá trị lớn nhất giữa hai giá trị
    static T Max<T>(T a, T b) where T : IComparable<T>
    {
        // Sử dụng CompareTo để so sánh và trả về giá trị lớn hơn
        return a.CompareTo(b) >= 0 ? a : b;
    }
}
