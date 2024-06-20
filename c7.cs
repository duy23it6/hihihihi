using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Đặt mã hóa UTF-8 cho đầu ra của console
        Console.OutputEncoding = Encoding.UTF8;

        // Tạo Từ điển
        Dictionary<string, string> myDictionary = new Dictionary<string, string>();

        // Thêm các cặp key-value vào Từ điển
        myDictionary.Add("apple", "táo");
        myDictionary.Add("banana", "chuối");
        myDictionary.Add("orange", "cam");
        myDictionary.Add("grape", "nho");

        // Kiểm tra xem key có tồn tại trong Từ điển hay không
        if (myDictionary.ContainsKey("banana"))
        {
            Console.WriteLine("Từ điển có chứa key 'banana'.");
        }
        else
        {
            Console.WriteLine("Từ điển không chứa key 'banana'.");
        }

        // Truy xuất giá trị liên kết với key một cách an toàn
        string value;
        if (myDictionary.TryGetValue("orange", out value))
        {
            Console.WriteLine($"Giá trị liên kết với key 'orange' là: {value}");
        }
        else
        {
            Console.WriteLine("Không thể tìm thấy giá trị liên kết với key 'orange'.");
        }

        // Lặp qua các mục trong Từ điển và in chúng
        Console.WriteLine("Các mục trong Từ điển:");
        foreach (KeyValuePair<string, string> item in myDictionary)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
    }
}