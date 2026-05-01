using System;

namespace Reverse_Words_in_Sentence
{ 
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập chuỗi: ");
        string a = Console.ReadLine();
        string[] b = a.Split(' ');
        Array.Reverse(b);
        string c = string.Join(" ", b);
        Console.WriteLine("Chuỗi sau khi đảo ngược: " + c);
    }
}
}
