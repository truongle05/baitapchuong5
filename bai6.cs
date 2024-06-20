using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Khởi tạo Hashtable
        Hashtable hashtable = new Hashtable();

        // Thêm các cặp key-value vào Hashtable
        hashtable.Add("Sinh viên 1", "Nguyễn Văn A");
        hashtable.Add("Sinh viên 2", "Trần Thị B");
        hashtable.Add("Sinh viên 3", "Lê Hoàng C");

        // Kiểm tra sự tồn tại của key và value
        string keyToCheck = "Sinh viên 2";
        string valueToCheck = "Lê Hoàng C";

        bool containsKey = hashtable.ContainsKey(keyToCheck);
        bool containsValue = hashtable.ContainsValue(valueToCheck);

        Console.WriteLine($"Hashtable có key '{keyToCheck}': {containsKey}");
        Console.WriteLine($"Hashtable có value '{valueToCheck}': {containsValue}");

        // Truy xuất giá trị qua key
        string sinhVien1 = (string)hashtable["Sinh viên 1"];
        Console.WriteLine($"Thông tin của '{keyToCheck}': {sinhVien1}");

        // Duyệt và in các cặp key-value trong Hashtable
        Console.WriteLine("\nCác sinh viên trong Hashtable:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}
