using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Khởi tạo Dictionary
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        // Thêm các cặp key-value vào Dictionary
        dictionary.Add("apple", 10);
        dictionary.Add("banana", 5);
        dictionary.Add("orange", 8);

        // Kiểm tra sự tồn tại của key
        string keyToCheck = "banana";
        bool containsKey = dictionary.ContainsKey(keyToCheck);
        Console.WriteLine($"Dictionary có key '{keyToCheck}': {containsKey}");

        // Truy xuất giá trị qua key một cách an toàn
        int value;
        if (dictionary.TryGetValue("orange", out value))
        {
            Console.WriteLine($"Giá trị của 'orange': {value}");
        }
        else
        {
            Console.WriteLine("'orange' không tồn tại trong Dictionary.");
        }

        // Duyệt và in các cặp key-value trong Dictionary
        Console.WriteLine("\nCác mục trong Dictionary:");
        foreach (var pair in dictionary)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }
    }
}
