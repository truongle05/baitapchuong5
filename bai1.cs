using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        while (true)
        {
            Console.WriteLine("1. Them sinh vien moi");
            Console.WriteLine("2. Hien thi danh sach sinh vien");
            Console.WriteLine("3. Tinh tong diem cua tat ca sinh vien");
            Console.WriteLine("4. Thoat chuong trinh");
            Console.Write("Nhap lua chon cua ban: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    ThemSinhVien(students);
                    break;
                case "2":
                    HienThiDanhSachSinhVien(students);
                    break;
                case "3":
                    TinhTongDiem(students);
                    break;
                case "4":
                    Console.WriteLine("Thoat chuong trinh...");
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void ThemSinhVien(List<Student> students)
    {
        Console.Write("Nhap ten sinh vien: ");
        string name = Console.ReadLine();
        Console.Write("Nhap lop cua sinh vien: ");
        string className = Console.ReadLine();

        students.Add(new Student { Name = name, Class = className });

        Console.WriteLine("Them sinh vien thanh cong!");
    }

    static void HienThiDanhSachSinhVien(List<Student> students)
    {
        if (students.Count == 0)
        {
            Console.WriteLine("Danh sach sinh vien hien dang trong.");
        }
        else
        {
            Console.WriteLine("Danh sach sinh vien:");
            foreach (var student in students)
            {
                Console.WriteLine($"- Ten: {student.Name}, Lop: {student.Class}");
            }
        }
    }

    static void TinhTongDiem(List<Student> students)
    {
        int totalCount = students.Count;
        Console.WriteLine($"Tong so sinh vien: {totalCount}");
    }
}

class Student
{
    public string Name { get; set; }
    public string Class { get; set; }
}
