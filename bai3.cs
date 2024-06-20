using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList danhSachSanPham = new ArrayList();

        while (true)
        {
            Console.WriteLine("1. Them san pham moi");
            Console.WriteLine("2. Hien thi danh sach san pham");
            Console.WriteLine("3. Tim kiem san pham theo ten");
            Console.WriteLine("4. Thoat chuong trinh");
            Console.Write("Nhap lua chon cua ban: ");

            string luaChon = Console.ReadLine();
            Console.WriteLine();

            switch (luaChon)
            {
                case "1":
                    ThemSanPham(danhSachSanPham);
                    break;
                case "2":
                    HienThiDanhSachSanPham(danhSachSanPham);
                    break;
                case "3":
                    TimKiemSanPhamTheoTen(danhSachSanPham);
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

    static void ThemSanPham(ArrayList danhSachSanPham)
    {
        Console.Write("Nhap ten san pham: ");
        string tenSanPham = Console.ReadLine();
        Console.Write("Nhap mo ta san pham: ");
        string moTaSanPham = Console.ReadLine();
        Console.Write("Nhap gia san pham: ");
        double giaSanPham = double.Parse(Console.ReadLine());

        SanPham sanPham = new SanPham { Ten = tenSanPham, MoTa = moTaSanPham, Gia = giaSanPham };
        danhSachSanPham.Add(sanPham);

        Console.WriteLine("Them san pham thanh cong!");
    }

    static void HienThiDanhSachSanPham(ArrayList danhSachSanPham)
    {
        if (danhSachSanPham.Count == 0)
        {
            Console.WriteLine("Danh sach san pham hien dang trong.");
        }
        else
        {
            Console.WriteLine("Danh sach san pham:");
            foreach (SanPham sanPham in danhSachSanPham)
            {
                Console.WriteLine($"- Ten: {sanPham.Ten}, Mo ta: {sanPham.MoTa}, Gia: {sanPham.Gia}");
            }
        }
    }

    static void TimKiemSanPhamTheoTen(ArrayList danhSachSanPham)
    {
        Console.Write("Nhap ten san pham can tim: ");
        string tenCanTim = Console.ReadLine();

        bool timThay = false;
        foreach (SanPham sanPham in danhSachSanPham)
        {
            if (sanPham.Ten.ToLower() == tenCanTim.ToLower())
            {
                Console.WriteLine($"Thong tin san pham '{sanPham.Ten}':");
                Console.WriteLine($"- Mo ta: {sanPham.MoTa}");
                Console.WriteLine($"- Gia: {sanPham.Gia}");
                timThay = true;
                break;
            }
        }

        if (!timThay)
        {
            Console.WriteLine($"Khong tim thay san pham '{tenCanTim}'.");
        }
    }
}

class SanPham
{
    public string Ten { get; set; }
    public string MoTa { get; set; }
    public double Gia { get; set; }
}
