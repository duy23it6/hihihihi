using System;
using System.Collections.Generic;
using System.Text;

public class Student
{
    public string Name { get; set; }
    public string Class { get; set; }
    public double Score { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Thiết lập mã hóa UTF-8 để hiển thị tiếng Việt đúng
        Console.OutputEncoding = Encoding.UTF8;

        List<Student> students = new List<Student>();

        while (true)
        {
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("1. Thêm sinh viên mới");
            Console.WriteLine("2. Hiển thị danh sách sinh viên");
            Console.WriteLine("3. Tính tổng điểm của tất cả sinh viên");
            Console.WriteLine("4. Thoát");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent(students);
                    break;
                case 2:
                    DisplayStudents(students);
                    break;
                case 3:
                    CalculateTotalScore(students);
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }

    static void AddStudent(List<Student> students)
    {
        Student student = new Student();

        Console.Write("Nhập tên sinh viên: ");
        student.Name = Console.ReadLine();

        Console.Write("Nhập lớp của sinh viên: ");
        student.Class = Console.ReadLine();

        Console.Write("Nhập điểm của sinh viên: ");
        student.Score = double.Parse(Console.ReadLine());

        students.Add(student);
        Console.WriteLine("Đã thêm sinh viên mới.");
    }

    static void DisplayStudents(List<Student> students)
    {
        if (students.Count == 0)
        {
            Console.WriteLine("Không có sinh viên nào trong danh sách.");
            return;
        }

        Console.WriteLine("Danh sách sinh viên:");
        foreach (var student in students)
        {
            Console.WriteLine($"Tên: {student.Name}, Lớp: {student.Class}, Điểm: {student.Score}");
        }
    }

    static void CalculateTotalScore(List<Student> students)
    {
        double totalScore = 0;
        foreach (var student in students)
        {
            totalScore += student.Score;
        }
        Console.WriteLine($"Tổng điểm của tất cả sinh viên: {totalScore}");
    }
}