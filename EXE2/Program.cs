using System;   

class Program   
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("nhập 4 số muốn tính trung bình:");
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string c = Console.ReadLine();
        string d = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(a) || string.IsNullOrWhiteSpace(b) || string.IsNullOrWhiteSpace(c) || string.IsNullOrWhiteSpace(d))
        {
            Console.WriteLine("vui lòng nhập đủ 4 số");
        }
        else
        {
            int average = (int.Parse(a) + int.Parse(b) + int.Parse(c) + int.Parse(d)) / 4;
            Console.WriteLine($"trung bình cộng của 4 số là: {average}");
        }


    }
}