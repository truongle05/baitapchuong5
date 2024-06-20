using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> tuDien = new Dictionary<string, string>();

        // Thêm các cặp từ vào từ điển
        tuDien.Add("hello", "xin chao");
        tuDien.Add("goodbye", "tam biet");
        tuDien.Add("cat", "con meo");
        tuDien.Add("dog", "con cho");
        tuDien.Add("house", "ngoi nha");

        while (true)
        {
            Console.Write("Nhap tu tieng Anh (hoac nhap 'exit' de thoat): ");
            string nhap = Console.ReadLine().ToLower(); // Chuyen doi input thanh chu thuong

            if (nhap == "exit")
            {
                break;
            }

            if (tuDien.ContainsKey(nhap))
            {
                string nghia = tuDien[nhap];
                Console.WriteLine($"Nghia cua tu '{nhap}' trong tieng Viet la: {nghia}");
            }
            else
            {
                Console.WriteLine($"Tu '{nhap}' khong co trong tu dien.");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Cam on ban da su dung tu dien.");
    }
}
