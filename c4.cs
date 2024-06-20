using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; // Thêm dòng này

        // Kiểm tra với số nguyên
        int num1 = 10;
        int num2 = 20;
        int maxInt = Max(num1, num2);
        Console.WriteLine($"Max của {num1} và {num2} là: {maxInt}");

        // Kiểm tra với số thực
        double dnum1 = 3.14;
        double dnum2 = 2.71;
        double maxDouble = Max(dnum1, dnum2);
        Console.WriteLine($"Max của {dnum1} và {dnum2} là: {maxDouble}");

        // Kiểm tra với chuỗi
        string str1 = "Apple";
        string str2 = "Banana";
        string maxString = Max(str1, str2);
        Console.WriteLine($"Max của '{str1}' và '{str2}' là: {maxString}");
    }

    static T Max<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) >= 0 ? a : b;
    }
}