using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Thiết lập mã hóa UTF-8 để hiển thị tiếng Việt đúng
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Tạo từ điển Anh - Việt
        Dictionary<string, string> dictionary = new Dictionary<string, string>
        {
            { "apple", "táo" },
            { "book", "sách" },
            { "car", "ô tô" },
            { "dog", "chó" },
            { "house", "nhà" },
            { "water", "nước" }
        };

        while (true)
        {
            Console.Write("Nhập từ tiếng Anh cần tra (nhập 'exit' để thoát): ");
            string englishWord = Console.ReadLine().ToLower();

            if (englishWord == "exit")
                break;

            if (dictionary.ContainsKey(englishWord))
            {
                Console.WriteLine($"Nghĩa của '{englishWord}' trong tiếng Việt là: {dictionary[englishWord]}");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy từ '{englishWord}' trong từ điển.");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Chương trình đã kết thúc.");
    }
}